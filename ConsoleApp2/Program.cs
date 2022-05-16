using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int [] arr = new int[] {1,2,2,2,2,3,5,6 };
            HashSet<int> set = new HashSet<int>(arr);
            foreach (var i in set)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
