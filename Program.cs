using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int[] a1 = { 1, 2, 3, 4, 5 };  // length of array is 5 - ODD
                int temp1;
            Console.WriteLine("Values before swapping: \n");
            for (int old = 0; old < a1.Length; old++)
            {
                Console.WriteLine( a1[old]);

             }
            //Logic - Start
            //If the lenght is Even
            if (a1.Length % 2 == 0)
                {
                    for (int i = 0; i < a1.Length; i += 2)
                    {
                        //Console.WriteLine(a1[i]);

                        temp1 = a1[i];
                        a1[i] = a1[i + 1];
                        a1[i + 1] = temp1;
                    }

                }
                //If the lenght is Odd.
                else
                {
                    for (int i = 0; i < a1.Length - 1; i += 2)
                    {
                      
                        temp1 = a1[i];
                        a1[i] = a1[i + 1];
                        a1[i + 1] = temp1;
                    }
                }
                //Logic - End
            
                Console.WriteLine("Values after swapping: \n");
                for (int j = 0; j < a1.Length; j++)
                {
                    Console.WriteLine(a1[j]);
                }

                Console.ReadLine();
            }
        }
    }
