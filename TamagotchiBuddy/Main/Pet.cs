using System;
using System.Collections.Generic;
using System.IO;
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
        static private bool sleepFlag = false;

        static public bool LoadGame()
        {
            if (File.Exists("../../saveGame.txt"))
            {
                string[] saveData = File.ReadAllLines("../../saveGame.txt");
                Pet.Hunger = int.Parse(saveData[0]);
                Pet.Tiredness = int.Parse(saveData[1]);
                Pet.Hygene = int.Parse(saveData[2]);
                Pet.Fun = int.Parse(saveData[3]);
                Pet.gamesPlayed = int.Parse(saveData[4]);
                Pet.SleepFlag = bool.Parse(saveData[5]);
                return true;
            }
            else
            {
                return false;
            }
        }
        static public void SaveGame()
        {
            var fileStream = new FileStream("../../saveGame.txt", FileMode.Create);
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(Pet.Hunger + Environment.NewLine + Pet.Tiredness + Environment.NewLine + Pet.Hygene + Environment.NewLine + Pet.Fun + Environment.NewLine + Pet.gamesPlayed + Environment.NewLine + Pet.SleepFlag);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                fileStream.Close();
            }
        }

        // Getter/setters for pet attributes.
        static public bool SleepFlag
        {
            get
            {
                return sleepFlag;
            }
            set
            {
                sleepFlag = value;
            }
        }

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
