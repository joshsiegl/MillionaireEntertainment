using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.IO.IsolatedStorage;

namespace MonoGameSample.MillionaireEntertainment
{
    public static class IO
    {
        private static readonly string filePath_money = "Money.txt";
        private static readonly string filePath_loggedin = "LoggedIn.txt";
        private static readonly string filePath_spinsremaining = "SpinsRemaining.txt";
        private static readonly string filePath_level = "Level.txt";

        private static readonly string filePath_rateClicked = "RateClicked.txt";
        private static readonly string filePath_facebookClicked = "FacebookClicked.txt";

        public static void SaveFBClicked(bool saved)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filePath_facebookClicked, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(saved);
                        writer.Close();
                    }
                }
            }
        }

        public static bool LoadFBClicked()
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (storage.FileExists(filePath_facebookClicked))
                {
                    using (IsolatedStorageFileStream save = new IsolatedStorageFileStream(filePath_facebookClicked, FileMode.Open, storage))
                    {
                        using (BinaryReader reader = new BinaryReader(save))
                        {
                            bool fbclicked = reader.ReadBoolean();
                            reader.Close();
                            return fbclicked;
                        }
                    }
                }
                else return false;
            }
        }

        public static void SaveRateClicked(bool saved)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filePath_rateClicked, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(saved);
                        writer.Close();
                    }
                }
            }
        }

        public static bool LoadRateClicked()
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (storage.FileExists(filePath_rateClicked))
                {
                    using (IsolatedStorageFileStream save = new IsolatedStorageFileStream(filePath_rateClicked, FileMode.Open, storage))
                    {
                        using (BinaryReader reader = new BinaryReader(save))
                        {
                            bool rateclicked = reader.ReadBoolean(); 
                            reader.Close();
                            return rateclicked;
                        }
                    }
                }
                else return false;
            }
        }

        public static int LoadLevel()
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (storage.FileExists(filePath_level))
                {
                    using (IsolatedStorageFileStream save = new IsolatedStorageFileStream(filePath_level, FileMode.Open, storage))
                    {
                        using (BinaryReader reader = new BinaryReader(save))
                        {
                            int level = reader.ReadInt32();
                            reader.Close();
                            return level;
                        }
                    }
                }
                else return 1;
            }
        }

        public static void SaveLevel(int level)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filePath_level, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(level);
                        writer.Close();
                    }
                }
            }
        }

        public static int LoadSpinsRemaining()
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (storage.FileExists(filePath_spinsremaining))
                {
                    using (IsolatedStorageFileStream save = new IsolatedStorageFileStream(filePath_spinsremaining, FileMode.Open, storage))
                    {
                        using (BinaryReader reader = new BinaryReader(save))
                        {
                            int spins = reader.ReadInt32();
                            reader.Close();
                            return spins;
                        }
                    }
                }
                else return 0;
            }
        }

        public static void SaveSpinsRemaining(int spins)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filePath_spinsremaining, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(spins);
                        writer.Close();
                    }
                }
            }
        }

        public static void SaveMoney(long money)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filePath_money, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(money);
                        writer.Close();
                    }
                }
            }
        }

        public static long LoadMoney()
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (storage.FileExists(filePath_money))
                {
                    using (IsolatedStorageFileStream save = new IsolatedStorageFileStream(filePath_money, FileMode.Open, storage))
                    {
                        using (BinaryReader reader = new BinaryReader(save))
                        {
                            long myScore = reader.ReadInt32();
                            reader.Close();
                            return myScore;
                        }
                    }
                }
                else return 0;
            }
        }

        public static void SaveLoggedIn(bool loggedIn)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = storage.OpenFile(filePath_loggedin, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write(loggedIn);
                        writer.Close();
                    }
                }
            }
        }

        public static bool LoadIsLoggedIn()
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (storage.FileExists(filePath_loggedin))
                {
                    using (IsolatedStorageFileStream save = new IsolatedStorageFileStream(filePath_loggedin, FileMode.Open, storage))
                    {
                        using (BinaryReader reader = new BinaryReader(save))
                        {
                            bool loggedIn = reader.ReadBoolean();
                            reader.Close();
                            return loggedIn;
                        }
                    }
                }
                else return false;
            }
        }
    }
}
