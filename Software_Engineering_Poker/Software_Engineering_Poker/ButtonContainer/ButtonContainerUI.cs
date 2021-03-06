﻿using System;
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
        GameController gamecontroller =  Program.controller;
        string backupText;

        public ButtonContainerUI(ButtonContainerController controller)
        {
            buttonContainerController = controller;
            InitializeComponent();
            raiseBtn.Enabled = false;
            raiseBtn.BackColor = System.Drawing.Color.LightGray;

            allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)";
            callBtn.Text = "Call\n" + "(" + buttonContainerController.CurrentBid + "$)";
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
            buttonContainerController.raiseBet();
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
            buttonContainerController.checkRaise();

        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            buttonContainerController.checkCall();
            buttonContainerController.callBet();
            buttonContainerController.toggleVast();
            gamecontroller.switchTurn();
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            buttonContainerController.foldBet();
            buttonContainerController.toggleVast();
            gamecontroller.switchTurn();
            //gamecontroller.endTurn();
            //gamecontroller.endMatch();

        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            //if (gamecontroller.numPlayerTurn != 0){}
            buttonContainerController.allInBet();
            buttonContainerController.toggleVast();
            gamecontroller.switchTurn();
            //gamecontroller.endTurn();
        }

        private void unlockBtnTest_Click(object sender, EventArgs e)
        {
            //gamecontroller.numPlayerTurn = 0;
            unlockBtns();
        }

        //update de view
        //lock until the round is over
        public void lockBtns()
        {            
            raiseBtn.BackColor = System.Drawing.Color.LightGray;
            callBtn.BackColor = System.Drawing.Color.LightGray;
            foldBtn.BackColor = System.Drawing.Color.LightGray;
            allBtn.BackColor = System.Drawing.Color.LightGray;

            raiseBtn.Enabled = false;
            callBtn.Enabled = false;
            foldBtn.Enabled = false;
            allBtn.Enabled = false;
            raiseBidTxtBox.Enabled = false;

            callBtn.Text = "Call\n" + "(" + buttonContainerController.CurrentBid + "$)";
            allBtn.Text = "All-In\n\n" + "(" + buttonContainerController.TotalMoney + "$)";
        }

        //unlock at the start of a new round
        // if (gamecontroller.numPlayerTurn == 0)
        public void unlockBtns()
        {
            raiseBidTxtBox.Enabled = true;
            raiseBtn.Text = backupText;

            buttonContainerController.checkRaise();
            buttonContainerController.checkCall();
            buttonContainerController.checkFold();
            buttonContainerController.checkAllIn();
        }
    }
}
