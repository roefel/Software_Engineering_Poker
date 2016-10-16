using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class ButtonModel
    {
        //money van moneyclass nodig?
        private int totalMoney;
        private int currentBid;
        private bool isVast;

        public ButtonModel()
        {
            //placeholder
            isVast = false;
            totalMoney = 2000;
            currentBid = 500;
        }

        //get en setter nodig?

        public int TotalMoney
        {
            get
            {
                return totalMoney;
            }
        }

        public int CurrentBid
        {
            get
            {
                return currentBid;
            }
        }

      // isVast veranderen naar niet vast
        public void toggleVast()
        {
            isVast = !isVast;
        }

        //isVast waarde getter
        public bool getVast
        {
            get
            {
                return isVast;
            }
        }
    }
}
