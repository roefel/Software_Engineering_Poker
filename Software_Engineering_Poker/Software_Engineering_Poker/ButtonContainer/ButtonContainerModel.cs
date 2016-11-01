using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class ButtonContainerModel
    {

        private MoneyModel moneyModel;
        //private TableContainerModel tableContainerModel;

        //money van moneyclass nodig?
        //get van MoneyModel en dan plaatsen in de waardes hieronder?
        private int totalMoney;
        private int currentBid;
        private bool isVast;

        public ButtonContainerModel()
        {
            //placeholder
            isVast = false;
            totalMoney = 2000;
            currentBid = 500;
        }

        //placeholder
        // get en setter nodig?

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

        // van moneymodel
        public int CurrentPlayerBalance
        {
            get
            {
                return moneyModel.CurrentPlayerBalance;
            }
            set
            {
                moneyModel.CurrentPlayerBalance = value;
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
