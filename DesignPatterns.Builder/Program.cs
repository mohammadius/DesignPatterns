using DesignPatterns.Builder;

var user1 = new User("Mohammad", "Hashemi", new DateTime(1997, 11, 21),
	new Address("Iran", "Ahwaz", 12345));
Console.WriteLine(user1);

var user2 = new SimpleFluentUserBuilder()
	.WithFirstName("Reza")
	.WithLastName("Hashemi")
	.WithBirthDate(new DateTime(1994, 2, 5))
	.WithCountry("Iran")
	.WithCity("Tehran")
	.WithPostalCode(6789)
	.Build();
Console.WriteLine(user2);