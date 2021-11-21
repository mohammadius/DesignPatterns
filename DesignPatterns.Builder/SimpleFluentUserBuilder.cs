namespace DesignPatterns.Builder;

public class SimpleFluentUserBuilder
{
	private string _firstName;
	private string _lastName;
	private DateTime _birthDate;
	private string _country;
	private string _city;
	private int _postalCode;

	public SimpleFluentUserBuilder WithFirstName(string firstName)
	{
		_firstName = firstName;
		return this;
	}

	public SimpleFluentUserBuilder WithLastName(string lastName)
	{
		_lastName = lastName;
		return this;
	}

	public SimpleFluentUserBuilder WithBirthDate(DateTime birthDate)
	{
		_birthDate = birthDate;
		return this;
	}

	public SimpleFluentUserBuilder WithCountry(string country)
	{
		_country = country;
		return this;
	}

	public SimpleFluentUserBuilder WithCity(string city)
	{
		_city = city;
		return this;
	}

	public SimpleFluentUserBuilder WithPostalCode(int postalCode)
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