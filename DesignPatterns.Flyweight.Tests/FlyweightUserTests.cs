using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;

namespace DesignPatterns.Flyweight.Tests;

// 10,000 users:
//		GetNewObjects():
//			Normal Users:		1036644 Bytes
//			Flyweight Users:	744256 Bytes
//		GetSurvivedObjects():
//			Normal Users:		9246652 Bytes
//			Flyweight Users:	9028305 Bytes
public class FlyweightUserTests
{
	private List<string> _firstNames;
	private List<string> _lastNames;

	[SetUp]
	public void Setup()
	{
		_firstNames = Enumerable.Range(0, 100).Select(_ => RandomString()).ToList();
		_lastNames = Enumerable.Range(0, 100).Select(_ => RandomString()).ToList();
	}

	[Test]
	public void NormalUserTest()
	{
		ForceGC();
		var snapshot = dotMemory.Check();

		var users = new List<User>();
		foreach (var firstName in _firstNames)
		{
			foreach (var lastName in _lastNames)
			{
				users.Add(new User($"{firstName} {lastName}"));
			}
		}

		ForceGC();
		dotMemory.Check(memory =>
		{
			Console.WriteLine(memory.GetDifference(snapshot).GetSurvivedObjects().SizeInBytes);
		});
	}

	[Test]
	public void FlyweightUserTest()
	{
		ForceGC();
		var snapshot = dotMemory.Check();

		var flyweightUsers = new List<FlyweightUser>();
		foreach (var firstName in _firstNames)
		{
			foreach (var lastName in _lastNames)
			{
				flyweightUsers.Add(new FlyweightUser($"{firstName} {lastName}"));
			}
		}

		ForceGC();
		dotMemory.Check(memory =>
		{
			Console.WriteLine(memory.GetDifference(snapshot).GetSurvivedObjects().SizeInBytes);
		});
	}

	private void ForceGC()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}

	private static string RandomString()
	{
		var rand = new Random();
		return new string(Enumerable.Range(0, 10).Select(_ => (char)('a' + rand.Next(26))).ToArray());
	}
}