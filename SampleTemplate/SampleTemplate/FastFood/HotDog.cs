using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.FastFood
{
    class HotDog : FastFood
    {
        public override void AddTopings()
        {
            Console.WriteLine("Mustard");
        }

        public override bool CustomerWantsTopings()
        {
            Console.WriteLine("DO you want Mustard? (yes/other): ");
            var userInput = Console.ReadLine();
            return userInput.ToLower() == "yes";
        }

        public override void PrepareMainIngridient()
        {
            Console.WriteLine("Sausage");
        }

        public override void PutVegitables()
        {
            base.PutVegitables();
        }

        public override void RoastBread()
        {
            base.RoastBread();
        }
    }
}
