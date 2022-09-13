using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_CollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n 1. Array Operation\n 2. Stack\n 3. Player\n 0. Exit\n Enter Operation: ");
                int outerOpt = Convert.ToInt32(Console.ReadLine());
                if (outerOpt == 0) break;
                if (outerOpt == 1)
                {
                    int[] intArray = new int[] { 1, 5, 3, 6, 4, 2, 8, 7 };
                    string[] stringArray = new string[] { "India", "Pakistan", "Srilanka", "Bhutan", "Nepal", "Bangladesh", "China" };
                    Console.WriteLine("\n Original String Array:");
                    Show(stringArray);
                    Console.WriteLine(" Original Integer Array:");
                    Show(intArray);

                    int[] copyIntArray = new int[intArray.Length];
                    Array.Copy(intArray, copyIntArray, intArray.Length);
                    string[] copyStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, copyStringArray, stringArray.Length);
                    Console.WriteLine("\n Copied String Array:");
                    Show(copyStringArray);
                    Console.WriteLine(" Copied Integer Array:");
                    Show(copyIntArray);

                    int[] sortIntArray = new int[intArray.Length];
                    Array.Copy(intArray, sortIntArray, intArray.Length);
                    Array.Sort(sortIntArray);
                    string[] sortStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, sortStringArray, stringArray.Length);
                    Array.Sort(sortStringArray);
                    Console.WriteLine("\n Sorted String Array:");
                    Show(sortStringArray);
                    Console.WriteLine(" Sorted Integer Array:");
                    Show(sortIntArray);

                    int[] clearIntArray = new int[intArray.Length];
                    Array.Copy(intArray, clearIntArray, intArray.Length);
                    Array.Clear(clearIntArray, 0, clearIntArray.Length);
                    string[] clearStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, clearStringArray, stringArray.Length);
                    Array.Clear(clearStringArray, 0, clearStringArray.Length);
                    Console.WriteLine("\n String Array is Cleared");
                    Console.WriteLine(" Integer Array is Cleared");

                    int[] revIntArray = new int[intArray.Length];
                    Array.Copy(intArray, revIntArray, intArray.Length);
                    Array.Reverse(revIntArray);
                    string[] revStringArray = new string[stringArray.Length];
                    Array.Copy(stringArray, revStringArray, stringArray.Length);
                    Array.Reverse(revStringArray);
                    Console.WriteLine("\n Reversed String Array:");
                    Show(revStringArray);
                    Console.WriteLine(" Reversed Integer Array:");
                    Show(revIntArray);
                }
                if (outerOpt == 2)
                {
                    int n;
                    Console.Write("\nEnter The Size of Stack: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    MyStack<dynamic> stack = new MyStack<dynamic>(n);
                    while (true)
                    {
                        Console.Write("\n 1. Push\n 2. Pop\n 3. Peek\n 4. Clone\n 5. Show\n 0. Back\n Enter Operation: ");
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
                            catch (StackException e) { Console.WriteLine(e.Message); }
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
                                MyStack<dynamic> CopiedStack = stack.CloneStack();
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
                if (outerOpt == 3)
                {
                    Team India = new Team();
                    India.Add(new Player("Rahul", 1665));
                    India.Add(new Player("Rohit", 9376));
                    India.Add(new Player("Virat", 12344));
                    India.Add(new Player("Surya", 340));
                    India.Add(new Player("Pant", 840));
                    India.Add(new Player("Jadeja", 2447));
                    India.Add(new Player("Pandya", 1386));
                    India.Add(new Player("Bhuvi", 552));
                    India.Add(new Player("Bumrah", 47));
                    India.Add(new Player("Shami", 184));
                    India.Add(new Player("Chahal", 69));

                    Console.Write("\n\t Players of India Team Are:");
                    Console.WriteLine("\n\t Name\t\t Run");
                    foreach (Player p in India)
                    {
                        Console.Write(p.Show());
                    }
                    Console.WriteLine();
                }
            }  
        }

        static void Show<T>(T[] Array)
        {
            Console.Write(" [ ");
            foreach(T t in Array)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("]");
        }
    }
}
