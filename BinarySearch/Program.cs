using System;

namespace BinarySearch
{
    class Program
    {
        static void Show(int x) { Console.WriteLine("Number {0} doesn't exist.", x); }
        static void ShowIndex(int a, int b) { Console.WriteLine("Number {0} array's index {1}", a, b); }
        static void Main()
        {
            int x = -82;
            int[] yourArr = { -83, -79, -56, -9, -5, -2, 7, 24, 31, 61 };

            int left = 0;
            int right = yourArr.Length;
            int z = yourArr.Length >> 1;


            do
            {
                if (x == yourArr[z])
                {
                    ShowIndex(x, z); break;
                }

                if (x > yourArr[z])
                {
                    left = ++z;
                    if (left >= yourArr.Length)
                    {
                        Show(x); break;
                    }
                    if (x == yourArr[left])
                    {
                        ShowIndex(x, left); break;
                    }
                    z = (left + right) >> 1;
                }

                if (x < yourArr[z])
                {
                    right = --z;
                    if (0 > right || right < left)
                    {
                        Show(x); break;
                    }
                    if (x == yourArr[right])
                    {
                        ShowIndex(x, right); break;
                    }
                    z = (left + right) >> 1;
                }

                if (left == right)
                {
                    Show(x); break;
                }

            } while (left != right);

            Console.ReadKey();
        }
    }
}
