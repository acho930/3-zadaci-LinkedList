using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>(new int[] { 5, 10, 15, 20, 25, 30 });

            Console.WriteLine($"Числото 19 е в списъка: {SearchNumber(numbers, 19)}");
            Console.WriteLine($"Числото 100 е в списъка: {SearchNumber(numbers, 100)}");
        }

        static bool SearchNumber(LinkedList<int> list, int num)
        {
            return list.Contains(num);
        }
    }
}
    
