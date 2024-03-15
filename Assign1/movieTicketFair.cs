using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class Class4
    {
        public static void ticket()
        {
            Console.WriteLine("Movie ticket counter ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("the ticket price is 100 for children ");
            }
            else if (age >= 12 && age <= 64)
            {
                Console.WriteLine("the ticket fair is 150 for adults ");
            }
            else
            {
                Console.WriteLine("the ticket fair is 70 for 65+ age or senior  ");
            }
        }
    }
}
