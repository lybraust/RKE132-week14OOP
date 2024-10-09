Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbors dog name is {neighboursDog.Name}");

myDog.Rename("Bad Boy");
Console.WriteLine($"Level of hapiness: {myDog.LevelOfHapiness}");

//myDog.Bark();
//Console.WriteLine($"Level of hapiness: {myDog.LevelOfHapiness}");

//Dog neighboursDog = new Dog();

while (myDog.LevelOfHapiness != 5)
{ 
myDog.Bark();
}

myDog.WagTail();
class Dog
{
    private string _name;
    private int _levelOfHapiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("wiggle-wiggle!");
    }
}
