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
        public Bet MyBet = null; //An instance of Bet that has his bet
        public int Cash; //How much cash he has

        //The last two fields are the guys GUI controls on the form 
        public RadioButton MyRadioButton; //My Radiobutton
        public Label MyLabel; //MyLabel

        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyLabel.Text = Name + " hasn't placed a bet";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
           MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }
            
        
        public void ClearBet()
        {
            MyBet = null;
        }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this};
            if (Cash >= BetAmount)
            {
                MyLabel.Text = MyBet.description;
                this.UpdateLabels();
                return true;
            }
            else 
            {
                MessageBox.Show("You do not have enough money for this bet, please try again");
            }
            return false;
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }

    }
}
