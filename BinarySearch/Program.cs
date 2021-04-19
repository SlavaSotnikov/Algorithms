using System;

namespace BinarySearch
{
    class Program
    {
        static void Show() { Console.WriteLine("Number doesn't exist."); }
        static void ShowIndex(int a, int b) { Console.WriteLine("Number {0} array's index {1}", a, b); }
        static void Main()
        {
            int x = 67;
            int[] myArr = { -55, -49, -17, 8, 41, 56, 60, 67, 85, 99 };

            int left = 0;
            int right = myArr.Length;
            int z = myArr.Length >> 1;


            do
            {
                if (x == myArr[z])
                {
                    ShowIndex(x, z); break;
                }

                if (x > myArr[z])
                {
                    left = ++z;
                    if (left >= myArr.Length)
                    {
                        Show(); break;
                    }
                    if (x == myArr[left])
                    {
                        ShowIndex(x, left); break;
                    }
                    z = (left + right) >> 1;
                }

                if (x < myArr[z])
                {
                    right = --z;
                    if (0 > right || right < left)
                    {
                        Show(); break;
                    }
                    if (x == myArr[right])
                    {
                        ShowIndex(x, right); break;
                    }
                    z = (left + right) >> 1;
                }

                if (left == right)
                {
                    Show(); break;
                }

            } while (left != right);

            Console.ReadKey();
        }
    }
}
