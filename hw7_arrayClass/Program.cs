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
            ArClass a1 = new ArClass(10);
            ArClass a2 = new ArClass(10);
            a1.PrintArr();
            a2.PrintArr();
            Console.WriteLine("overload >");
            Console.WriteLine(a1>a2);
            Console.WriteLine("overload <");
            Console.WriteLine(a1<a2);
        }
    }
}
