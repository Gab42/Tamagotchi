using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Pet
    {
        // Stats.
        private int hunger;
        private int tiredness;
        private int hygene;
        private int fun;

        // Constructor.
        public Pet()
        {
            hunger = 3;
            tiredness = 3;
            hygene = 3;
            fun = 3;
        }

        // Getter/setters for pet attributes.
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }

        public int Hygene
        {
            get
            {
                return hygene;
            }
            set
            {
                hygene = value;
            }
        }

        public int Tiredness
        {
            get
            {
                return tiredness;
            }
            set
            {
                tiredness = value;
            }
        }

        public int Fun
        {
            get
            {
                return fun;
            }
            set
            {
                fun = value;
            }
        }

    }
}
