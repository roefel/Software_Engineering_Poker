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

            allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)";
            backupText = raiseBtn.Text;

            // if it's not the player's turn when the game starts, lock the buttons
            // it's the player's turn when numPlayerTurn == 0
            if (gamecontroller.numPlayerTurn != 0)
            {
                lockBtns();
            }
        }

        private void raiseBtn_Click(object sender, EventArgs e)
        {
            //buttonContainerController.doeiets()
            buttonContainerController.toggleVast();
            raiseBtn.Text = raiseBtn.Text + " +" + buttonContainerController.ParseInt(raiseBidTxtBox.Text) + "$";

            gamecontroller.switchTurn();
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
            gamecontroller.switchTurn();
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            buttonContainerController.toggleVast();
            gamecontroller.switchTurn();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            //if (gamecontroller.numPlayerTurn != 0){}
            buttonContainerController.toggleVast();
            gamecontroller.switchTurn();
        }

        private void unlockBtnTest_Click(object sender, EventArgs e)
        {
            gamecontroller.numPlayerTurn = 0;
            unlockBtns();
        }

        //update de view
        //lock until the round is over
        public void lockBtns()
        {            
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
        }

        //unlock at the start of a new round
        // if (gamecontroller.numPlayerTurn == 0)
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
                allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)" ;

                buttonContainerController.checkRaise();
        }
    }
}
