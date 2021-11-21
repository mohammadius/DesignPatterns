using DesignPatterns.Builder;

var user = new User("Mohammad", "Hashemi", new DateTime(1997, 11, 21),
	new Address("Iran", "Ahwaz", 12345));

Console.WriteLine(user);

var userBuilder = new SimpleFluentUserBuilder()
	.WithFirstName("Reza")
	.WithLastName("Hashemi")
	.WithBirthDate(new DateTime(1994, 2, 5))
	.WithCountry("Iran")
	.WithCity("Tehran")
	.WithPostalCode(6789);

var user2 = userBuilder.Build();

Console.WriteLine(user2);