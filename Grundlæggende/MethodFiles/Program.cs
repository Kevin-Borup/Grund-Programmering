using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("{1} for all the tasks before 7, or {2} for task 7: ");
            int select = int.Parse(Console.ReadLine());

            if (select == 2)
            {
                // Opgave 7 - Fil og mapper manipulation
                // Borderline ignore this, it's merely so the assignment is seperated. 
                // Figured its okay as I understand it.
                Opgave7 showcase = new Opgave7();
                showcase.SynthMain();
            }
            else
            {
                // Opgave 1 - Skriv til fil
                File.WriteAllText(@".\StarWars.txt", "He shot first");

                // Opgave 2 - læs en tekstfil
                string content = File.ReadAllText(@".\StarWars.txt");
                Console.WriteLine(content);

                // Opgave 3 - slet en fil
                File.Delete(@".\hello.txt");

                // Opgave 4 - Opret en mappe
                Directory.CreateDirectory(@".\Droids");


                // Opgave 5 - Slet en mappe
                File.WriteAllText(@".\Droids\R2D2.txt", "beep bop");

                Directory.Delete(@".\Droids", true);

                // Opgave 6 - Enumerating filer i mappe
                Directory.CreateDirectory(@".\Droids\Astromech");
                Directory.CreateDirectory(@".\Droids\Protocol");
                File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
                File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");

                string[] files = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);

                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                // Streams
                // Opgave 5 - læs fra fil
                File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi\n");

                FileStream file = new FileStream(@".\Movies.Txt", FileMode.Open);
                StreamReader reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                reader.Close();

                // Opgave 6 - Skriv til fil
                // Er usikker på opgaven, Skriv til den lokale fil Actors.txt (Altså lav en ny der hedder det vha. FileMode.Create)
                // Men der er også beskrevet at man skal overskrive Movies.txt? 
                // Laver begge.
                List<string> actors = new List<string>()
                {
                    "Mark Hamill",
                    "Harrison Ford",
                    "Carrie Fisher"
                };

                Console.Write("\nChoose Version {1} or Version {2}: ");

                if (int.Parse(Console.ReadLine()) == 1)
                {
                    Console.Write(Environment.NewLine);
                    // Version 1 - Seperat Actors.txt 
                    FileStream fileV1 = new FileStream(@".\Actors.txt", FileMode.Create);
                    StreamWriter writerV1 = new StreamWriter(fileV1);

                    foreach (string actor in actors)
                    {
                        writerV1.WriteLine(actor);
                    }
                    writerV1.Close();
                }
                else
                {
                    Console.Write(Environment.NewLine);
                    // Version 2 - Overwrite Movies.txt, so we write actors into Actors.txt
                    FileInfo mainFile = new FileInfo(@".\Movies.txt");
                    mainFile.MoveTo(@".\Actors.txt");
                    File.WriteAllText(@".\Actors.txt", String.Empty);

                    FileStream fileV2 = new FileStream(@".\Actors.txt", FileMode.Open);
                    StreamWriter writerV2 = new StreamWriter(fileV2);

                    foreach (string actor in actors)
                    {
                        writerV2.WriteLine(actor);
                    }
                    writerV2.Close();
                }
            }
        }
    }

    class Opgave7
    {
        public void SynthMain()
        {
            MainMenu();
            Brancher();
        }

        void Brancher()
        {
            do
            {
                switch (InputReader<int>())
                {
                    case 1:
                        AddFile();
                        break;
                    case 2:
                        DeleteFile();
                        break;
                    case 3:
                        DisplayFiles();
                        break;
                    case 4:
                        AddFolder();
                        break;
                    case 5:
                        SearchFileInFolder();
                        break;
                    case 6:
                        Exit();
                        break;
                }
                Console.WriteLine(Environment.NewLine);
                MainMenu();
            } while (true);
            
        }

        void AddFile()
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("File path inc. name: ");
            string filepath = InputReader<string>();
            Console.Write("New(1) or Overwrite(2): ");
            if (InputReader<int>() == 1)
            {
                if (!File.Exists(filepath))
                {
                    File.WriteAllText($@"{filepath}", "");
                }
                else
                {
                    Console.WriteLine("File already exists. ");
                    return;
                }
            }
            else
            {
                File.WriteAllText($@"{filepath}", "");
            }
        }

        // Extra feature if I have time
        void FileWriter()
        {

        }

        void DeleteFile()
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("File path inc. name: ");
            string filepath = InputReader<string>();

            File.Delete($@"{filepath}");
        }

        void DisplayFiles()
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("Folder path inc. name: ");
            string folderpath = InputReader<string>();
            Console.Write("File Extensions Search: ");
            string searchExt = InputReader<string>();
            Console.Write("Top or All: ");
            string pattern = InputReader<string>();

            if (pattern.ToLower().Contains("all"))
            {
                string[] files = Directory.GetFiles($@"{folderpath}", $@"{searchExt}", SearchOption.AllDirectories);
                Console.Write("Files found:\n| ");

                foreach (string file in files)
                {
                    Console.Write($"{file} | ");
                }
            } 
            else
            {
                string[] files = Directory.GetFiles($@"{folderpath}", $@"{searchExt}", SearchOption.TopDirectoryOnly);
                Console.Write("Files found:\n| ");
                
                foreach (string file in files)
                {
                    Console.Write($"{file} | ");
                }
            }

            

        }

        void AddFolder()
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("Folder path inc. name: ");
            string folderpath = InputReader<string>();

            Directory.CreateDirectory($@"{folderpath}");
        }

        void SearchFileInFolder()
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("Folder path inc. name: ");
            string folderpath = InputReader<string>();
            Console.Write("File name: ");
            string fileName = InputReader<string>();
            Console.Write("Top or All: ");
            string pattern = InputReader<string>();

            if (pattern.ToLower().Contains("all"))
            {
                string[] files = Directory.GetFiles($@"{folderpath}", $@"{fileName}*", SearchOption.AllDirectories);
                Console.Write($"Files matching found in {folderpath}:\n| ");

                foreach (string file in files)
                {
                    string path = Path.GetDirectoryName($@"{file}");
                    path = path.Substring(0, path.Length - 1);
                    path += fileName.Substring(2, fileName.Length - 2);
                    Console.Write($"{path} | ");
                }
            }
            else
            { 
                string[] files = Directory.GetFiles($@"{folderpath}", $@"{fileName}*", SearchOption.TopDirectoryOnly);
                Console.Write($"Files matching found in {folderpath}:\n| ");

                foreach (string file in files)
                {
                    string path = Path.GetDirectoryName($@"{file}");
                    path = path.Substring(0, path.Length - 1);
                    path += fileName.Substring(2, fileName.Length - 2);
                    Console.Write($"{path} | ");
                }
            }

        }

        void Exit()
        {
            Environment.Exit(0);
        }

        dynamic InputReader<T>()
        {
            string input = Console.ReadLine();

            if (typeof(T) == typeof(int))
            {
                return int.Parse(input);
            }
            return input;
        }

        void MainMenu()
        {
            Console.Write("===============================================\n" +
                          "                                               \n" +
                          "           H1 Queue Operations Menu            \n" +
                          "                                               \n" +
                          "===============================================\n" +
                          "\n" +
                          "1. Add file\n" +
                          "2. Delete file\n" +
                          "3. Display files\n" +
                          "4. Add folder\n" +
                          "5. Search for file in folder\n" +
                          "6. Exit\n" +
                          "\n" +
                          "Enter your choice: ");
        }
    }
}
