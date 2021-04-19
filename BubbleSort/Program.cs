using System;

namespace BubbleSort
{
    class Program
    {
        static int GetBubbleSort(int[] yourArr, ref int j)
        {
            for (int i = yourArr.Length - 1; i > 0; i--)
            {
                if (yourArr[i] < yourArr[i - 1])
                {
                    (yourArr[i - 1], yourArr[i]) = (yourArr[i], yourArr[i - 1]);
                }
            }
            return yourArr[j];
        }
        static void Main()
        {
            int[] yourArr = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < yourArr.Length; i++)
            {
                yourArr[i] = rnd.Next(-100, 100);
            }


            int[] sortArr = new int[yourArr.Length];

            string stringMyarr = String.Empty;
            for (int i = 0; i < yourArr.Length; i++)
            {
                stringMyarr += Convert.ToString(yourArr[i]) + " ";
            }

            string stringSortarr = String.Empty;
            for (int index = 0; index < sortArr.Length; index++)
            {
                stringSortarr += Convert.ToString(GetBubbleSort(yourArr, ref index)) + " ";
            }

            Console.WriteLine("  Your array: {0}", stringMyarr);
            Console.WriteLine();
            Console.WriteLine("Sorted array: {0}", stringSortarr);

            Console.ReadKey();
        }
    }
}
