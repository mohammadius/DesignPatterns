namespace DesignPatterns.Flyweight;

public class FlyweightUser
{
	private static readonly IList<string> _strings = new List<string>();
	private readonly int[] _names;
	public string FullName => string.Join(' ', _names.Select(i => _strings[i]));

	public FlyweightUser(string fullName)
	{
		_names = fullName.Split(' ').Select(GetOrAdd).ToArray();
	}

	private static int GetOrAdd(string s)
	{
		var index = _strings.IndexOf(s);
		if (index != -1)
		{
			return index;
		}

		_strings.Add(s);
		return _strings.Count - 1;
	}
}