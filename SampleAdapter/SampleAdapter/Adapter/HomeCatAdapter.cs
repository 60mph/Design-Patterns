using SampleAdapter.HomeCats;
using SampleAdapter.WildCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.Adapter
{
    class HomeCatAdapter : IHomeCat
    {
        private IWildCat wildCat;
        public HomeCatAdapter(IWildCat wildCat)
        {
            this.wildCat = wildCat;
        }

        public string Name
        {
            get => wildCat.Breed;
            set { }
        }
        public void Meow()
        {
            wildCat.Growl();
        }

        public void Scratch()
        {
            wildCat.Scratch();
        }
    }
}
