using System;

namespace BubbleGoesUpDown
{
    class Program
    {
        static void Main()
        {
            int[] yourArr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            // A bubble goes down

            for (int j = 0; j < yourArr.Length; j++)
            {
                for (int i = yourArr.Length - 1; i > 0; i--)
                {
                    if (yourArr[i] < yourArr[i - 1])
                    {
                        (yourArr[i - 1], yourArr[i]) = (yourArr[i], yourArr[i - 1]);
                    }
                }
                Console.Write("{0} ", yourArr[j]);
            }

            Console.WriteLine();

            //A bubble goes up

            for (int j = 0; j < yourArr.Length; j++)
            {
                for (int i = 0; i < yourArr.Length - (j + 1); i++)
                {
                    if (yourArr[i] > yourArr[i + 1])
                    {
                        (yourArr[i], yourArr[i + 1]) = (yourArr[i + 1], yourArr[i]);
                    }
                }
                Console.Write("{0} ", yourArr[yourArr.Length - (j + 1)]);
            }

            Console.ReadKey();
        }
    }
}
