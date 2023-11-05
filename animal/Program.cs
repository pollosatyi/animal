using animal.Animals;

namespace animal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите животное для заполнения: ");
            Console.WriteLine("1 для собаки: ");
            Console.WriteLine("2 для кошки ");
            Console.WriteLine("3 для птицы");
            List<Animal> animals = new List<Animal>();
            CreateAnimals createAnimals = new CreateAnimals();
           animals.Add((Dog)(CreateAnimals.CreateAnimal(TypeAnimals.Dog)));
            Dog dog = (Dog)animals[0];
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.BreedDogSize);
            Console.WriteLine((Dog)animals[0].BreedDogSize);
            

        }
    }
}