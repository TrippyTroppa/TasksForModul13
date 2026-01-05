using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TasksForModul13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:/Users/1/Downloads/cdev_Text.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };       
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
        }

        
    }

}
