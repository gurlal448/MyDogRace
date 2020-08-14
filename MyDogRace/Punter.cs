using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDogRace
{
    // This is the abstract class and we have declared a method PlaceBet() to place bet on dog
    abstract class Punter
    {
        // Place Bet on dog with BetAmount
        public abstract bool PlaceBet(int betAmt, int winnerDog);
    }
}
