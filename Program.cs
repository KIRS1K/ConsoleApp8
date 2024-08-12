using System;
using System.IO;

namespace ReadMyFile
{



    class Program
    {
        public static void Main()
        {
            string filePath = @"D:\1\Новая папка\";
            DirectoryInfo filePath1 = new DirectoryInfo (@"D:\1\Новая папка\");
            if (!File.Exists(filePath))
            {
                /*
                Console.WriteLine("+");
                */
                FileInfo[] fiArr = filePath1.GetFiles();
                // Display the names and sizes of the files.
                Console.WriteLine("The directory {0} contains the following files:", filePath1.Name);
                foreach (FileInfo f in fiArr)
                    Console.WriteLine("The size of {0} is {1} bytes.", f.Name, f.Length);
            }
            else { Console.WriteLine("-"); }
                
        }
    }
}