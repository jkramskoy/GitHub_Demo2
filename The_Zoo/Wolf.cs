using System;
using static System.Console;



namespace The_Zoo
{
    public class Wolf:IAnimal
    {
        public Wolf()
        {
        }

        public string _run { set; get; }

        public string Species => "wolf";

        public int Age { get; set; }

        public void GetDescription()
        {
            WriteLine($"{Age} -year-old {Species} that runs {_run } km/h.");
        }

        public void RequestUniqueCharacteristic()
        {
            Write("How fast can it run (in km/h)? ");
            _run = ReadLine();
        }

        
    }
}
