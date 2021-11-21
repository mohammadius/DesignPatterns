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
		return $"FullName: {FirstName} {LastName}\nDate of Birth: {BirthDate:D}\nAddress: {Address}";
	}
}