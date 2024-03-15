using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public  class Class10
    {
        public static void bookResevation()
        {
            int limits = 14;
            Console.WriteLine("enter the days you wantn to  reserve the book");
            int reservation =Convert.ToInt32 (Console.ReadLine());  
            Random rand = new Random(); 
            int availablity = rand.Next (0, 2);

            if (limits <reservation && availablity == 1)
            {
                Console.WriteLine("you can take the book its available ");
            }
            else if (availablity==0){ Console.WriteLine("you can not  take the book its not available "); 
            }
            else
            {
                Console.WriteLine("you can not  take the book pls mention reservation within limts ");
            }

        }
    }
}
