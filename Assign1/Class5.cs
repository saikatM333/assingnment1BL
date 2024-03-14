using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public  class Class5
    {
        public static void rockpaper()
        {
            Console.WriteLine("Rock paper game ");

            Console.WriteLine("for paper type \"p\"\nfor sessior type \"s\"\nfor rock type \"r\"");

            Console.WriteLine("player 1 ");
            string p1 = Console.ReadLine();
            Console.WriteLine("player 2 ");
            string p2 = Console.ReadLine();

            if (((p1 == "r" || p1 == "R") && (p2 == "s" || p2 == "S")) || (p1 == "s" || p1 == "S") && (p2 == "p" || p2 == "P") || (p1 == "p" || p1 == "P") && (p2 == "r" || p2 == "R"))
            {
                Console.WriteLine("player 1 win ");
            }
            else if (((p2 == "r" || p2 == "R") && (p1 == "s" || p1 == "S")) || (p2 == "s" || p2 == "S") && (p1 == "p" || p1 == "P") || (p2 == "p" || p2 == "P") && (p1 == "r" || p1 == "R"))
            {
                Console.WriteLine("player 2 win ");
            }
            else
            {
                Console.WriteLine("wrong input ");
            }
        }
    }
}
