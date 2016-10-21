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
    public partial class ButtonContainerUI : UserControl
    {
        private ButtonContainerController mController;
        string backupText;

        public ButtonContainerUI(ButtonContainerController controller)
        {
            mController = controller;
            InitializeComponent();
            raiseBtn.Enabled = false;
            raiseBtn.BackColor = System.Drawing.Color.LightGray;

            backupText = raiseBtn.Text;
        }

        private void raiseBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
            //raiseBtn.Enabled = false;
            mController.toggleVast();
            //raiseBtn.Text = raiseBtn.Text + " " + mController.CurrentBid.ToString() + " + " + raiseBidTxtBox.Text;
            raiseBtn.Text = raiseBtn.Text + " +" + mController.ParseInt(raiseBidTxtBox.Text) + "$";
            
        }

        private void raiseBidTxtBox_TextChanged(object sender, EventArgs e)
        {
            //mController.doeiets()
            //mController.toggleVast();

            mController.checkRaise();
        }
      
        private void raiseBidTxtBox_Leave(object sender, EventArgs e)
        {
            //Do your stuff
            //mController.toggleVast();

            mController.checkRaise();
        }

        private void raiseBidLabel_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
            mController.toggleVast();
            //callBtn.Enabled = false;
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
            mController.toggleVast();
            //foldBtn.Enabled = false;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            //mController.doeiets()
            mController.toggleVast();
            //allBtn.Enabled = false;
            //allBtn.Text = allBtn.Text + mController.TotalMoney.ToString() + " $";
        }

        private void unlockBtnTest_Click(object sender, EventArgs e)
        {
            unlockBtns();
        }

        //update de view
        //lock until the round is over
        public void lockBtns()
        {
            //raiseBtn.BackColor = (mController.getVast) ? Color.LightGray : Color.LimeGreen; 
            //callBtn.BackColor = (mController.getVast) ? Color.LightGray : Color.LightSeaGreen;
            //foldBtn.BackColor = (mController.getVast) ? Color.LightGray : Color.Red;
            //allBtn.BackColor = (mController.getVast) ? Color.LightGray : Color.LimeGreen;

            raiseBtn.BackColor = System.Drawing.Color.LightGray;
            callBtn.BackColor = System.Drawing.Color.LightGray;
            foldBtn.BackColor = System.Drawing.Color.LightGray;
            allBtn.BackColor = System.Drawing.Color.LightGray;
            //raiseBidTxtBox.BackColor = System.Drawing.Color.LightGray;

            raiseBtn.Enabled = false;
            callBtn.Enabled = false;
            foldBtn.Enabled = false;
            allBtn.Enabled = false;
            raiseBidTxtBox.Enabled = false;
        }

        //unlock at the start of a new round
        public void unlockBtns()
        {
            //raiseBtn.Enabled = true;
            callBtn.Enabled = true;
            foldBtn.Enabled = true;
            allBtn.Enabled = true;
            raiseBidTxtBox.Enabled = true;

            //raiseBtn.BackColor = System.Drawing.Color.LimeGreen;
            callBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            foldBtn.BackColor = System.Drawing.Color.Red;
            allBtn.BackColor = System.Drawing.Color.LimeGreen;

            raiseBtn.Text = backupText;

            mController.checkRaise();
        }
    }
}
