using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 7.	В трехзначном числе x зачеркнули его вторую цифру. 
 Когда к образованному при этом двузначному числу справа 
 приписали вторую цифру числа x, то получилось число 456. 
 Найти число x.
     */
namespace CW_1._7_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("В трехзначном числе x зачеркнули его вторую цифру.");
            Console.WriteLine("Когда к образованному при этом двузначному числу справа");
            Console.WriteLine("приписали вторую цифру числа x, то получилось число 456.");
            var num = 456;
            var initNum = 100 * (num / 100) + (num / 10) % 10 + 10 * (num % 10);

            Console.Write("x=");
            Console.WriteLine(initNum);
            Console.ReadKey();
        }
    }
}
