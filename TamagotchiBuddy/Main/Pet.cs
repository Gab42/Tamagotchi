using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    static class Pet
    {
        // Stats.
        static private int hunger = 3;
        static private int tiredness = 3;
        static private int hygene = 3;
        static private int fun = 3;
        static public int gamesPlayed = 0;

        // Getter/setters for pet attributes.
        static public int Hunger
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

        static public int Hygene
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

        static public int Tiredness
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

        static public int Fun
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
