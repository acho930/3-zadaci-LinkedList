using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(42);
            numbers.AddLast(7);
            numbers.AddLast(19);
            numbers.AddLast(3);
            numbers.AddLast(88);
            numbers.AddLast(56);
            List<int> sortednumbers = new List<int>(numbers);
            sortednumbers.Sort();
            LinkedList<int> sortedList = new LinkedList<int>(sortednumbers);
            Console.WriteLine("Podreden spisyk");
            foreach (int num in sortedList)
            {
                Console.WriteLine(num);
            }



        }
    }
}
