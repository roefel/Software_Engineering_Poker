using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Poker
{
    public partial class ButtonUI : UserControl
    {
        private ButtonController mController;

        public ButtonUI(ButtonController controller)
        {
            mController = controller;
            InitializeComponent();
        }


        private void raiseBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
        }

        private void bidRaiseTxtBox_TextChanged(object sender, EventArgs e)
        {
            //mController.doeiets()
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
        }

        private void raiseBidLabel_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
        }
    }
}
