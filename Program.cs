using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork8T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = "C:\\Обьект Муниципальное здание";

           
            if (Directory.Exists(folder))
            {
                Console.WriteLine("Папки:");
                string[] dir = Directory.GetDirectories(folder,"*",SearchOption.AllDirectories);
                foreach (string s in dir)
                {
                    Console.WriteLine("Папка:");
                    Console.WriteLine(s);
                    
                    Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(s);
                    foreach (string f in files)
                    {
                        Console.WriteLine(f);
                    }
                }
                          
            }

            Console.ReadKey();
        }
    
    }
}
