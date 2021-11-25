var user1 = new User("Mohammad", "Hashemi",
	new DateTime(1997, 11, 21),
	new Address("Iran", "Ahwaz", 12345));
Console.WriteLine(user1);

var userBuilder = new FluentUserBuilder();
userBuilder.WithFirstName("Reza")
	.WithLastName("Hashemi")
	.WithBirthDate(1994, 2, 5)
	.WithCountry("Iran")
	.WithCity("Tehran")
	.WithPostalCode(6789);
var user2 = userBuilder.Build();
Console.WriteLine(user2);

var user3 = ComplicatedFluentUserBuilder.CreateUser()
	.WithFirstName("Mohammad")
	.WithLastName("Hashemi")
	.WithBirthDate(1997, 11, 21)
	.WithCountry("Iran")
	.WithCity("Ahwaz")
	.WithPostalCode(12345);
Console.WriteLine(user3);