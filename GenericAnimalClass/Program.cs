using System;
// define a generics class named Student
public class Animal<T>
{
    // define a field of type T 
    public T data;

    // define a constructor of the Student class 
    public Animal(T data)
    {
        this.data = data;
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Sheep");
        Console.WriteLine($"Name: {animalName.getAnimal()}");
        Animal<string> animalHabitat = new Animal<string>("Bill's Barn");
        Console.WriteLine($"Habitat: {animalHabitat.getAnimal()}");

        Animal<Boolean> endangered= new Animal<bool>(true);
        Console.WriteLine($"Endangered: {endangered.getAnimal()}");
        Animal<Boolean> extinct = new Animal<bool>(false);
        Console.WriteLine($"Extinct: {extinct.getAnimal()}");

        Animal<int> averageLifespan = new Animal<int>(10);
        Console.WriteLine($"Average Lifespan: {averageLifespan.getAnimal()}");  
    }
}
