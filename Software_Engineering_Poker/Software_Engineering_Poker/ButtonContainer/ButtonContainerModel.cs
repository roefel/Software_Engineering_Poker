using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class ButtonContainerModel
    {
        //money van moneyclass nodig?
        //get van MoneyModel en dan plaatsen in de waardes hieronder
        private MoneyModel moneyModel;
        private int totalMoney;
        private int currentBid;

        private bool isVast;

        public ButtonContainerModel()
        {
            moneyModel = new MoneyModel();
            totalMoney = moneyModel.currentPlayerBalance;
            currentBid = moneyModel.currentBid;

            isVast = false;
            ////placeholder
            //totalMoney = 2000;
            //currentBid = 10;
        }

        // get en setter
        public int TotalMoney
        {
            get
            {
                return totalMoney;
            }

            set
            {
                totalMoney = value;
            }
        }

        public int CurrentBid
        {
            get
            {
                return currentBid;
            }

            set
            {
                currentBid = value;
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
