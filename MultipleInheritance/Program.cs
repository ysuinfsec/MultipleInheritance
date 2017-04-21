using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleClass = new SampleClass();
            Console.WriteLine(sampleClass.GetA());
            Interface1 i1 = sampleClass;
            Interface2 i2 = sampleClass;
            Console.WriteLine(i1.GetA());
            Console.WriteLine(i2.GetA());
            Console.WriteLine(i1.GetB());


        }
    }
}
