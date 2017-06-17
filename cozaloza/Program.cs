using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozaloza
{
    class Program
    {
        static void Main(string[] args)
        {
          
                int min = 1;
                int max = 110;
                for (int num = min; num <= max; ++num)
                {

                    if (num % 3 == 0)
                    {
                        Console.WriteLine("Coza" + " ");
                    }             


                    if (num % 5 == 0)
                    {
                        Console.WriteLine("Loza" + " ");
                    }             

                    if (num % 7 == 0)
                    {
                        Console.WriteLine("Woza" + " ");
                    }           
                    
                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("CozaLoza" + " ");
                    }           


                    if (num % 3 != 0 && num % 5 != 0 && num % 7 != 0)
                    {
                        Console.WriteLine (num + " ");
                    }            


                    if (num % 11 == 0)
                    {
                        Console.WriteLine();

                    }

                       Console.ReadKey();   

                }
            }
        }

    }

