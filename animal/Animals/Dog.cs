using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal.Animals
{
    public class Dog : Animal
    {
        public  int BreedDogSize {  get; set; }

        public Dog() { }
        public Dog(string name,int age, int breedDogSize)
        {
            Name = name;
            Age = age;
            BreedDogSize = breedDogSize;
        }

    }
}
