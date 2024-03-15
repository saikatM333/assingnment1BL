using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
  
    public class Class9
    {
        public static void AirIndex (double[] particlesComposition ) {
             int i = 0;
            int good = 0;
            
            int moderate = 0;
            int poor = 0;
            while (particlesComposition.GetLength(0) >= i)
            {
                switch (i)
                {

                    case 0:
                        if (particlesComposition[i] <= 50)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 100 && particlesComposition[i] >= 51)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;

                    case 1:
                        if (particlesComposition[i] <= 30)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 90 && particlesComposition[i] >= 31)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;
                    case 2:
                        if (particlesComposition[i] <= 40)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 80 && particlesComposition[i] >= 41)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;

                    case 3:
                        if (particlesComposition[i] <= 50)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 100 && particlesComposition[i] >= 51)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;
                    case 4:
                        if (particlesComposition[i] <= 1)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 2 && particlesComposition[i] >= 1.1)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;

                    case 5:
                        if (particlesComposition[i] <= 40)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 80 && particlesComposition[i] >= 41)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;

                    case 6:
                        if (particlesComposition[i] <= 0.5)
                        {
                            good++;
                        }
                        else if (particlesComposition[i] <= 1.0 && particlesComposition[i] >= 0.6)
                        {
                            moderate++;
                        }
                        else { poor++; }
                        break;
                }

            
            }
            if (good >= moderate && good>=poor ) {
                Console.WriteLine("the air index is good ");
            }
            else if (moderate <= poor && poor>=good) {
                Console.WriteLine("the air index is poor");
            }
            else
            {
                Console.WriteLine("Moderate air index ");
            }
        }
    }
}
