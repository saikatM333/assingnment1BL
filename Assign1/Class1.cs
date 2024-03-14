using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class Class1
    {
        public static void light()
        {
            Boolean f = true;
            int i = 0;
            int intervel = 3;
            int j = 0;
            int k = 0;
            while (f==true)
            {
                 if (i<=intervel)
                {
                    Console.WriteLine("red");
                    i++;
                }
                 else if (i>intervel && j<=intervel)
                {
                    Console.WriteLine("yellow");
                    j++;
                }
                 else if(i > intervel && k <= intervel)
                {
                    Console.WriteLine("green");
                    k++;
                    i=0; j=0;
                }


            }
        }
    }
}
