using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    class MoneyModel
    {
        private int _currentPlayerBalance;
        private int _currentAI1Balance;

        public int CurrentPlayerBalance
        {
            get
            {
                return _currentPlayerBalance;
            }

            set
            {
                _currentPlayerBalance = value;
            }
        }
    }
    }
}
