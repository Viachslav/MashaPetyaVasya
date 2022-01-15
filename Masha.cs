using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaPetyaMasha
{
    class Masha : Woman
    {

        private int _age;
        private string _name;
        private string _surname;
        private string _car;

        public override void Run(double km)
        {
            Console.WriteLine($"{km} + kilometres");
        }
        public override void Talk(string talk)
        {
            Console.WriteLine($"Masha says {talk}");
        }

        public override void giveBirth()
        {
            Console.WriteLine($"Masha can or can't make children");
        }

        public override void Pregnancy()
        {
            Console.WriteLine($"Masha can be pregnant");
        }

        public override int Age()
        {
            return _age;
        }

        public override string Name()
        {
            return _name;
        }

        public override string Surname()
        {
            return _surname;
        }

        public void HasCar()
        {
            Console.WriteLine($"Masha has a car namely {_car}");
        }

        public string HasNiceLegs()
        {
            return "Masha has a spectacular legs";
        }

    }

}
