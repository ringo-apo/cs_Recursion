using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("再帰で１から「ある数字n」までの整数の和を求める。");
            Console.WriteLine("sum(n)=sum(n-1)+n");
            Console.WriteLine("sum(1)=1");
            Console.WriteLine("数字nを入力してください。");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("sum({0}) = {1}", n, Sum(n));
        }

        static int Sum(int _)
        {

            if (_ == 1)
            {
                return 1;
            }
            else
            {
                return Sum(_-1) + _;
            }
        }
    }
}
