using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    class ComputerAIModel
    {
        private string[] _cardsAI1;
        //private string[] _cardsAI2;
        //private string[] _cardsAI3;

        public ComputerAIModel()
        {
            cardsAI1 = new string[5];
        }

        public string[] cardsAI1
        {
            get
            {
                return _cardsAI1;
            }

            set
            {
                _cardsAI1 = value;
            }
        }
    }
}
