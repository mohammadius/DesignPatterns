﻿namespace DesignPatterns.Builder;

public class User
{
	public User(string firstName, string lastName, DateTime birthDate, Address address)
	{
		FirstName = firstName;
		LastName = lastName;
		BirthDate = birthDate;
		Address = address;
	}

	public string FirstName { get; }
	public string LastName { get; }
	public DateTime BirthDate { get; }
	public Address Address { get; }

	public override string ToString()
	{
		return $"FullName: {FirstName} {LastName}, Date of Birth: {BirthDate:MMMM d, yyyy}, Address: {Address}";
	}
}