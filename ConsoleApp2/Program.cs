using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(new int[] { 3, 7, 19, 42, 56, 88 });

            Console.WriteLine("Оригинален списък:");
            PrintLinkedList(list);

          
            LinkedList<int> reversedList = ReverseLinkedList(list);

            Console.WriteLine("Обърнат списък:");
            PrintLinkedList(reversedList);
        }

        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();

            foreach (int item in list)
            {
                reversedList.AddFirst(item); 
            }

            return reversedList;
        }

        static void PrintLinkedList(LinkedList<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " -> ");
            }
           
        }
    }
}
    

