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
        private ButtonContainerController buttonContainerController;
        //private GameManager.GameController gameController;
        GameManager.GameController gamecontroller = new GameManager.GameController();
        string backupText;

        public ButtonContainerUI(ButtonContainerController controller)
        {
            buttonContainerController = controller;
            InitializeComponent();
            raiseBtn.Enabled = false;
            raiseBtn.BackColor = System.Drawing.Color.LightGray;

            //allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)";
            allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$) \n zorgt voor error, turnSwitch in comment zetten";
            backupText = raiseBtn.Text;
        }

        private void raiseBtn_Click(object sender, EventArgs e)
        {
            //buttonContainerController.doeiets()
            buttonContainerController.toggleVast();
            raiseBtn.Text = raiseBtn.Text + " +" + buttonContainerController.ParseInt(raiseBidTxtBox.Text) + "$";

            //gameController.switchTurn();   
        }

        private void raiseBidTxtBox_TextChanged(object sender, EventArgs e)
        {
            buttonContainerController.checkRaise();
        }
      
        private void raiseBidTxtBox_Leave(object sender, EventArgs e)
        {
            buttonContainerController.checkRaise();
        }

        private void raiseBidLabel_Click(object sender, EventArgs e)
        {
            //buttonContainerController.doeiets()
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            buttonContainerController.toggleVast();
            //buttonContainerController.switchTurn();
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            buttonContainerController.toggleVast();
            //buttonContainerController.switchTurn();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            buttonContainerController.toggleVast();
            //buttonContainerController.switchTurn();
            gamecontroller.switchTurn();
        }

        private void unlockBtnTest_Click(object sender, EventArgs e)
        {
            unlockBtns();
        }

        //update de view
        //lock until the round is over
        public void lockBtns()
        {
            //if (gamecontroller.numPlayerTurn != 0)
            //{ 
                //raiseBtn.BackColor = (buttonContainerController.getVast) ? Color.LightGray : Color.LimeGreen; 
                //callBtn.BackColor = (buttonContainerController.getVast) ? Color.LightGray : Color.LightSeaGreen;
                //foldBtn.BackColor = (buttonContainerController.getVast) ? Color.LightGray : Color.Red;
                //allBtn.BackColor = (buttonContainerController.getVast) ? Color.LightGray : Color.LimeGreen;

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

                allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)";
            //}
        }

        //unlock at the start of a new round
        public void unlockBtns()
        {
            //if (gamecontroller.numPlayerTurn == 0)
            //{ 
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
                allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)" ;

                buttonContainerController.checkRaise();
            //}
        }
    }
}
