using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker.ComputerAI
{
    class ComputerAI
    {
        private static bool _folded;
        static PointCalculator calculator = new PointCalculator();



        public ComputerAI()
        {
            folded = false;
        }



        public static void aiTurnAlgorithm(int balance, int round)
        {
            Console.WriteLine("my turn");
            int points = calculator.calculatePoints( "hart_10", "h11", "h12", "h13", "h1", "r2", "h8"); //strings zouden vervangen worden door array van gedeelde kaarten
            if (folded || balance < MoneyModel.currentBid)
            {
                folded = true;
                //end turn
            }
            else
            {
                switch (round)  //volledig uitgewerkt zou ik ook nog rekening houden met eigen balance en de huidige inzet
                {
                    case 1: //ronde 1,geen kaarten gelegd. alleen 2 in de hand
                        if (points > 10)
                        {
                            //raise with 1.1 to 2 multiplier of current bid
                        }
                        else
                        {
                            //call
                        }
                        break;
                    case 2: //ronde 2, 3 kaarten gelegd
                        if (points > 49)
                        {
                            //raise with 1.1 to 2 multiplier of current bid
                        }
                        else
                        {
                            //call
                        }
                        break;
                    case 3: //ronde 3, 4 kaarten gelegd
                        if (points > 59)
                        {
                            //raise with 1.1 to 2 multiplier of current bid
                        }
                        else if(7 < points && points< 59)
                        {
                            //call
                        }
                        else
                        {
                            //fold
                        }
                        break;
                    case 4: //ronde 4, 5 kaarten gelegd
                        if (points > 79)
                        {
                            //raise with 2 to 4 multiplier of current bid
                        }
                        else if (69 < points)
                        {
                            //raise with 1.1 to 2 multiplier of current bid
                        }
                        else
                        {
                            //call
                        }
                        break;
                    default:
                            //end turn
                        break;

            }
            }

        }


        //
        //properties
        //

        public static bool folded
        {
            get
            {
                return _folded;
            }

            set
            {
                _folded = value;
            }
        }
    }
}
