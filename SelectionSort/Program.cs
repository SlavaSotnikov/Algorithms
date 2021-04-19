using System;

namespace SelectionSort
{
    class Program
    {
        static void GetSelectionSort(ref int[] yourArr)
        {
            int index = 0;

            for (int j = 1; j < yourArr.Length; j++)
            {
                for (int i = j; i < yourArr.Length; i++)
                {
                    if (yourArr[index] > yourArr[i])
                    {
                        (yourArr[index], yourArr[i]) = (yourArr[i], yourArr[index]);
                    }
                }
                index++;
            }
        }
        static void Main()
        {
            int[] yourArr = { -99, 84, -4, -94, -75, -54, 13, 93, 35, -58 };


            Console.Write("Your array: ");
            for (int k = 0; k < yourArr.Length; k++)
            {
                Console.Write("{0} ", yourArr[k]);
            }            


            GetSelectionSort(ref yourArr);

            Console.WriteLine();

            Console.Write("Sort array: ");
            for (int k = 0; k < yourArr.Length; k++)
            {
                Console.Write("{0} ", yourArr[k]);
            }

            Console.ReadKey();
        }
    }
}
