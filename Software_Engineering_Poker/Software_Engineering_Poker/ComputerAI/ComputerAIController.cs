using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker.ComputerAI
{
    class ComputerAIController
    {
        static ComputerAI computerAI;
        private static int _aiNumberTurn;
        private static int _roundNumber;

        public ComputerAIController()
        {
            computerAI = new ComputerAI();
            aiNumberTurn = 0;
            roundNumber = 1;
        }

        public static void startTurn()
        {
            Console.WriteLine("aiNumberTurn= " + aiNumberTurn);
            ComputerAI.aiTurnAlgorithm(MoneyModel.aiBalance[aiNumberTurn], roundNumber );
        }

        public static int aiNumberTurn
        {
            get
            {
                return _aiNumberTurn;
            }

            set
            {
                _aiNumberTurn = value;
            }
        }

        public static int roundNumber
        {
            get
            {
                return _roundNumber;
            }

            set
            {
                _roundNumber = value;
            }
        }
    }
}
