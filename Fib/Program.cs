using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fib
{
    internal class Program
    {
        

        static void Main(string[] args)

{

        int n, first = 0, second = 1, third = 0;

        Console.Write("Enter a number : ");

        n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First {0} Fibonacci numbers", n);
            Console.WriteLine(first);
            Console.WriteLine(second);
        for (int i = 3; i <= n; i++)

        {

            third = first + second;

            Console.WriteLine("{0} ", third);

            first = second;

            second = third;


            


        }
        Console.Read();
}

        //private static void Main(string[] args)
        //{
        //}

    //    public static UInt64 GetNthFibonacciNumber(uint n)
    //{
    //    if (n == 0 || n == 1)
    //    {
    //        return 1;
    //    }
    //    UInt64 a = 1, b = 1;
    //    uint i = 2;
    //    while (i <= n)
    //    {
    //        if (a > b) b += a;
    //        else a += b;
    //        ++i;
    //    }
    //    return (a > b) ? a : b;
    //}

        //public static int GetNthFibonacci_Ite (int n)

        //    {
        //        int number = n - 1; //Need to decrement by 1 since we are starting from 0
        //        int[] Fib = new int[number + 1];
        //        Fib[0] = 0;
        //        Fib[1] = 1;

        //        for (int i = 2; i <= number; i++)
        //        {
        //            Fib[i] = Fib[i - 2] + Fib[i - 1];
        //        }
        //        return Fib[number];
            }
        }
    

    
    

