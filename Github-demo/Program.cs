using System;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
        //3 4
        int x = 3;
        int y = x++;
        WriteLine(y);
        WriteLine(x);

        WriteLine("----------------");

        //4 4
        int x1 = 3;
        int y1 = ++x1;
        WriteLine(y1);
        WriteLine(x1);

        WriteLine("----------------");

    A_label:
        var number = (new Random()).Next(1, 7);
        WriteLine($"My random number is {number}");
        switch (number)
        {
            case 1:
                WriteLine("One");
                break; // jumps to end of switch statement
            case 2:
                WriteLine("Two");
                goto case 1;
            case 3:
            case 4:
                WriteLine("Three or four");
                goto case 1;
            case 5:
                // go to sleep for half a second
                System.Threading.Thread.Sleep(500);
                goto A_label;
            default:
                WriteLine("Default");
                break;
        } // end of switch statement

        // Parsing from strings to numbers or dates and times
        WriteLine("----------------");

        int age = int.Parse("27");
        DateTime birthday = DateTime.Parse("4 July 1980");
        WriteLine($"I was born {age} years ago.");
        WriteLine($"My birthday is {birthday}.");
        WriteLine($"My birthday is {birthday:D}.");


        WriteLine("----------------");
        try
        {
            int z = int.MaxValue - 1;
            WriteLine(z);
            z++;
            WriteLine(z);
            z++;
            WriteLine(z);
            z++;
            WriteLine(z);
        }
        catch (OverflowException)
        {
            WriteLine("The code overflowed but I caught the exception.");
        }
        WriteLine("----------------");
        unchecked
        {

            int a = int.MaxValue + 1;
            WriteLine(a); // this will output -2147483648  
            a--;
            WriteLine(a); // this will output 2147483647  
            a--;
            WriteLine(a); // this will output 2147483646 
        }
       


    }
    public int Add(int num1, int num2)
    {
        return num1 + num2;

        do
        {

        } while (true);
    }



}

