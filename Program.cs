using System;

namespace ShiftNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num, novo;

            Console.Write("Enter numbers separated by space: ");
            num = Console.ReadLine().Split(" ");
            Console.Write("Enter the number of shift (between 1 and number of data) : ");

            int k = int.Parse(Console.ReadLine());
            if (k < 1 || k > num.Length)
            {
                Console.WriteLine("Shift number invalid");
                Console.Read();
            }
            else
            {
                novo = ShiftNum.Solution(num, k);
                Console.Write("The number shifted by k to right is : ");
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(novo[i]);
                }
            }
        }
    }
}
