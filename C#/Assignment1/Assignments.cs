using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public struct Book
    {
        int bookId;
        string title;
        double price;
        bookTypeEnum bookType;

        enum bookTypeEnum
        {
            Magazine, Novel, ReferenceBook, Miscellaneous
        };

        public Book(int bookId, string title, double price, string bookType)
        {
            this.bookId = bookId;
            this.title = title;
            this.price = price;
            this.bookType = (bookTypeEnum) Enum.Parse(typeof(bookTypeEnum), bookType);
        }

        public override string ToString()
        {
            string type = Enum.GetName(typeof(bookTypeEnum), this.bookType);
            return($"bookId: {this.bookId}, title: {this.title}, price: {this.price}, bookType: {type}");
        }

    }


    internal class Assignments
    {
        static void Main(string[] args)
        {
            //Qn1. Calculator To add, subtract, multiply and divide...
            Console.WriteLine("Calculator:");
            Calculator calc = new Calculator();
            Console.Write("Write 1st Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write 2nd Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input The Operator ( +, -, *, / ) : ");
            string op = Console.ReadLine();
            double ans = calc.Calculate(num1, num2, op);
            Console.WriteLine("The Calculated Value is {0}", ans);

            //Qn2. To Calculate maximum of averages...
            Console.WriteLine("\nMaximum of Averages:");
            Maximum maxi = new Maximum();
            double[] averages = { 84, 54, 65, 77, 34 };
            ans = maxi.GetMaximum(averages);
            Console.WriteLine(ans);

            //Qn3. To find sum of array elements
            Console.WriteLine("\nSum of Numbers in An Array:");
            SumOfArrayElements soae = new SumOfArrayElements();
            double[] numbers = { 45, 65, 75, 34, 34, 66, 54 };
            ans = soae.GetSum(numbers);
            Console.WriteLine(ans);

            //Qn4. Swap To numbers
            Console.WriteLine("\nSwap Two Numbers:");
            SwapNumbers sn = new SwapNumbers();
            Console.Write("Write 1st Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write 2nd Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            double[] result = sn.Swap(num1, num2);
            Console.WriteLine("After Swapping num1: {0} and num2: {1}", result[0], result[1]);

            //Qn5. To find Area and Circumference of Circle
            Console.WriteLine("\nArea and Circumference of Circle:");
            Circle crl = new Circle();
            Console.Write("Input the Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            result = crl.AreaAndCircumference(rad);
            Console.WriteLine("CircumFerence of circle is: {0} and Area is: {1}", result[0], result[1]);

            //Qn6. To Store and Print details of Books
            Console.WriteLine("\nStore and Print details of Books:");
            Console.Write("Enter bookId: ");
            int bookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose Catagory: \n1:Magazine \n2:Novel \n3:ReferenceBook \n4:Miscellaneous");
            int opt = Convert.ToInt32(Console.ReadLine());
            string bookType="";
            switch (opt)
            {
                case 1:
                    bookType = "Magazine";
                    break;
                case 2:
                    bookType = "Novel";
                    break;
                case 3:
                    bookType = "ReferenceBook";
                    break;
                case 4:
                    bookType = "Miscellaneous";
                    break;
            }
            Book book = new Book(bookId, title, price, bookType);
            Console.Write(book.ToString());
            Console.ReadLine();
        }
    }
}
