using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public  class Class3
    {
        public static void calculator()
        {
            Console.WriteLine("calculator ");
            Console.WriteLine("enter the first number  ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the secound number  ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the operation based on need ");
            Console.WriteLine("for addtion enter \"+\"\nfor substraction enter \"-\"\nfor multiplication enter \"*\"\nfor divison enter \"/\"");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    double sum = num1 + num2;
                    Console.WriteLine(sum);
                    break;
                case "-":
                    double diff = num1 - num2;
                    Console.WriteLine(diff);
                    break;
                case "/":
                    if (num2 == 0) { Console.WriteLine("Undifiend"); }
                    else
                    {
                        double div = num1 / num2;
                        Console.WriteLine(div);

                    }
                    break;
                case "*":
                    double mul = num1 * num2;
                    Console.WriteLine(mul);
                    break;
                default:
                    Console.WriteLine("pls enter the valid operation ");
                    break;
            }
        }
    }
}
