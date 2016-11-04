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
        protected Boolean mIsFixed;

        public CardSystemModel()
        {
            //moneyModel = new MoneyModel();
            mtableMoneyValue = MoneyModel.currentBid;
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
    }
}
