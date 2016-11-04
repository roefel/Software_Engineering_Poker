using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    class PointCalculator
    {
        int numCards;
        int[] cardNumbers;
        int[] cardTypes;

        public PointCalculator(string card1, string card2, string card3, string card4, string card5)
        {
            cardNumbers = new int[numCards];
            cardTypes = new int[numCards];   //0=hart 1=klaver 2=ruit 3=schop 
            numCards = 5;
        }
    }
}
