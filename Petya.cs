using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaPetyaMasha
{
       class Petya : Man
       {

            private int _age;
            private string _name;
            private string _surname;
            private int _numberofchildren;

            public override void Talk(string speechP)
            {
                Console.WriteLine($"Petya said that: + {speechP}");
            }

            public override void Run(double km)
            {
                Console.WriteLine($"Petya ran: + {km}");
            }

            public override void Insamination()
            {
                Console.WriteLine($"Petya can make a girl pregnant");
            }

            public override void Thinking()
            {
                Console.WriteLine("Petya can be a very thoughtful man");
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


            public void PersonCharacter()
            {
                Console.WriteLine("Petya is a very reliable person");
            }

            public int NumberOfChildren()
            {
                return _numberofchildren;
            }


    }
}
