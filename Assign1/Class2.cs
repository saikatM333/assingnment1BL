using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class Class2
    {
        public static void login()
        {
            Console.WriteLine("login system ");

            string[,] credintial = { { "saikat", "sai123" }, { "sam", "sam123" } };
            Console.WriteLine("enter the username");
            string username = Console.ReadLine();
            Console.WriteLine("enter the password");
            string password = Console.ReadLine();
            Boolean flag = false;

            for (int i = 0; i < credintial.GetLength(0); i++)
            {
                if (credintial[i, 0] == username && credintial[i, 1] == password)
                {
                    Console.WriteLine("user successfully login ");
                    flag = true;
                    break;
                }

            }
            if (!flag)
            {
                Console.WriteLine("user not  successfully login ");
            }

        }
    }
}
