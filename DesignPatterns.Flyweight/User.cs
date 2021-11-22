namespace DesignPatterns.Flyweight;

public class User
{
	public string FullName { get; }

	public User(string fullName)
	{
		FullName = fullName;
	}
}