using System;
using System.IO;

namespace HomeTask

{
    class Program
    {
        static void Main(string[] args)
        {
            #region Filedirectory
            Directory.CreateDirectory("C:/Users/ibm/Documents/Anar205/");
            //File.Create(@"C:/Users/ibm/Documents/Anar205/Anar.txt");
            //string path = @"C:/Users/ibm/Documents/Anar205/";
            //string folderName = Console.ReadLine();
            //string[] files = Directory.GetFiles(path);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}
            //string[] directories = Directory.GetDirectories(path);
            // foreach (var directory in directories)
            // {
            //    Console.WriteLine(directory);
            // }


            //if (Directory.Exists(path + directories))
            //{
            //    //directories = directories + 1;
            //    Console.WriteLine(directory);
            //}
            //Directory.CreateDirectory(path + directories);
            #endregion
            #region stream
            //StreamWriter writer = new StreamWriter(@"C:/Users/ibm/Documents/Anar205/Anar.txt");
            //writer.WriteLine("salam");
            string path = @"C:/Users/ibm/Documents/Anar205/Anar.txt";
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = " ";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //Console.ReadKey(); 
            //using (StreamWriter sr = File.AppendText(path))
            //{
            //    sr.WriteLine("Guru99-AS.Net");
            //    sr.Close();
            //    Console.WriteLine(File.ReadAllText(path));
               
            //}
            //Console.ReadKey(); 

            #endregion
        }
    }
}
