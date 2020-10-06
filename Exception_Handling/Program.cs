using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //user input
            Console.Write("Please add first number: ");
            int firtsNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please add second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            //output
            Console.WriteLine("${0}/{1}={3}",firtsNum,secondNum,firtsNum/secondNum);

        }
    }
}
