using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_arrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            arClass a1 = new arClass(10);
            arClass a2 = new arClass(10);
            a1.printArr();
            a2.printArr();
            Console.WriteLine("overload >");
            Console.WriteLine(a1>a2);
            Console.WriteLine("overload <");
            Console.WriteLine(a1<a2);
        }
    }
}
