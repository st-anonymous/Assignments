using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter The Size of Stack: ");
            n = Convert.ToInt32(Console.ReadLine());
            MyStack stack = new MyStack(n);
            while (true)
            {
                Console.Write("\n 1. Push\n 2. Pop\n 3. Peek\n 4. Clone\n 5. Show\n 0. Exit\n Enter Operation: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 0) break;
                if (opt == 1)
                {
                    Console.Write(" Enter Number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        stack.Push(num);
                    }
                    catch (StackException e) { Console.WriteLine(e.Message); }
                }
                if (opt == 2)
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch(StackException e) { Console.WriteLine(e.Message); }
                }
                if (opt == 3)
                {
                    try
                    {
                        Console.WriteLine("\n\tThe Number at Top of Stack is: " + stack.Peek());
                    }
                    catch (StackException e) { Console.WriteLine(e.Message); }
                }
                if (opt == 4)
                {
                    try
                    {
                        MyStack CopiedStack =  stack.CloneStack();
                        Console.WriteLine("\n\tStack is Cloned. The Elements in ClonedStack Are:");
                        CopiedStack.Show();
                    }
                    catch (StackException e) { Console.WriteLine(e.Message); }
                    
                }
                if (opt == 5)
                {
                    try
                    {
                        stack.Show();
                    }
                    catch (StackException e) { Console.WriteLine(e.Message); }
                }
            }
        }
    }
}
