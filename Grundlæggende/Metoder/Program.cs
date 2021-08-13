using System;
using System.Collections.Generic;
using System.Linq;

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
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            Task11();
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
                return a / b;
            }
            int Counter(int a, int b)
            {
                return b / a;
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
                    if (i == index - 1)
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
            Console.WriteLine("Welcome!");
            List<int> listB = Enumerable.Range(1, 20).ToList();
            Console.WriteLine("listB Size: " + listB.Count);
            Console.WriteLine("listB New Size: " + Remove3Size(ref listB));
            listB = ValueListAdder(listB, 3, 17);
            List<int> listC = ReverseLister(listB);

            Console.Write(Environment.NewLine);

            foreach (int num in listB)
            {
                Console.Write(num + " ");
            }
            Console.Write(Environment.NewLine);

            foreach (int num in listC)
            {
                Console.Write(num + " ");
            }

            int Remove3Size(ref List<int> aList)
            {
                for (int i = 0; i < aList.Count; i++)
                {
                    if (aList[i] % 3 == 0)
                    {
                        aList.RemoveAt(i);
                    }
                }

                return aList.Count;
            }

            List<int> ValueListAdder(List<int> aList, int x, int value)
            {
                aList[x - 1] = value;
                return aList;
            }

            List<int> ReverseLister(List<int> aList)
            {
                List<int> bList = new List<int>();

                for (int i = aList.Count - 1; i >= 0; i--)
                {
                    bList.Add(aList[i]);
                }

                return bList;
            }

        }
        static void Task9()
        {
            string mainDisplay = "Welcome to the Lotter!" +
                                 "\nDo you want to choose(1) or generate(2) your own numbers? => ";

            Console.Write(mainDisplay);

            int[] lotteryNum = RandomizedSeq(7, 1, 20);
            int[] lotUserNum = LotSelection();
            Console.Write(Environment.NewLine);
            Console.Write("Lot Ticket: ");
            for (int i = 0; i < lotteryNum.Length; i++)
            {
                Console.Write($"|{lotteryNum[i]}| ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Reward(LotteryRewarder(lotUserNum, lotteryNum)));


            int[] LotSelection()
            {
                int[] userNum = new int[lotteryNum.Length];
                List<int> numSeq = Enumerable.Range(1, 20).ToList();
                int lotterySel = int.Parse(Console.ReadLine());
                int num;
                bool isCorrect;
                int cursorX = 0;
                int cursorY = 0;
                if (lotterySel == 1)
                {
                    mainDisplay += "\nPlease write your lottery numbers:\nUser Ticket: ";
                    Console.Write("|");
                    for (int i = 0; i < userNum.Length; i++)
                    {
                        isCorrect = false;
                        while (!isCorrect)
                        {
                            Reprinter(mainDisplay);
                            Console.Write("|");
                            cursorX = Console.CursorLeft;
                            cursorY = Console.CursorTop;

                            num = int.Parse(Console.ReadLine());
                            if (1 <= num && num <= 20)
                            {
                                if (!userNum.Contains(num))
                                {
                                    userNum[i] = num;
                                    isCorrect = true;
                                    cursorX += num.ToString().Length;
                                }
                            }
                            Console.SetCursorPosition(cursorX, cursorY);
                        }
                        Console.Write("|");
                        mainDisplay += $"|{userNum[i]}| ";
                        Console.SetCursorPosition(0, cursorY);
                    }
                    return userNum;
                }
                else
                {
                    Random numGen = new Random();
                    Console.Write("\nThese are your lottery numbers:\nUser Ticket: ");
                    mainDisplay += "\nThese are your lottery numbers:\nUser Ticket: ";
                    for (int i = 0; i < userNum.Length; i++)
                    {
                        int index = numGen.Next(1, numSeq.Count);
                        userNum[i] = numSeq[index];
                        numSeq.RemoveAt(index);
                        Console.Write($"|{userNum[i]}| ");
                    }
                    return userNum;
                }
            }

            int[] RandomizedSeq(int amount, int min, int max)
            {
                int[] anArray = new int[amount];
                Random numGen = new Random();
                List<int> numSeq = Enumerable.Range(min, max).ToList();

                for (int i = 0; i < anArray.Length; i++)
                {
                    int index = numGen.Next(min, numSeq.Count);
                    anArray[i] = numSeq[i];
                    numSeq.RemoveAt(i);
                }

                return anArray;
            }

            int LotteryRewarder(int[] user, int[] lot)
            {
                int lotteryCounter = 0;

                for (int i = 0; i < lotteryNum.Length; i++)
                {
                    if (lot.Contains(user[i]))
                    {
                        lotteryCounter++;
                    }
                }

                return lotteryCounter;
            }

            string Reward(int count)
            {
                string answer = $"You had {count} correct values - Reward: ";
                switch (count)
                {
                    case 3:
                        answer += "1.2x ticket price";
                        break;
                    case 4:
                        answer += "1.3x ticket price";
                        break;
                    case 5:
                        answer += "3x ticket price";
                        break;
                    case 6:
                        answer += "50x ticket price";
                        break;
                    case 7:
                        answer += "1000x ticket price";
                        break;
                    default:
                        return "Your ticket didn't have enough correct values for a price.";
                }
                return answer;
            }

            void Reprinter(string mainText)
            {
                Console.Clear();
                Console.Write(mainText);
            }
        }
        static void Task10()
        {
            string mainDisplay = "Choose a guess range - From: ";
            Console.Write(mainDisplay);
            int min = int.Parse(Console.ReadLine());
            mainDisplay += min + " - To: ";
            Console.Clear();
            Console.Write(mainDisplay);
            int max = int.Parse(Console.ReadLine());
            mainDisplay += max;
            Console.WriteLine($"Guess a number between {min} and {max}.");

            Console.WriteLine(Answer(Guesser(NumGenerator())));

            int NumGenerator()
            {
                Random random = new Random();
                return random.Next(min, max + 1);
            }

            int Guesser(int num)
            {
                int guess = int.Parse(Console.ReadLine());
                int guessCounter = 1;
                bool correctGuess = false;

                while (!correctGuess)
                {
                    if (num == guess)
                    {
                        correctGuess = false;
                        break;
                    }
                    Feedback(guess, num);
                    guess = int.Parse(Console.ReadLine());
                    guessCounter++;
                }
                return guessCounter;
            }

            void Feedback(int guess, int num)
            {
                string feedback;
                if (num > guess)
                {
                    feedback = "The number is higher!";
                }
                else
                {
                    feedback ="The number is lower!";
                }
                Console.WriteLine(feedback + " Try Again!");
            }

            string Answer(int result)
            {
                string answer = $"You guessed it! It took {result} tries.\n";
                if (result == 1)
                {
                    return "You guessed it on the first try!";
                }
                else if (result <= max / 10)
                {
                    return "Wow, that was quick!";
                }
                else if (result <= max / 4)
                {
                    return "That was okay :)";
                }
                else
                {
                    answer += "Umm, not that great.";
                }
                return answer;
            }
        }
        static void Task11()
        {
            //TEST START
            int tal1 = 10, tal2 = 3;
            List<int> numbers = Enumerable.Range(1, 20).ToList();

            Console.WriteLine(Addition(tal1, tal2));
            Console.WriteLine(Division(tal1, tal2));
            Console.WriteLine(WholeDivision(tal1, tal2));
            Console.WriteLine(BiggestElement(numbers));
            if (Containment(numbers, 17))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (Containment(numbers, 26))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.WriteLine(AverageOfSeq(numbers));
            Console.WriteLine(numbers.Average());
            if (IsListSorted(numbers))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            numbers[13] = 34;
            if (IsListSorted(numbers))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            // TEST END



            int Addition(int a, int b)
            {
                return a + b;
            }

            float Division(int a, int b)
            {
                return (float)a / b;
            }

            int WholeDivision(int a, int b)
            {
                return a / b;
            }

            int BiggestElement(List<int> aList)
            {
                int x = -100000000;

                foreach (int num in aList)
                {
                    if (num > 0)
                    {
                        x = num;
                    }
                }

                return x;
            }

            bool Containment(List<int> aList, int x)
            {
                bool inside = false;

                foreach (int num in aList)
                {
                    if (num == x)
                    {
                        inside = true;
                        break;
                    }
                }

                return inside;
            }

            float AverageOfSeq(List<int> aList)
            {
                float avg = 0;

                foreach (int num in aList)
                {
                    avg += num;
                }

                return avg / aList.Count;
            }

            bool IsListSorted(List<int> aList)
            {
                bool sorted = true;

                for (int i = 1; i < aList.Count; i++)
                {
                    if (aList[i-1] > aList[i])
                    {
                        sorted = false;
                    }
                }

                return sorted;
            }
        }
    }
}

