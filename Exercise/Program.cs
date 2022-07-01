using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            File.WriteAllText(@"c:\Users\Александр\source\repos\HomeWork6\data.txt", s);
            //Console.WriteLine("Hi, I am here!");
            //DateTime date = new DateTime(2022, 06, 20);
            //Console.WriteLine((DateTime.Now.Subtract(date).TotalDays));
            //Console.WriteLine(Math.Abs(-25));
            Console.ReadKey();
        }
    }
}
