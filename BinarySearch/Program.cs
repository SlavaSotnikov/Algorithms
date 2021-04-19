using System;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int x = 64;
            int[] myArr = { -55, -49, -17, 8, 41, 56, 60, 67, 85, 99 };

            int left = 0;
            int right = myArr.Length;
            int z = myArr.Length >> 1;


            do
            {
                if (x == myArr[z])
                {
                    Console.WriteLine("Number {0} array's index {1}", x, z);
                    break;
                }
                if (x > myArr[z])
                {
                    left = ++z;
                    if (left >= myArr.Length)
                    {
                        Console.WriteLine("Number doesn't exist.");
                        break;
                    }
                    if (x == myArr[left])
                    {
                        Console.WriteLine("Number {0} array's index {1}", x, left);
                        break;
                    }
                    z = (left + right) >> 1;
                }
                if (x < myArr[z])
                {
                    right = --z;
                    if (0 > right || right < left)
                    {
                        Console.WriteLine("Number doesn't exist.");
                        break;
                    }
                    if (x == myArr[right])
                    {
                        Console.WriteLine("Number {0} array's index {1}", x, right);
                        break;
                    }
                    z = (left + right) >> 1;
                }

                if (left == right)
                {
                    Console.WriteLine("Number doesn't exist.");
                    break;
                }
            } while (left != right);

            Console.ReadKey();
        }
    }
}
