using System;

namespace BubbleGoesUpDown
{
    class Program
    {
        static void Main()
        {
            int[] myArr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            // A bubble goes down

            for (int j = 0; j < myArr.Length; j++)
            {
                for (int i = myArr.Length - 1; i > 0; i--)
                {
                    if (myArr[i] < myArr[i - 1])
                    {
                        (myArr[i - 1], myArr[i]) = (myArr[i], myArr[i - 1]);
                    }
                }
                Console.Write("{0} ", myArr[j]);
            }

            Console.WriteLine();

            //A bubble goes up

            for (int j = 0; j < myArr.Length; j++)
            {
                for (int i = 0; i < myArr.Length - (j + 1); i++)
                {
                    if (myArr[i] > myArr[i + 1])
                    {
                        (myArr[i], myArr[i + 1]) = (myArr[i + 1], myArr[i]);
                    }
                }
                Console.Write("{0} ", myArr[myArr.Length - (j + 1)]);
            }

            Console.ReadKey();
        }
    }
}
