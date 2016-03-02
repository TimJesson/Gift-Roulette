using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift_Roulette
{
    public class Gifts
    {
        
        public int count = 0, clickCounter = 2;

        public int lossCount = 0, winCount = 0;

        
        public int Bomb; // This holds the random number (The Bomb)
        public int randGen;

        public int RandomNumber() // This method generates the random number
       {

           int randGen =0;
            Random myRandom = new Random();
            randGen = myRandom.Next(1, 7);
            return randGen;
            
        }
        
    }
}
