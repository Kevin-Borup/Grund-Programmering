using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4to6();
            Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
        }

        static void Task1()
        {
            Console.WriteLine("Write the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers added is: " + Addition(num1, num2));
            Console.WriteLine("The int division result is: " + Division(num1, num2, out float flDiv) + " While the float division is: " + flDiv);
            Console.WriteLine("The first number can divide the second number: " + Counter(num1, num2));
            Console.WriteLine($"The result of {num1} to the power of {num2} is: " + Expontent(num1, num2));


            int Addition(int a, int b)
            {
                return a + b;
            }
            int Division(int a, int b, out float div)
            {
                div = (float)a / b;
                return a/b;
            }
            int Counter(int a, int b)
            {
                return b/a;
            }

            int Expontent(int a, int b)
            {
                return Convert.ToInt32(Math.Pow(a, b));
            }
        }
        static void Task2()
        {
            Console.WriteLine("Write the two numbers for the triangle.");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("\nWhen comparing a and b, then " + Comparison(a, b));
            Console.WriteLine("The value of c: " + Pythagoras(a, b));


            float Pythagoras(float num1, float num2)
            {
                return (float)Math.Sqrt(num1 * num1 + num2 * num2);
            }

            string Comparison(float num1, float num2)
            {
                if (num1 > num2)
                {
                    return "a is bigger than b.";
                }
                else if (num1 < num2)
                {
                    return "b is bigger than a.";
                }
                else
                {
                    return "a and b are the same size.";
                }
            }
        }
        static void Task3()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(Response(name, age));

            string Response(string alias, int years)
            {
                if (years < 3)
                {
                    return $"{alias}, you may wear diaper.";
                }
                else if (years < 15)
                {
                    return $"{alias}, you may not do anything.";
                }
                else if (years < 15)
                {
                    return $"{alias}, you may drink.";
                }
                else
                {
                    return $"{alias}, you may vote and drive cars.";
                }
            }
        
        }
        static void Task4to6()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Write a number: ");
            int input = int.Parse(Console.ReadLine());
            UpCounter();
            Console.Write(Environment.NewLine);
            DownCounter();
            Console.Write(Environment.NewLine);
            Counter(input);
            Console.Write(Environment.NewLine);


            void UpCounter()
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.Write(i + " ");
                }
            }

            void DownCounter()
            {
                for (int i = 10; i < 0; i--)
                {
                    Console.Write(i + " ");
                }
            }

            void Counter(int num)
            {
                for (int i = 0; i < 33; i++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.Write(Environment.NewLine);
                for (int i = 0; i < 17; i++)
                {
                    num--;
                    Console.Write(num + " ");
                }
            }

        }
        static void Task7()
        {
            Console.WriteLine("Welcome!");

            int[] line = NumArrayMaker(9);
            Presenter(line);
            NumIndexDoubler(ref line, 5);
            Presenter(line);

            int[] NumArrayMaker(int length)
            {
                int[] tempArray = new int[length];
                for (int i = 0; i < length; i++)
                {
                    tempArray[i] = i + 1;
                }
                return tempArray;
            }

            void NumIndexDoubler(ref int[] numArray, int index)
            {
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (i == index-1)
                    {
                        numArray[i] = numArray[i] * 2;
                    }
                }
            }

            void Presenter(int[] numArray)
            {
                foreach (int num in numArray)
                {
                    Console.Write(num + "");
                }
                Console.WriteLine(Environment.NewLine);

            }
        }
        static void Task8()
        {

        }
        static void Task9()
        {

        }
        static void Task10()
        {

        }
        static void Task11()
        {

        }
    }
}
