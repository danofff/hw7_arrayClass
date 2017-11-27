using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_arrayClass
{
    class arClass
    {
        private static Random rnd = new Random();
        private int [] myArr;
        public int [] MyArr
        {
            get { return myArr; }
            set { myArr = value; }
        }
        private int arrSum;
        private int ArrSum
        {
            get { return arrSum; }
            set { arrSum = value; }
        }

        public arClass()
        {
            this.ArrSum = 0;
            int size = rnd.Next(1, 10);
            this.MyArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                this.MyArr[i] = rnd.Next(1, 101);
                this.ArrSum += this.MyArr[i];
            }
        }
        public arClass(int size)
        {
            this.ArrSum = 0;
            this.MyArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                MyArr[i] = rnd.Next(1, 101);
                this.ArrSum += this.MyArr[i];
            }
        }
        public void printArr()
        {

            Console.Write("{ ");
            for (int i = 0; i < MyArr.Length; i++)
            {
                Console.Write($"{this.MyArr[i]}, ");
            }
            Console.WriteLine("}");
            Console.WriteLine($"SUM: {this.ArrSum}");
        }
        public static bool operator>(arClass obj1,arClass obj2)
        {
            return obj1.ArrSum > obj2.ArrSum;
        }
        public static bool operator <(arClass obj1, arClass obj2)
        {
            return obj1.ArrSum < obj2.ArrSum;
        }
    }
}
