using System;
using System.Net.Http.Headers;

namespace Week5Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Populate an array with numbers from 1 to 10*/
            //Option 1
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            
            //option 2
            int[] array2 = new int[10];
            array2[0] = 1;
            array2[1] = 2;
            array2[2] = 3;
            array2[3] = 4;
            array2[4] = 5;
            array2[5] = 6;
            array2[6] = 7;
            array2[7] = 8;
            array2[8] = 9;
            array2[9] = 10;

            //Option 3 - automatically populate the array with numbers
            //from 1 to 10

            int[] array3 = new int[10];

            for(int i = 0; i < array3.Length; i++)
            {
                array3[i] = i+1;
            }


            /*Populate the array with numbers from 10 to 1*/
            /*TODO*/

            int[] array4 = new int[10];

            for (int i = array4.Length-1, j = 0; i >= 0; i--, j++)
            {
                array4[j] = i + 1;
            }

            

            /*Populate an array of 10 elements with random values from 1 to 100*/


            int[] array5 = new int[10];
            Random rnd = new Random();

            for(int i = 0; i < array5.Length; i++)
            {
                array5[i] = rnd.Next(1, 101);
            }

            foreach (int num in array5)
            {
                Console.WriteLine(num);
            }
        }
    }
}
