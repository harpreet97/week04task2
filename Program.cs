using System;

namespace week04task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese type a number");
            string input = Console.ReadLine();
            int output = 0;

            if (int.TryParse(input, out output))
            {
                Console.WriteLine("Entered number is:" + output);
                if (output > 12)
                {

                }
                else
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        int total=output*i;
                        Console.WriteLine(string.Format("{0}x{1}={2}",output,i,total));
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

            Console.ReadKey();
        }
    }
}
