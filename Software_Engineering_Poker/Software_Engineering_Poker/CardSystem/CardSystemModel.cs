using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class CardSystemModel
    {
        protected int mtableMoneyValue;
        protected Boolean mIsFixed;

        public CardSystemModel()
        {
            mtableMoneyValue = 0;
            mIsFixed = false;
        }

        public int TableMoneyValue
        {
            get
            {
                return mtableMoneyValue;
            }
            set
            {
                mtableMoneyValue = value;
            }
        }
    }
}
