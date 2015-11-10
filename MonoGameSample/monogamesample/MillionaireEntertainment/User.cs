using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionaireEntertainment
{
    public static class User
    {
        static long coins;
        public static long Coins { get { return coins; } }

        static int level;
        public static int Level { get { return level; } }

        static int spins_remaining;
        public static int spinsRemaining { get { return spins_remaining; } }

        public static long OldAmount_coins;

        private const float TotalStatBarLength = 483;
        private static float statBarLength;
        public static float StatBarLength { get { return statBarLength; } }

        public static float OldAmount_stats; 

        private static float TotalSpins { get { return level * 5; } }

        public static bool FBClicked, RateClicked; 

        public static void SetCoins()
        {
            coins = IO.LoadMoney();

            //change this
            if (coins == 0)
                coins = 1000;

            OldAmount_coins = coins; 
        }

        public static void SetLevel()
        {
            level = IO.LoadLevel(); 
        }

        public static void SetSpinsRemaining()
        {
            spins_remaining = IO.LoadSpinsRemaining();
        }

        public static void increase_spins()
        {
            OldAmount_stats = statBarLength; 
            spins_remaining++;

            if (spins_remaining > TotalSpins)
            {
                increaseLevel(); 
            }

            float dividend = spins_remaining / TotalSpins; 
            statBarLength = (dividend * TotalStatBarLength); 
        }

        public static event EventHandler onIncreaseLevel; 
        private static void increaseLevel()
        {
            level++;
            spins_remaining = 1;

            OldAmount_stats = 0f; 

            if (onIncreaseLevel != null)
                onIncreaseLevel(null, EventArgs.Empty);  
        }

        public static void add_Coins(long amount)
        {
            OldAmount_coins = coins; 
            coins += amount; 
        }

        public static void subtract_Coins(long amount)
        {
            OldAmount_coins = coins; 
            coins -= amount; 
        }

        public static string ConvertToMoney(long amount)
        {
            return string.Format("{0:0#,#}", amount);
        }
    }
}
