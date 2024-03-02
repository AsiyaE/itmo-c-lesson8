using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson8_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\Programs\\MyLabsITMO\\C#course";
            Console.WriteLine("Начинаем поиск в деректории: {0}", path);
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                string[] dirsInside = Directory.GetDirectories(dir);
                Console.WriteLine("следующая директория внутри: {0}", dir);
                Console.WriteLine("файлы в данной директории");
                string[] files = Directory.GetFiles(dir);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }   
            }

            Console.ReadKey();
        }
    }
}
