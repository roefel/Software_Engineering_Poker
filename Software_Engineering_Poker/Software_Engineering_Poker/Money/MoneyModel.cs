using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class MoneyModel
    {
        private static int _currentBid;
        private int _currentPlayerBalance;
        private static int[] _aiBalance = new int[1];


        public MoneyModel()
        {
            aiBalance[0] = 100;
            currentPlayerBalance = 100;
            currentBid = 10;
        }

        public static int currentBid
        {
            get
            {
                return _currentBid;
            }

            set
            {
                _currentBid = value;
            }
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

        public static int[] aiBalance
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
