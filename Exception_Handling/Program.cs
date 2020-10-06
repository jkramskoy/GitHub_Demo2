using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //user input
            Console.Write("Please add first number in the range 0-255: ");
            int firtsNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please add second number in the range 0-255: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            //output
            Console.WriteLine("{0} / {1} = {2}", firtsNum, secondNum, firtsNum / secondNum);

        }
    }
}
