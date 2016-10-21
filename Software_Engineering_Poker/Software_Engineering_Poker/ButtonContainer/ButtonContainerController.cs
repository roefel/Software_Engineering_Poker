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

        //check en update de raise Button door te kijken naar de value van de textbox
        public void checkRaise()
        {
            if (ParseInt(ButtonContainerUI.raiseBidTxtBox.Text) > 0)
            {
                ButtonContainerUI.raiseBtn.BackColor = System.Drawing.Color.LimeGreen;
                ButtonContainerUI.raiseBtn.Enabled = true;
            }

            else
            {
                ButtonContainerUI.raiseBtn.BackColor = System.Drawing.Color.LightGray;
                ButtonContainerUI.raiseBtn.Enabled = false;
            }

        }

        //string input naar int
        public int ParseInt(string value)
        {
            int result = 0;

            if (int.TryParse(value, out result)) return result;

            else return 0;
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
