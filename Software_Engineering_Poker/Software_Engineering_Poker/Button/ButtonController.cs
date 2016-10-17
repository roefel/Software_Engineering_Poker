using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class ButtonController
    {
        protected ButtonUI buttonUI;
        protected ButtonModel buttonModel;

        public ButtonController()
        {
            //create button model
            buttonModel = new ButtonModel();

            buttonUI = new ButtonUI(this);
        }

        //return instance of the view
        public ButtonUI view
        {
            get
            {
                return buttonUI;
            }
        }

        // Draai de 'isVast' waarde om wanneer er geklikt wordt
        public void toggleVast()
        {
            // Zeg tegen het model dat de teerling isVast waarde moet omgedraaid worden
            buttonModel.toggleVast();

            //lock buttons until next round
            view.lockBtns();
        }

        //Return de waarde die checkt of het vast staat of niet
        public bool getVast
        {
            get
            {
                return buttonModel.getVast;
            }
        }

        public int TotalMoney
        {
            get
            {
                return buttonModel.TotalMoney;
            }
        }

        public int CurrentBid
        {
            get
            {
                return buttonModel.CurrentBid;
            }
        }
    }
}
