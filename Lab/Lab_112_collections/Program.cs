using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections work = new Collections();
        }
    }

    // Recieve three numbers 
    // put these three numbers into an array 
    // output number, double each one store in a stack
    // repeat output numbers, and store into a queue
    // output number square them and store them into a list
    // add numbers in list and return total

    public class Collections
    {
        public int Collection20MniuteLab(int num1, int num2 , int num3)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            List<int> list = new List<int>();

            int[] arr = new int[3] {num1, num2, num3};
            foreach (var item in arr)
            {
                stack.Push(item *2);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                queue.Enqueue(stack.Pop() * 2);
            }
            for (int i = 0; i < 3; i++)
            {
                int num = queue.Dequeue();
                list.Add(num * num);
            }
            return list.Sum();
        }
    }
}
