using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheData
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\test.txt";
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine("some text");
                writer.WriteLine("HAPPY HOURS");
            }
            string result = Path.GetFileNameWithoutExtension( @"D:\test.txt");
            Console.WriteLine(result);
            string file = File.ReadAllText(filepath);
            Console.WriteLine(file);
            Console.ReadKey();
        }
    }
}
