using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class Class8
    {
        public static void grade()
        {
            Console.WriteLine("Marks predictor ");

            int marks = Convert.ToInt32(Console.ReadLine());
            marks = marks / 10;

            switch (marks)
            {
                case 10:
                case 9:
                    Console.WriteLine("Your grade is A");
                    break;

                case 8:
                    Console.WriteLine("your grade is B");
                    break;
                case 7:
                    Console.WriteLine("your grade is C");
                    break;
                case 6:
                    Console.WriteLine("your grade is D");
                    break;
                default:
                    Console.WriteLine("your grade is F");
                    break;
            }
        }
    }
}
