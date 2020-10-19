using System;
using static System.Console;


namespace The_Zoo
{
    public class Bear: IAnimal
    {
        public Bear()
        {
        }

        public bool _isGrizzly { set; get; }

        public string Species => "bear";

        public int Age { get; set; }

        public void GetDescription()
        {
            if (this._isGrizzly)
                
                WriteLine($"{Age} -year-old grizzly bear.");
            else
                WriteLine($"{Age} -year-old not grizzly bear.");
        }

        public void RequestUniqueCharacteristic()
        {
            Write("Is it a grizzly bear (true/false)?");
            string boolString = ReadLine();
            _isGrizzly = boolString == "true";
        }

    }
}
