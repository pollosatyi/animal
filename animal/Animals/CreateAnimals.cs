using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal.Animals
{
    public class CreateAnimals
    {
        public static Animal CreateAnimal(TypeAnimals animalType)
        {
            Animal animal = null;
            switch (animalType)
            {
                case TypeAnimals.Dog:
                    int breedDogSize = 0;

                    Console.WriteLine("Введите имя собаки: ");
                    string nameDog = Console.ReadLine();
                    Console.WriteLine("Введите возраст собаки: ");
                    int ageDog = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите размер породы собаки: ");
                    breedDogSize = int.Parse(Console.ReadLine());
                    Animal dog = new Dog(nameDog, ageDog, breedDogSize);
                    return dog;
                case TypeAnimals.Cat:
                    Console.WriteLine("Введите имя кошки: ");
                    string nameCat = Console.ReadLine();
                    Console.WriteLine("Введите возраст кошки: ");
                    int ageCat = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите породу кошки: ");
                   string catBreed = Console.ReadLine();
                    Animal cat = new Cat(nameCat, ageCat, catBreed);
                    return cat;
                case TypeAnimals.Bird:
                    Console.WriteLine("Введите имя птицы: ");
                    string birdName= Console.ReadLine();
                    Console.WriteLine("Введите возраст птицы: ");
                    int birdAge= int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите тип перьев: ");
                    string typeOfFeathers=Console.ReadLine();
                    Animal bird = new Bird(birdName,birdAge,typeOfFeathers);
                    return bird;
                default:
                    return animal;

            }





            // FillAnimalsProteries.ChooseAnimal(animalType) ;

        }
    }
}
