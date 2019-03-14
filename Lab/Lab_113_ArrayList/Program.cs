using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_113_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListClass arrayList = new ArrayListClass();
            //arrayList.ArrayListMethod(10, 20, 30, 40);
        }
    }

    public class ArrayListClass
    {
        public int ArrayListMethod(int a, int b, int c, int d)
        {
            int result = 0;
            int[] intArray = new int[] { a, b, c, d };
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < intArray.Length; i++)
            {
                queue.Enqueue(intArray[i] * 2);
            }

            for (int i = 0; i < 4; i++)
            {
                stack.Push(queue.Dequeue() * 2);
            }

            for (int i = 0; i < 4; i++)
            {
                var temp = stack.Pop();
                dict.Add(i, temp * temp);
            }
            foreach (var item in dict.Values)
            {
                arrayList.Add(item);
                Console.WriteLine(item);
                result += item;
            }
            Console.WriteLine(result);
            return result;
            // Accept 4 integers
            // Put to Array
            // extract ==> double ==> put to queue
            // extract ==> double ==> put to stack
            // extract ==> square ==> put to dictionary
            // put to ARRAYLIST
            // Return sum of arraylist
            // return -1;
        }
    }
}
