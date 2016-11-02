using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class MoneyModel
    {
        private int _currentPlayerBalance = 1000;
        private int[] _aiBalance = new int[1];


        public MoneyModel()
        {
            aiBalance[0] = 50;
        }

        public int currentPlayerBalance
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

        public int[] aiBalance
        {
            get
            {
                return _aiBalance;
            }

            set
            {
                _aiBalance = value;
            }
        }
    }
}
