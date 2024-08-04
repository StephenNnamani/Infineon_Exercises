using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infineon_Exercises.Exercise_3a
{
    public class ClassA
    {
        public string? Name { get; set; }

        public void PrintName()
        {
           //Console.WriteLine(Name);
        }
    }

    public class ClassB : ClassA
    {
        public void PrintMessage(string message)
        {
            //Console.WriteLine(message);
        }
    }
    public class ClassC : ClassB
    {
        public void PrintName(string message)
        {
            //Console.WriteLine(message);
        }
    }
    public class ClassD : ClassA
    {
        
    }
}
