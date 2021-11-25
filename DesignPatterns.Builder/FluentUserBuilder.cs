namespace DesignPatterns.Builder;

public class FluentUserBuilder
{
	private string _firstName;
	private string _lastName;
	private DateTime _birthDate;
	private string _country;
	private string _city;
	private int _postalCode;

	public FluentUserBuilder WithFirstName(string firstName)
	{
		_firstName = firstName;
		return this;
	}

	public FluentUserBuilder WithLastName(string lastName)
	{
		_lastName = lastName;
		return this;
	}

	public FluentUserBuilder WithBirthDate(int year, int month, int day)
	{
		_birthDate = new DateTime(year, month, day);
		return this;
	}

	public FluentUserBuilder WithCountry(string country)
	{
		_country = country;
		return this;
	}

	public FluentUserBuilder WithCity(string city)
	{
		_city = city;
		return this;
	}

	public FluentUserBuilder WithPostalCode(int postalCode)
	{
		_postalCode = postalCode;
		return this;
	}

	public User Build()
	{
		var address = new Address(_country, _city, _postalCode);
		return new User(_firstName, _lastName, _birthDate, address);
	}
}