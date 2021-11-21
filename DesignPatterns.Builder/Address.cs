namespace DesignPatterns.Builder;

public class Address
{
	public Address(string country, string city, int postalCode)
	{
		Country = country;
		City = city;
		PostalCode = postalCode;
	}

	public string Country { get; }
	public string City { get; }
	public int PostalCode { get; }

	public override string ToString()
	{
		return $"{Country}, {City}, {PostalCode}";
	}
}