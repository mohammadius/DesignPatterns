namespace DesignPatterns.Builder;

public class ComplicatedFluentUserBuilder :
	IPostalCodeSelectionStage,
	IFirstNameSelectionStage,
	ILastNameSelectionStage,
	IBirthDateSelectionStage,
	ICountrySelectionStage,
	ICitySelectionStage
{
	private string _firstName;
	private string _lastName;
	private DateTime _birthDate;
	private string _country;
	private string _city;
	private int _postalCode;

	private ComplicatedFluentUserBuilder()
	{
	}

	public static IFirstNameSelectionStage CreateUser()
	{
		return new ComplicatedFluentUserBuilder();
	}

	public ILastNameSelectionStage WithFirstName(string firstName)
	{
		_firstName = firstName;
		return this;
	}

	public IBirthDateSelectionStage WithLastName(string lastName)
	{
		_lastName = lastName;
		return this;
	}

	public ICountrySelectionStage WithBirthDate(int year, int month, int day)
	{
		_birthDate = new DateTime(year, month, day);
		return this;
	}

	public ICitySelectionStage WithCountry(string country)
	{
		_country = country;
		return this;
	}

	public IPostalCodeSelectionStage WithCity(string city)
	{
		_city = city;
		return this;
	}

	public User WithPostalCode(int postalCode)
	{
		_postalCode = postalCode;
		var address = new Address(_country, _city, _postalCode);
		return new User(_firstName, _lastName, _birthDate, address);
	}
}

public interface IFirstNameSelectionStage
{
	public ILastNameSelectionStage WithFirstName(string firstName);
}

public interface ILastNameSelectionStage
{
	public IBirthDateSelectionStage WithLastName(string lastname);
}

public interface IBirthDateSelectionStage
{
	public ICountrySelectionStage WithBirthDate(int year, int month, int day);
}

public interface ICountrySelectionStage
{
	public ICitySelectionStage WithCountry(string country);
}

public interface ICitySelectionStage
{
	public IPostalCodeSelectionStage WithCity(string city);
}

public interface IPostalCodeSelectionStage
{
	public User WithPostalCode(int postalCode);
}