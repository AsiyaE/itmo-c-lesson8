using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson8_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            Random rnd = new Random();
            long sum = 0;
            string parentPath = Directory.GetParent(Directory.GetParent(path).FullName).FullName;
            Console.WriteLine(parentPath);

            string filePath = String.Concat(parentPath, "\\","textFile.txt");
            Console.WriteLine("filePath {0}",parentPath);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                for (int i=0; i<10; i++)
                {
                    sw.WriteLine(rnd.Next());
                }
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    int number = Convert.ToInt32(line);
                    sum += number;
                    line = sr.ReadLine();
                }

            }

            Console.WriteLine("Сумма чисел {0}", sum);
            Console.ReadKey();
        }
    }
}
