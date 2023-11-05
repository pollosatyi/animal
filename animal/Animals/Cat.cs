using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal.Animals
{
    public class Cat:Animal
    {
        public string CatBreed {  get; set; }

        public Cat(string name,int age,string catBreed)
        {
            Name = name;
            Age = age;
            CatBreed = catBreed;
        }
    }
}
