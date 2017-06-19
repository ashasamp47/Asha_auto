using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        public static void Main(string[] args)
        {
            PrintEven.Even();

            Console.ReadLine();
        }

    }

    class PrintEven
    {
        static int i; int j;
        public static void Even()
        {
            int j = 200;

            for (int i = 0; i < j; i = i + 2)
            {
                Console.WriteLine(i);
            }


        }
    }

}
