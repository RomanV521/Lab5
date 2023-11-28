namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Alex", "beagle", "brown", true);
            Dog dog2 = new Dog("Ollie", "yorkshire terrier", "white", true);

            Cat cat1 = new Cat("Aron", false, true, 0.3);
            Cat cat2 = new Cat("Chip", true, false, 1);

            dog1.Sleep();
            dog2.Eat();
            cat1.Walk();
            cat2.Sleep();

            Animals animals = new Animals(dog1, cat1);
            Console.WriteLine(animals);

            animals.Add(cat2);
            animals.Add(dog2);
            Console.WriteLine(animals);

            animals.Remove(cat1);
            animals.Remove(0);
            Console.WriteLine(animals);

            animals.Add(dog1);
            animals.Edit(dog1, new Dog("Jake", "-", "black", false));
            animals.Edit(0, cat1);
            Console.WriteLine(animals);
        }
    }
}