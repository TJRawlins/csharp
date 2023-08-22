using InterfaceExample;

// impossible to put these pets into an array without an interface
var dog1 = new Dog() { Species = "Dog", Breed = "Golden Retriever", Color = "Yellow", Speak = "Woof" };
var dog2 = new Dog() { Breed = "English Mastiff", Color = "Brindle", Speak = "A very deed bark" };

var cat1 = new Cat() { Breed = "American Short Hair", Age = 5, Speak = "Purrrrrr" };
var cat2 = new Cat() { Breed = "Hairless", Age = 3, Speak = "Clicking and Chirping" };

var hamster1 = new Hamster() { Breed = "Fancy", Color = "Gold", Speak = "Squeak" };
var hamster2 = new Hamster() { Breed = "Teddy Bear", Color = "Black & White", Speak = "Roar" };

// interface can be a collection/array type
IBreedSpeak[] pets = { dog1, dog2, cat1, cat2, hamster1, hamster2};

foreach (var pet in pets)
{
    Console.WriteLine($"We have a {pet.Breed} {pet.Species} which makes a sound of {pet.Speak}");
}