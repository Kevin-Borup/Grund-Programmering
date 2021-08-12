using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace OpgaveAfprøvninger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler
            /*
            // Opgave 1: Variabler & Datatyper
            int a = 16;
            int l = 12;
            double b = 5.1;

            int c = a + b;
            double d = a + b;

            Console.WriteLine(a+b);
            */

            /*
            // Opgave 2: Celciusomregner
            Console.Write("Type the Celsius value for conversion: ");
            double c = double.Parse(Console.ReadLine());

            //Reamur
            Console.WriteLine("Reamur: "+c*0.8);

            //Fahrenheit
            Console.WriteLine("Fahrenheit: "+c*1.8+32);
            */

            /*
            // Opgave 3: Valutaomregner
            Console.Write("Insert the DKK value: ");
            float dkk = float.Parse(Console.ReadLine());

            // English Pound
            float gbp = dkk * 0.11f;

            // Euro
            float eur = dkk * 0.13f;

            // Swedish Krona
            float sek = dkk * 1.37f;

            Console.Write($"The value converted to GBP: £{gbp}\n"+
                          $"The value converted to EUR: {eur}€\n"+
                          $"The value converted to SEK: {sek} SEK\n");
            */

            /*
            // Opgave 4: Rumfanget
            Console.WriteLine("Insert the measurements as required for the volume.");
            Console.Write("insert the unit measurement: ");
            string unit = Console.ReadLine();

            Console.Write("\nLength: ");
            float length = float.Parse(Console.ReadLine());
            
            Console.Write("Width: ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Height: ");
            float height = float.Parse(Console.ReadLine());

            float volume = length * width * height;
            Console.WriteLine($"\nThe calculate volume: {volume} cubic {unit}");
            */

            /*
            // Opgave 5: Lidt Matematik
            Console.WriteLine("Write the two whole numbers to be used.");
            Console.Write("1st Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("2nd Number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Addition
            Console.WriteLine($"Addition: {num1+num2}");

            // Int Division
            Console.WriteLine($"Int Division: {num1/num2}");
            // Float Division
            Console.WriteLine($"Float Division: {(float)num1/num2}");

            // Exponential
            Console.WriteLine($"Exponent: {Math.Pow(num1, num2)}");
            */

            // Betingelser
            /*
            // Opgave 1: Terningkast
            Random random = new Random();
            int diceThrow = random.Next(1, 7);

            switch (diceThrow)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You rolled a one!");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You rolled a two!");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You rolled a three!");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You rolled a four!");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You rolled a five!");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You rolled a six!");
                    break;
            }
            */

            /*
            // Opgave 2: Pythagoras
            Console.WriteLine("Write the two numbers for the triangle.");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());

            float c = (float)Math.Sqrt(a*a+b*b);

            if (a > b)
            {
                Console.WriteLine("\na is bigger than b");
            } else if (a < b)
            {
                Console.WriteLine("b is bigger than a");
            } else
            {
                Console.WriteLine("a and b are the same size");
            }

            Console.WriteLine("The value of c: " + c);
            */

            /*
            // Opgave 3: Alder
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Write your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine(name + ", you may use diaper.");
            }
            else if (age < 15)
            {
                Console.WriteLine(name + ", you can't do anything.");
            }
            else if (age < 18)
            {
                Console.WriteLine(name + ", you may drink.");
            }
            else
            {
                Console.WriteLine(name + ", you may vote and drive cars.");
            }
            */

            /*
            // Opgave 4: Gæt et tal
            Random random = new Random();
            int num = random.Next(1, 11);

            Console.WriteLine("Guess a number between 1 and 10.");
            int guess = int.Parse(Console.ReadLine());

            int guessCounter = 1;

            if (guess == num)
            {
                Console.WriteLine("You guessed it on the first try!");
            }
            else
            {
                bool notGuessed = true;
                if (num > guess)
                {
                    Console.WriteLine("The number is higher!");
                }
                else
                {
                    Console.WriteLine("The number is lower!");
                }

                do
                {
                    guessCounter++;
                    Console.WriteLine("Try Again!");
                    guess = int.Parse(Console.ReadLine());
                    if (num == guess)
                    {
                        notGuessed = false;
                    }
                    else if (num > guess)
                    {
                        Console.WriteLine("The number is higher!");
                    }
                    else
                    {
                        Console.WriteLine("The number is lower!");
                    }
                    
                } while (notGuessed);
                Console.WriteLine("You guessed it! It took " + guessCounter + " tries.");
                if (guessCounter <= 3)
                {
                    Console.WriteLine("Wow, that was few guesses!");
                }
                else if (guessCounter <= 6)
                {
                    Console.WriteLine("That was okay :)");
                }
                else
                {
                    Console.WriteLine("Umm, not that great.");
                }
            }
            */

            /*
            // Opgave 5: Porto
            int price = 0;
            Console.WriteLine("Please describe the sending object.");
            
            Console.Write("Weight (g): ");
            float weight = float.Parse(Console.ReadLine());

            int select = 2;
            if (weight > 35000)
            {
                Console.WriteLine("The package is too heavy for transport.");
                Environment.Exit(0);
            }
            else if (weight > 2000)
            {
                Console.WriteLine("The weight classifies it as a package.");
            }
            else
            {
                Console.WriteLine("What would you like to send? Letter (1) or Package (2)");
                select = int.Parse(Console.ReadLine());
            }


            Console.Write("\nCountry Destination: ");
            string dest = Console.ReadLine().ToLower();
            bool national = false;
            if (dest.Contains("nmark"))
            {
                national = true;
            }



            Console.Write("\nLength: ");
            float length = float.Parse(Console.ReadLine());

            Console.Write("Width: ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Height: ");
            float height = float.Parse(Console.ReadLine());

            if (length > 150 || (length+height*width > 300))
            {
                Console.WriteLine("\nThe item is too big to be eligible for transport.");
                Environment.Exit(0);
            }
            else if (length > 60 || (length+width+height > 90))
            {
                select = 2;
            }

            Dictionary<float, int> letterPriceDK = new Dictionary<float, int>();
            Dictionary<float, int> packagePriceDK = new Dictionary<float, int>();
            Dictionary<float, int> letterPriceOut = new Dictionary<float, int>();
            Dictionary<float, int> packagePriceOut = new Dictionary<float, int>();

            // Within Denmark
            letterPriceDK.Add(50, 11);
            letterPriceDK.Add(100, 22);
            letterPriceDK.Add(250, 44);
            letterPriceDK.Add(2000, 66);

            packagePriceDK.Add(2000, 50);
            packagePriceDK.Add(5000, 60);
            packagePriceDK.Add(10000, 80);
            packagePriceDK.Add(20000, 100);
            packagePriceDK.Add(35000, 160);

            // Another country
            letterPriceOut.Add(100, 33);
            letterPriceOut.Add(250, 66);
            letterPriceOut.Add(2000, 99);

            packagePriceOut.Add(1000, 190);
            packagePriceOut.Add(5000, 275);
            packagePriceOut.Add(10000, 445);
            packagePriceOut.Add(15000, 530);
            packagePriceOut.Add(20000, 685);

            if (national)
            {
                if (select == 1)
                {
                    foreach (var weighter in letterPriceDK)
                    {
                        if (weight < weighter.Key)
                        {
                            price = weighter.Value;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var weighter in packagePriceDK)
                    {
                        if (weight < weighter.Key)
                        {
                            price = weighter.Value;
                            break;
                        }
                    }
                }
            }
            else
            {
                if (select == 1)
                {
                    foreach (var weighter in letterPriceOut)
                    {
                        if (weight < weighter.Key)
                        {
                            price = weighter.Value;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var weighter in packagePriceOut)
                    {
                        if (weight < weighter.Key)
                        {
                            price = weighter.Value;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("\nThe price of sending it will be: kr. " + price + ",-");
            */

            /*
            // Opgave 6: Morsekode
            Console.WriteLine("Please write what needs to be converted.");
            string text = Console.ReadLine();

            Dictionary<char, string> morseDic = new Dictionary<char, string>();

            morseDic.Add('A', ".-");    
            morseDic.Add('B', "-...");    
            morseDic.Add('C', "-.-.");    
            morseDic.Add('D', "-..");    
            morseDic.Add('E', ".");    
            morseDic.Add('F', "..-");    
            morseDic.Add('G', "--.");    
            morseDic.Add('H', "....");    
            morseDic.Add('I', "..");    
            morseDic.Add('J', ".---");    
            morseDic.Add('K', "-.-");    
            morseDic.Add('L', ".-..");    
            morseDic.Add('M', "--");    
            morseDic.Add('N', "-.");    
            morseDic.Add('O', "---");    
            morseDic.Add('P', ".--.");    
            morseDic.Add('Q', "--.-");    
            morseDic.Add('R', ".-.");    
            morseDic.Add('S', "...");    
            morseDic.Add('T', "-");    
            morseDic.Add('U', "..-");    
            morseDic.Add('V', "...-");    
            morseDic.Add('W', ".--");    
            morseDic.Add('X', "-..-");    
            morseDic.Add('Y', "-.--");    
            morseDic.Add('Z', "--..");    
            morseDic.Add('Æ', ".-.-");    
            morseDic.Add('Ø', "---.");    
            morseDic.Add('Å', ".--.-");   
            
            string morseCode = "";
            foreach (var letter in text.ToUpper())
            {
                if (letter == ' ')
                {
                    morseCode += " ";
                }
                else
                {
                    morseCode += morseDic[letter];
                }
            }

            Console.WriteLine(morseCode);
            */

            // Løkker
            /*
            // Opgave 1: Igang med løkker
            for (int i = 0; i < 100; i++)
            {
                if (i<50)
                {
                    Console.WriteLine(i);
                }
            }

            int j = 0;
            while (j < 100)
            {
                if (j < 50)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //Opgave 2: Primtal
            Console.WriteLine("Show every prime number up until: ");
            int number = 100;
            //number = int.Parse(Console.ReadLine());

            Console.Write("0 1 ");

            for (int i = 2; i <= number; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        Console.ResetColor();
                        break;
                    }
                }
                Console.Write(i + " ");
            }
            */

            // Arrays
            /*
            // Opgave 1: Array
            int[] numbers = new int[9];

            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers[i - 1] = i;
            }

            foreach  (int value in numbers)
            {
                Console.WriteLine($"The value on index {Array.IndexOf(numbers, value)}: {value}");
            }

            Console.WriteLine(numbers[5]);

            numbers[5] = numbers[5] * 2;

            Console.WriteLine(numbers[5]);
            */

            /*
            // Opgave 2: Arrays og bubblesort
            int[] ranNumbers = new int[100];

            Random random = new Random();

            for (int i = 0; i < ranNumbers.Length; i++)
            {
                ranNumbers[i] = random.Next(1, 100);
            }

            foreach (int number in ranNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            for (int i = 1; i < ranNumbers.Length; i++)
            {
                for (int j = 0; j < ranNumbers.Length; j++)
                {
                    if (ranNumbers[j] > ranNumbers[i])
                    {
                        int tempNum = ranNumbers[i];
                        ranNumbers[i] = ranNumbers[j];
                        ranNumbers[j] = tempNum;
                    }
                }
            }
            foreach (int num in ranNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");



            Array.Reverse(ranNumbers);
            foreach (int number in ranNumbers)
            {
                Console.Write(number + " ");
            }
            */

            /*
            // Opgave 3: Array og Matematik
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i%2==0)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine("List length: " + numbers.Count);


            int currentIndex = 0;
            while (true)
            {
                if (numbers[currentIndex]%3==0)
                {
                    numbers.RemoveAt(currentIndex);
                }
                else
                {
                    currentIndex++;
                }

                if (currentIndex >= numbers.Count)
                {
                    break;
                }
            }

            Console.WriteLine("List length: " + numbers.Count);

            numbers.Insert(3, 17);

            List<int> revNumbers = new List<int>();
            revNumbers = numbers.ToList();
            revNumbers.Reverse();

            for (int i = 0; i < revNumbers.Count; i++)
            {
                Console.Write(numbers[i]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(revNumbers[i]);
                Console.ResetColor();
            }
            */

            /*
            // Opgave 4: Lotto
            int[] lotteryNum = new int[7];
            int[] userNum = new int[lotteryNum.Length];

            Random numGen = new Random();

            for (int i = 0; i < lotteryNum.Length; i++)
            {
                lotteryNum[i] = numGen.Next(1, 21);
            }

            Console.WriteLine("Welcome to the Lotter!");
            Console.WriteLine("Do you want to choose(1) or generate(2) your own numbers?");
            int lotterySel = int.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);


            if (lotterySel == 1)
            {
                string input = "";
                Console.WriteLine("Please write your lottery numbers:");
                for (int i = 0; i < userNum.Length; i++)
                {
                    Console.Write("|");
                    userNum[i] = int.Parse(Console.ReadLine());
                    input += $"|{userNum[i]}| ";
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(input);
                }
            }
            else
            {
                Console.WriteLine("\nThese are your lottery numbers:");
                for (int i = 0; i < userNum.Length; i++)
                {
                    userNum[i] = numGen.Next(1, 21);
                    Console.Write($"|{userNum[i]}| ");
                }

            }

            int lotteryCounter = 0;

            for (int i = 0; i < lotteryNum.Length; i++)
            {
                if (lotteryNum[i] == userNum[i])
                {
                    lotteryCounter++;
                }
            }

            Console.WriteLine(Environment.NewLine);

            for (int i = 0; i < lotteryNum.Length; i++)
            {

                Console.Write($"|{lotteryNum[i]}| ");
            }

            Console.WriteLine(Environment.NewLine);

            switch (lotteryCounter)
            {
                case 3:
                    Console.WriteLine("You had 3 correct values - Reward: 1.2x ticket price");
                    break;
                case 4:
                    Console.WriteLine("You had 4 correct values - Reward: 1.3x ticket price");
                    break;
                case 5:
                    Console.WriteLine("You had 5 correct values - Reward: 3x ticket price");
                    break;
                case 6:
                    Console.WriteLine("You had 6 correct values - Reward: 50x ticket price");
                    break;
                case 7:
                    Console.WriteLine("You had 7 correct values - Reward: 1000x ticket price");
                    break;
                default:
                    Console.WriteLine("Your ticket didn't have enough correct values for a price.");
                    break;
            }
            //Process.Start(Assembly.GetExecutingAssembly().Location);
            //Environment.Exit(0);
            */


            //Opgave 5: Mozart

            int[][] passage = new int[32][];
            Random shuffler = new Random();

            List<int> ranMinuet = Enumerable.Range(1, 176).ToList();
            List<int> ranTrio = Enumerable.Range(1, 96).ToList();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            for (int i = 0; i < passage.Length; i++)
            {
                if (i < 16)
                {
                    passage[i] = new int[11];
                }
                else
                {
                    passage[i] = new int[6];
                }

            }

            for (int i = 0; i < passage.Length; i++)
            {
                int ranIndex;
                for (int j = 0; j < passage[i].Length; j++)
                {
                    if (i < 16)
                    {
                        ranIndex = shuffler.Next(0, ranMinuet.Count());
                        passage[i][j] = ranMinuet[ranIndex];
                        ranMinuet.RemoveAt(ranIndex);
                    }
                    else
                    {
                        ranIndex = shuffler.Next(0, ranTrio.Count());
                        passage[i][j] = ranTrio[ranIndex];
                        ranTrio.RemoveAt(ranIndex);
                    }
                }
                passage[i] = passage[i].OrderBy(x => shuffler.Next()).ToArray();
            }

            string[] mozartPieces = new string[32];
            int mozartIndex = 0;
            for (int i = 0; i < passage.Length; i++)
            {
                if (i < 16)
                {
                    mozartPieces[mozartIndex] = @"C:\ZBC Data-Kommunikation\Mozart\Wave\M" + passage[i][shuffler.Next(0, 11)] + ".wav";
                    mozartIndex++;

                }
                else
                {
                    mozartPieces[mozartIndex] = @"C:\ZBC Data-Kommunikation\Mozart\Wave\T" + passage[i][shuffler.Next(0, 6)] + ".wav";
                    mozartIndex++;

                }

            }

            for (int i = 0; i < mozartPieces.Length; i++)
            {
                player.SoundLocation = mozartPieces[i];
                player.Load();
                player.PlaySync();
            }

            /*
            // Every audio randomized order Menuett -> Trioet
            string[] mozartPieces = new string[ranMinuet.Count() + ranTrio.Count()];
            int mozartIndex = 0;
            for (int i = 0; i < passage.Length; i++)
            {
                if (i < 16)
                {
                    for (int j = 0; j < passage[i].Length; j++)
                    {
                        mozartPieces[mozartIndex] = @"C:\ZBC Data-Kommunikation\Mozart\Wave\M" + passage[i][j] + ".wav";
                        mozartIndex++;
                    }
                }
                else
                {
                    for (int j = 0; j < passage[i].Length; j++)
                    {
                        mozartPieces[mozartIndex] = @"C:\ZBC Data-Kommunikation\Mozart\Wave\T" + passage[i][j] + ".wav";
                        mozartIndex++;
                    }
                }

            }

            for (int i = 0; i < mozartPieces.Length; i++)
            {
                player.SoundLocation = mozartPieces[i];
                player.Load();
                player.PlaySync();
            }

            */



            /*
            foreach (string passageLoc in mozartPieces)
            {
                player.SoundLocation = passageLoc;
                player.Load();
                player.PlaySync();
            }
            */

            // test
            /*
            for (int i = 0; i < passage.Length; i++)
            {
                if (i < 16)
                {
                    Console.Write("\n\n|");
                }
                else
                {

                    Console.WriteLine("|");
                }
                for (int j = 0; j < passage[i].Length; j++)
                {
                    
                    Console.Write(" " + passage[i][j] + " ");
                }
                Console.WriteLine("|");
            }*/


        }
    }
}

