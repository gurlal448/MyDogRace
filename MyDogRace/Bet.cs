﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDogRace
{
    class Bet
    {
        public int Amt; // Bet amount
        public int Dog; // bet places on dog
        public Guy Bettor; // guy who places the bet

        public string GetDescription()
        {

            if (this.Amt == 0)
            {// mean initially user does not have any bucks 
                return this.Bettor.Name + " hasn't placed any bet";
            }
            else
            {
                //return a string that say who placed the bet, how much cash was bet, and which dog he bet on. 
                //If amount is zero no bet is placed
                string desc = Bettor.Name + " bet $" + this.Amt + " on dog " + (this.Dog + 1);

                return desc;
            }
        }

        public int PayOut(int Winner)
        {
            //parameter is winner of race. if the dog won, return the amount bet
            //otherwise, return the negative of the amount bet
            if (Winner == this.Dog)
            {
                return this.Amt;
            }
            else
            {
                return -1 * this.Amt;
            }
        }
    }
}
