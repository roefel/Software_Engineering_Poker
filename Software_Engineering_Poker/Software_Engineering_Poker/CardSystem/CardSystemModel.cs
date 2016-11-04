using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class CardSystemModel
    {
        //private MoneyModel moneyModel;
        private int mtableMoneyValue;
        private int mtableMoneyBid;
        protected Boolean mIsFixed;

        public CardSystemModel()
        {
            //moneyModel = new MoneyModel();
            mtableMoneyBid = MoneyModel.currentBid;
            mtableMoneyValue = 1000;
            //mtableMoneyValue = 0;
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

        public int TableMoneyBid
        {
            get
            {
                return mtableMoneyBid;
            }
            set
            {
                mtableMoneyBid = value;
            }
        }
    }
}
