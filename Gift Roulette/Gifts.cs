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

        //win and loss count
        public int lossCount = 0, winCount = 0; 

        // This holds the random number (The Bomb)
        public int Bomb;

        public int randGen;

        /// <summary>
        /// // This generates the random number
        /// </summary>
        /// <returns></returns>
        public int RandomNumber() 
       {

           int randGen =0;
            Random myRandom = new Random();
            randGen = myRandom.Next(1, 7);
            return randGen;
            
        }
        
    }
}
