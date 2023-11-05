using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal.Animals
{
    public class Bird : Animal
    {
        public string TypeOfFeathers { get; set; }

        public Bird(string name, int age, string typeOfFeathers)
        {
            Name = name;
            Age = age;
            TypeOfFeathers = typeOfFeathers;
        }
    }
}
