using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class Class6
    {
        public static void book()
        {
            Console.WriteLine("book over due fine ");
            Console.WriteLine("enter the total number of day book was borrwed ");

            int total_day = Convert.ToInt32(Console.ReadLine());

            if (total_day <= 7)
            {
                Console.WriteLine("no amoount to be paid it is free for 7 days ");

            }
            else
            {
                int extra_day = total_day - 7;
                Console.WriteLine($"the amount to be paid as fine {extra_day * 0.50} $");
            }
        }
    
    }
}
