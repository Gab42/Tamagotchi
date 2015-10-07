using System;
using System.IO;
using System.Text;


namespace Main
{
    static class Pet
    {
        // Stats.
        static private int hunger;
        static private int tiredness;
        static private int hygene;
        static private int fun;        
        static private bool sleepFlag;
        //static public int gamesPlayed = 0;
        static private DateTime lastPlayed = DateTime.Now;

        static public void NewGame()
        {
            Pet.Hunger = 3;
            Pet.Tiredness = 3;
            Pet.Hygene = 3;
            Pet.Fun = 3;
            Pet.SleepFlag = false;
        }

        static public bool LoadGame()
        {
            if (File.Exists("../../saveGame.txt"))
            {              
                string[] saveData = File.ReadAllLines("../../saveGame.txt");
                var timePeriod = Convert.ToInt32((DateTime.Now - DateTime.Parse(saveData[5])).TotalHours)/2;
                Pet.SleepFlag = bool.Parse(saveData[4]);               
                Pet.Hunger = int.Parse(saveData[0]) - timePeriod;
                Pet.Hygene = int.Parse(saveData[2]) - timePeriod;
                Pet.Fun = int.Parse(saveData[3]) - timePeriod;

                if (Pet.Hunger < 0)
                {
                    Pet.Hunger = 0;
                }
                if (Pet.Hygene < 0)
                {
                    Pet.Hygene = 0;
                }
                if (Pet.Fun < 0)
                {
                    Pet.Fun = 0;
                }

                if (SleepFlag)
                {
                    Pet.Tiredness = int.Parse(saveData[1]) + timePeriod;
                    if (Pet.Tiredness > 6)
                    {
                        Pet.Tiredness = 6;
                    }
                }
                else
                {
                    Pet.Tiredness = int.Parse(saveData[1]) - timePeriod;
                    if (Pet.Tiredness < 0)
                    {
                        Pet.Tiredness = 0;
                    }
                }
                return true;             
            }
            else
            {
                return false;
            }
        }

        static public void SaveGame()
        {
            lastPlayed = DateTime.Now;//Last played
            var fileStream = new FileStream("../../saveGame.txt", FileMode.Create);
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(Pet.Hunger + Environment.NewLine + Pet.Tiredness + Environment.NewLine + Pet.Hygene + Environment.NewLine + Pet.Fun + Environment.NewLine + Pet.SleepFlag + Environment.NewLine + Pet.lastPlayed);
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
