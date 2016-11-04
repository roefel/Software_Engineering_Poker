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
        static MoneyModel moneyModel;

        public ComputerAI()
        {
            folded = false;
            moneyModel = MoneyController.moneyModel;
        }



        public static void aiTurnAlgorithm(int balance, int round)
        {
            Console.WriteLine("my turn");
            if (folded || balance < moneyModel.currentBid)
            {
                folded = true;
                //end turn
            }
            else
            {
                switch (round)
                {
                    case 1: //ronde 1,geen kaarten gelegd. alleen 2 in de hand

                        break;
                    case 2: //ronde 2, 3 kaarten gelegd

                        break;
                    case 3: //ronde 3, 4 kaarten gelegd

                        break;
                    case 4: //ronde 4, 5 kaarten gelegd

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
