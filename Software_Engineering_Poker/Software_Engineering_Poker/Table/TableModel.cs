using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker.Table
{
    public class TableModel
    {
        protected int mtableMoneyValue;
        protected Boolean mIsFixed;

        public TableModel()
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
