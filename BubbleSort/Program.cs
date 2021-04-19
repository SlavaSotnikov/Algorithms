using System;

namespace BubbleSort
{
    class Program
    {
        static int GetBubbleSort(int[] myArr, ref int j)
        {
            for (int i = myArr.Length - 1; i > 0; i--)
            {
                if (myArr[i] < myArr[i - 1])
                {
                    (myArr[i - 1], myArr[i]) = (myArr[i], myArr[i - 1]);
                }
            }
            return myArr[j];
        }
        static void Main()
        {
            int[] myArr = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(-100, 100);
            }


            int[] sortArr = new int[myArr.Length];

            string stringMyarr = String.Empty;
            for (int i = 0; i < myArr.Length; i++)
            {
                stringMyarr += Convert.ToString(myArr[i]) + " ";
            }

            string stringSortarr = String.Empty;
            for (int index = 0; index < sortArr.Length; index++)
            {
                stringSortarr += Convert.ToString(GetBubbleSort(myArr, ref index)) + " ";
            }

            Console.WriteLine("  Your array: {0}", stringMyarr);
            Console.WriteLine();
            Console.WriteLine("Sorted array: {0}", stringSortarr);

            Console.ReadKey();
        }
    }
}
