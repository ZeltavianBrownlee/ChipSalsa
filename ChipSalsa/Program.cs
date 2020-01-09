using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSalsa
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and intialize variables
            string[] chips = new string[5];
            chips[0] = "mild";
            chips[1] = "medium";
            chips[2] = "sweet";
            chips[3] = "zesty";
            chips[4] = "hot";

            int[] salsa = new int[5];
            int i = 0;
            
            int maxElement = 0;
            int minElement = 0;

            //Prompt for and get array elements
            for (i = 0; i < 5; i++)
            {
                Console.Write("Please enter the number of sales for {0}:  ", chips[i]);
                salsa[i] = int.Parse(Console.ReadLine());
            }//end for loop

            //declare and intialize variables to determine min and max
            int maxSalsa = salsa[0];
            int minSalsa = salsa[0];
            
            //step through loop to get min and max element
            for (i = 1; i < 5; i++)
                {
                    if (salsa[i] > maxSalsa)//conditional statement for max number in array
                    {
                        maxSalsa = salsa[i];
                        maxElement = i;
                    }//end if

                    if (salsa[i] < minSalsa)//conditional statement for min number in array
                    {
                        minSalsa = salsa[i];
                        minElement = i;
                    }//end if
                }//end for loop

              
            
            //step through loop to show each salsa sales
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Total sales for {0} is: {1}", chips[i], salsa[i]);
            }

            Console.WriteLine("\n\nThe lowest selling salsa was {0} with {1} products sold.", chips[minElement],salsa[minElement]);//display lowest selling salsa
            Console.WriteLine("The hightest selling salsa was {0} with {1} products sold.", chips[maxElement],salsa[maxElement]);//display highest selling salsa
            Console.ReadKey();

        }
    }
}
