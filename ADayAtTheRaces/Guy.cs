using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Guy
    {
        public string Name; //The guy's name
        public Bet MyBet; //An instance of Bet that has his bet
        public int Cash; //How much cash he has

        //The last two fields are the guys GUI controls on the form 
        public RadioButton MyRadioButton; //My Radiobutton
        public Label MyLabel; //MyLabel

        public void UpdateLabels()
        {
            MyLabel = MyBet;
            MyRadioButton.Text = "Joe has " + Cash + "bucks";
        }
        public void ClearBet()
        {
            MyBet = 0;
        }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {

        }
    }
}
