using System;

namespace InsertionSort
{
    class Program
    {
        static void Main()
        {
            int[] yourArr = { 66, -62, -28, -26, -3, 75, 89, -85, 23, -48 };

            int i = 0;
            int memory = 0;

            Console.Write("Your array: ");

            for (int k = 0; k < yourArr.Length; k++)
            {
                Console.Write("{0} ", yourArr[k]);
            }

            while (i < yourArr.Length - 1)
            {
                if (yourArr[i] > yourArr[i + 1])
                {
                    (yourArr[i], yourArr[i + 1]) = (yourArr[i + 1], yourArr[i]);
                    if (i != 0)
                    {
                        i--;
                    }
                    else
                    {
                        memory++;
                        i = memory;
                    }
                }
                else
                {
                    memory++;
                    i = memory;
                }
            }

            Console.WriteLine();

            Console.Write("Sort array: ");

            for (int l = 0; l < yourArr.Length; l++)
            {
                Console.Write("{0} ", yourArr[l]);
            }

            Console.ReadKey();                        
        }
    }
}
