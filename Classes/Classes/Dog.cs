using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Dog
    {
        //fields
        private string _name;
        string _owner; // private by default
        private readonly DateTime _birthDate;
        public const decimal PI = 3.141516M;
        public static int nrOfInstances;

        //parameterless constructor - in constructor ar trebui sa punem parametrii obligatorii care fac ca obiectul sa fie sanatos
        public Dog()
        {

        }

        public Dog(string name)
        {
            _name = name;
        }

        public Dog(string name, string owner)
        {
            _name = name;
            _owner = owner;
            _birthDate = DateTime.Now;
            nrOfInstances++;
        }

        public void Bark()
        {
            string _name = "local name";
            Console.WriteLine("Ham Ham");
            decimal awesomePI = PI * 2;
        }

        public static int GetTotalInstancesCreated()
        {
            return nrOfInstances;
        }
    }
}
