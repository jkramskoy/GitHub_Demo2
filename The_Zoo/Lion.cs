using System;
using static System.Console;




namespace The_Zoo
{
    public class Lion: IAnimal
    {
        public Lion()
        {
        }

        
        public string _mainColour { set; get; }
        public int Age { get; set; }

        public string Species => "lion";

        public void RequestUniqueCharacteristic()
        {
            Write("What colour is its mane?");
            _mainColour = ReadLine();
        }

        public void GetDescription()
        {
            WriteLine($"{Age} -year-old {Species}  with a {_mainColour} mane.");
        }
        
    }
}
