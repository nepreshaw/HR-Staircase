using System;

namespace HR_Staircase
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 6;

            for (int i = n - 1; i >= 0; i--)
            {

                for (int x = 0; x < n; x++)
                {
                    if (x >= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }


        }
    }
}
