using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class ButtonContainerController
    {
        protected ButtonContainerUI ButtonContainerUI;
        protected ButtonContainerModel ButtonContainerModel;

        public ButtonContainerController()
        {
            //create ButtonContainer model
            ButtonContainerModel = new ButtonContainerModel();

            ButtonContainerUI = new ButtonContainerUI(this);
        }

        //return instance of the view
        public ButtonContainerUI view
        {
            get
            {
                return ButtonContainerUI;
            }
        }

        // Draai de 'isVast' waarde om wanneer er geklikt wordt
        public void toggleVast()
        {
            // Zeg tegen het model dat de teerling isVast waarde moet omgedraaid worden
            ButtonContainerModel.toggleVast();

            //lock ButtonContainers until next round
            view.lockBtns();
        }

        //Return de waarde die checkt of het vast staat of niet
        public bool getVast
        {
            get
            {
                return ButtonContainerModel.getVast;
            }
        }

        public int TotalMoney
        {
            get
            {
                return ButtonContainerModel.TotalMoney;
            }
        }

        public int CurrentBid
        {
            get
            {
                return ButtonContainerModel.CurrentBid;
            }
        }
    }
}
