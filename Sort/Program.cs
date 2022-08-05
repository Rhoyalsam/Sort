using System;

namespace sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] newArray = new int[9] { 21, 42, 33, 72, 28, 13, 4, 25, 7 };


            for (int i = 0; i <= newArray.Length - 1; i++)
            {
                for (int j = 0; j <= newArray.Length - 2; j++)
                {
                    if (newArray[j] < newArray[j + 1])
                    {
                        temp = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = temp;
                    }
                }
            }
            foreach (int item in newArray)
            {
                Console.WriteLine(item);

            }

        }
    }
}
