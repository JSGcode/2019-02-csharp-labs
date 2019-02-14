using System;
using System.Collections.Generic;

namespace Lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //move to dictionary add 1

            //put 10 numbers into an array m/
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            //move items to list and add 1/
            Console.WriteLine("List");
            foreach (int item in arr)
            {
                list.Add(item + 1);
                Console.WriteLine(item);
            }

            //move to stack and add 1
            Console.WriteLine("\nStack");
            foreach (int item in list)
            {
                stack.Push(item + 1);
                Console.WriteLine(item);
            }

            //move to queue add 1 
            Console.WriteLine("\nQueue");
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(stack.Pop() + 1);
            }
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            //move to dictionary add 1 
            Console.WriteLine("\nDictionary");
            for (int i = 0; i < 10; i++)
            {
                dict.Add(i, queue.Dequeue() + 1);
            }
            int total = 0;
            foreach (int item in dict.Keys)
            {
                total += dict[item];
            }
            Console.WriteLine(total);
            Console.ReadLine();


        }
    }
}
