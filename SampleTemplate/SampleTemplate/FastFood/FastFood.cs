using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.FastFood
{
    abstract class FastFood
    {
        public void Prepare()
        {
            RoastBread();
            PrepareMainIngridient();
            PutVegitables();
            if (CustomerWantsTopings())
            {
                AddTopings();
            }
        }

        public virtual bool CustomerWantsTopings()
        {
            return true;
        }

        public virtual void PutVegitables()
        {
            Console.WriteLine("Vegitables");
        }

        public abstract void AddTopings();
        public abstract void PrepareMainIngridient();
        public virtual void RoastBread()
        {
            Console.WriteLine("Bread");
        }
    }
}
