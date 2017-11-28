using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_arrayClass
{
    class ArClass
    {
        private static Random rnd = new Random();
        public int[] MyArr { get; set; }
        private int ArrSum { get; set; } = 0;

        public ArClass():this(0){}
        public ArClass(int size)
        {
            MyArr = size != 0 ? new int[size] : new int[rnd.Next(1, 10)];

            for (int i = 0; i < MyArr.Length; i++)
                MyArr[i] = rnd.Next(1, 101);

            //используем LINQ
            ArrSum = MyArr.Sum();
        }

        public void PrintArr()
        {
            Console.Write("{ ");

            for (int i = 0; i < MyArr.Length; i++)
                Console.Write($"{this.MyArr[i]}, ");

            Console.WriteLine("}");
            Console.WriteLine($"SUM: {this.ArrSum}");
        }
        public static bool operator >(ArClass obj1, ArClass obj2)
        {
            return obj1.ArrSum > obj2.ArrSum;
        }
        public static bool operator <(ArClass obj1, ArClass obj2)
        {
            return obj1.ArrSum < obj2.ArrSum;
        }
    }
}
