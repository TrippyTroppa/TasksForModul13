using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check(new int[] {100, 5, 6, 78, -8}));
            Console.WriteLine(Check(new[] { -1, 2, 3, 4, 8 }));
        }

        static bool Check(int[] num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i + 1] < num[i])
                    return false;
            }
            return true;
        }
    }

}
