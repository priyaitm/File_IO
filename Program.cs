using System;
using System.IO;

namespace FileHandlingDemo
{
    internal class Program
    {
        public void ExitFile()
        {
            string path = @"C:\Users\DELL\source\repos\dataSample.txt";
            if (File.Exists(path))
            {
              Console.WriteLine("File is Exit");
            }
            else
            {
                Console.WriteLine("File is  not found");
            }
            Console.ReadLine();
        }

        public void ReadFile()
        {
            string path = @"C:\Users\DELL\source\repos\dataSample.txt";

            if (File.Exists(path))
            {
               string data = File.ReadAllText(path);

                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("file not found");
            }
            Console.ReadLine();

        }

        public void WriteFile()
        {
            string path = @"C:\Users\DELL\source\repos\dataSample.txt";

            if (File.Exists(path))
            {
                string data1 = "This is new text File ";

                File.AppendAllText(path, data1);

                string data = File.ReadAllText(path);

                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("file not found");
            }
            Console.ReadLine();


        }

        public void CopyFile()
        {
            string path = @"C:\Users\DELL\source\repos\dataSample.txt";
            string path2 = @"C:\Users\DELL\source\repos\dataSample1.txt";

            // File.Copy(path, path2);
            File.Copy(path, path2, true);
            Console.ReadLine();

        }





        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            //program.ExitFile();
            //program.ReadFile();
           // program.WriteFile();
           program.CopyFile();





          //Console.ReadLine();
        }
    }
}
