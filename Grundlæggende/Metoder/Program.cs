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
            Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
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

        }
        static void Task4()
        {

        }
        static void Task5()
        {

        }
        static void Task6()
        {

        }
        static void Task7()
        {

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
