using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace The_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IAnimal> animals = new List<IAnimal>();


            try
            {

                for (int i = 1; i <= 3; i++)
                {
                    IAnimal animal = null;

                    WriteLine($"Enter the information for Cage {i}");

                    Write("What is the animal’s species?");
                    var species = ReadLine();
                    if (species.Trim().ToLower() == "lion")
                        animal = new Lion();

                    if (species.Trim().ToLower() == "wolf")
                        animal = new Wolf();

                    if (species.Trim().ToLower() == "bear")
                        animal = new Bear();

                    Write("How old is it? ");


                    animal.Age = Convert.ToInt32(ReadLine());

                    animal.RequestUniqueCharacteristic();

                    animals.Add(animal);
                }
            }
            catch (FormatException exFormat)
            {
                WriteLine("Format Exception error :" + exFormat.Message);
            }
            catch (NullReferenceException exNull)
            {
                WriteLine("Null Reference Exception error :" + exNull.Message);
            }



            WriteLine("===================");

            for (int j = 0; j < animals.Count(); j++)
            {

                Write($"Cage {j + 1} contains a ");

                animals[j].GetDescription();
            }
            ReadLine();

        }
    }
}
