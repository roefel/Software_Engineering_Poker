using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class TableContainerModel
    {
        protected int mtableMoneyValue;
        protected Boolean mIsFixed;

        public TableContainerModel()
        {
            mtableMoneyValue = 0;
            mIsFixed = false;
        }

        public int value
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
