using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaPetyaMasha
{
    abstract class People
    {
        public abstract void Run(double km);

        public abstract void Talk(string talk);

        public abstract int Age();

        public abstract string Name();

        public abstract string Surname();
       
    }
}
