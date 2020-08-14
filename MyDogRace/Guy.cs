using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDogRace
{
    class Guy : Punter
    {
        public string Name;
        public int Money;
        public Bet Bet;

        //guy's gui controls
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            //set the label to my bet's description and label on radio button to show money
            MyLabel.Text = this.Bet.GetDescription();//"Bets $"+Bet.Amount + " on dog " + (Bet.Dog +1);
        }

       

        //Set the Max limit for bucks to spend = 15
        public bool IsExceedBetLimit(int amount)
        {
            if (amount > 15 && amount > 5)
                return true;

            return false;
        }
        public override bool PlaceBet(int betAmt, int winnerDog)
        {
            //Place a new bet and store it
            //return true if guy had enough money to bet
            if (this.Money > betAmt)
            {
                if (IsExceedBetLimit(betAmt))
                {
                    MessageBox.Show("You can not spend more than $15 on dog.", "DOG RACE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    Bet = new Bet()
                    {
                        Amount = betAmt,
                        Dog = winnerDog,
                        Bettor = this//Amount = numBets.Value, Bettor = Name, Dog = numDog.Value -1
                    };
                }
                UpdateLabels();

                //Console.WriteLine(this.Name + " had enough to bet");
                return true;
            }
            else
            {
                Console.WriteLine(this.Name + " did not have enough Amount to Bet");
                return false;
            }
        }

        
    }
}
