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
    }
}
