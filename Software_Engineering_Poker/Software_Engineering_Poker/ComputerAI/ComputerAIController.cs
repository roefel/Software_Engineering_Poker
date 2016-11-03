﻿using System;
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
        

        public ComputerAIController()
        {
            computerAI = new ComputerAI();
            aiNumberTurn = 0;
        }

        public static void startTurn()
        {
            Console.WriteLine("aiNumberTurn= " + aiNumberTurn);
            ComputerAI.aiTurnAlgorithm(MoneyModel.aiBalance[aiNumberTurn]);
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
    }
}
