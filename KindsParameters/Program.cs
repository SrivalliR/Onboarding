using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //PassByValue
            Console.WriteLine("****PassByValue******");
            int y = 50;
            Print(y);
            Console.WriteLine("Pass by Value: Value of y ="+y);
            //Console.ReadKey();

            //PassbyReference
            Console.WriteLine("****PassbyReference******");
            int a=10;
            PrintRef(ref a);
            Console.WriteLine("Pass by Reference: Value of A is "+a);
            //Console.ReadKey();

            //OutParameters
            Console.WriteLine("****OutParameters******");
            numberOper(5, 3, out int m,out int n);
            Console.WriteLine("Out paramaetrs : Values of m(Addition) & n(Multiplication are "+ m +" & "+ n);
            //Console.ReadKey();  

            //General array means need to give the values and then pass to the MultiplyNums()
            //int[] num = { 1, 2, 3 };
            //Console.WriteLine(MultiplyNums(num));
            //Console.ReadLine();

            //Params means we can intialize as many as directly
            Console.WriteLine("****Params []******");
            int result = MultiplyNums(7, 9, 2, 3, 3);
            Console.WriteLine("Params result: Product of params values (2,3,3) is " + result);
            Console.ReadLine();

        }
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        //Pass by value
        public static void Print(int x)
        {
            x = 100;
            Console.WriteLine("Value of x is "+ x);
        }
        //passbyReference
        public static void PrintRef(ref int b)
        {
            b = 500;
            //Console.WriteLine("Value of b "+b);

        }

        //Outparameters
        static void numberOper(int a,int b, out int addNum, out int mulnum)
        {
            addNum = a + b;
            mulnum = a * b;
        }

        //Parameterized array or Params[]
        //Params should be last in the arguments list and only one params is allowed
        static int MultiplyNums(int a , int b, params int[] Numbers)
        {
            int mul=1;
            foreach (var item in Numbers)
            {
                mul = mul * item;
            }
            return mul;
        }
    }
}
