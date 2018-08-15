using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Bet
    {
        public int Amount; //The amount of cash that was bet
        public int Dog; //The number of the dog the bet is on
        public Guy Bettor; //The guy who placed the bet
        public string description;

        public string GetDescription()
        {
            if (Amount > 0)
            {
                description = Bettor + " has bet " + Amount + " on " + Dog;
            }
            else
            {
                description = Bettor + " hasn't placed a bet";
            }
            return description;
        }
        public int PayOut(int Winner) {
            if (Dog == Winner)
            {
                return Amount;
            }
            else 
            {
                return -(Amount);
            }
        }
    }
}
