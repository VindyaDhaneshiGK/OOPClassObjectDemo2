using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassObjectDemo2
{
    public class Person
    {
        // Define the Name property
        public string Name { get; set; }

        // Define the Age property
        public int Age { get; set; }

        // Define the Greet method
        public void Greet()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}
