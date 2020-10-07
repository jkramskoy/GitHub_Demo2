using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWrongCondition = false;
            Console.Write("Please add first number in the range 0-255: ");
            int firtsNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please add second number in the range 0-255: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            //user input
            do {
                if (isValidNumber(firtsNum) && isValidNumber(secondNum))
                {
                    Console.WriteLine("{0} / {1} = {2}", firtsNum, secondNum, firtsNum / secondNum);
                    isWrongCondition = false;
                }
                else
                {
                    Console.WriteLine("Error!!Please add number in the range 0-255");
                    Console.Write("Please add first number in the range 0-255: ");
                    firtsNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please add second number in the range 0-255:");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    isWrongCondition = true;
                }
            } while (isWrongCondition);
        }

        static bool isValidNumber(int num)
        {
            if (num >= 0 && num <= 255)
            {
                return true;
            }
            else return false;
        }
    }
}
