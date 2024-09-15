using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MiliukovLO.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MiliukovLO.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(7, 5));
            Console.WriteLine(DataService.Multiplication(1, 5));
            Console.WriteLine(DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}