using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class ButtonContainerController
    {
        protected ButtonContainerUI buttonContainerUI;
        protected ButtonContainerModel buttonContainerModel;
        //GameManager.GameController gameController;
        MoneyModel moneyModel;
        CardSystemController cardSystemController;

        public ButtonContainerController()
        {
            //create ButtonContainer model
            buttonContainerModel = new ButtonContainerModel();

            buttonContainerUI = new ButtonContainerUI(this);

            cardSystemController = new CardSystemController();

            moneyModel = new MoneyModel();
        }

        //return instance of the view
        public ButtonContainerUI view
        {
            get
            {
                return buttonContainerUI;
            }
        }

        // Draai de 'isVast' waarde om wanneer er geklikt wordt
        public void toggleVast()
        {
            // Zeg tegen het model dat de waarde moet omgedraaid worden
            buttonContainerModel.toggleVast();

            //lock ButtonContainers until next round
            view.lockBtns();
        }

        //check en update de raise Button door te kijken naar de value van de textbox
        public void checkRaise()
        {
            if ((ParseInt(buttonContainerUI.raiseBidTxtBox.Text) > 0) && (TotalMoney > (ParseInt(buttonContainerUI.raiseBidTxtBox.Text) + CurrentBid )) && (ParseInt(buttonContainerUI.raiseBidTxtBox.Text)<= TotalMoney) && (TotalMoney > CurrentBid))
            {
                buttonContainerUI.raiseBtn.BackColor = System.Drawing.Color.LimeGreen;
                buttonContainerUI.raiseBtn.Enabled = true;
            }

            else
            {
                buttonContainerUI.raiseBtn.BackColor = System.Drawing.Color.LightGray;
                buttonContainerUI.raiseBtn.Enabled = false;
            }

        }

        public void checkCall()
        {
            if (TotalMoney > CurrentBid)
            {
                buttonContainerUI.callBtn.BackColor = System.Drawing.Color.LightSeaGreen;
                buttonContainerUI.callBtn.Enabled = true;
                buttonContainerUI.callBtn.Text = "Call\n" + "(" + CurrentBid + "$)";
            }

            else
            {
                buttonContainerUI.callBtn.BackColor = System.Drawing.Color.LightGray;
                buttonContainerUI.callBtn.Enabled = false;
                buttonContainerUI.callBtn.Text = "Call\n" + "(" + CurrentBid + "$)";
            }
        }

        public void checkFold()
        {
            buttonContainerUI.foldBtn.BackColor = System.Drawing.Color.Red;
            buttonContainerUI.foldBtn.Enabled = true;
        }

        public void checkAllIn()
        {
            if (TotalMoney > 0 && TotalMoney >= CurrentBid)
            {
                buttonContainerUI.allBtn.BackColor = System.Drawing.Color.LimeGreen;
                buttonContainerUI.allBtn.Enabled = true;
                buttonContainerUI.allBtn.Text = "All-In\n\n" + "(" + TotalMoney + "$)";
            }

            else
            {
                buttonContainerUI.allBtn.BackColor = System.Drawing.Color.LightGray;
                buttonContainerUI.allBtn.Enabled = false;
                buttonContainerUI.allBtn.Text = "All-In\n\n" + "(" + TotalMoney + "$)";
            }
        }

        public void raiseBet()
        {
            if ((ParseInt(buttonContainerUI.raiseBidTxtBox.Text) > 0) && (ParseInt(buttonContainerUI.raiseBidTxtBox.Text) <= TotalMoney))
            {
                TotalMoney = TotalMoney - CurrentBid - (ParseInt(buttonContainerUI.raiseBidTxtBox.Text));
                CurrentBid = CurrentBid + (ParseInt(buttonContainerUI.raiseBidTxtBox.Text));
            }
            moneyModel.currentPlayerBalance = TotalMoney;

            //input new value into Model currentBid
            MoneyModel.currentBid = CurrentBid;

            //update table's currentbid
            cardSystemController.UpdateTableTxt();
            Console.WriteLine("playerbalance= " + TotalMoney);
        }

        public void callBet()
        {
            TotalMoney = TotalMoney - CurrentBid;
            moneyModel.currentPlayerBalance = TotalMoney;

            //input new value into Model currentBid
            MoneyModel.currentBid = CurrentBid;

            //update table's currentbid
            cardSystemController.UpdateTableTxt();
            Console.WriteLine("playerbalance= " + TotalMoney);

            //cardSystemController.TableMoneyValue = TotalMoney;
            //cardSystemUI.tableMoneyValue.Text = TotalMoney + "$";
        }

        public void foldBet()
        {
            moneyModel.currentPlayerBalance = TotalMoney;
            MoneyModel.currentBid = CurrentBid;
        }

        public void allInBet()
        {
            CurrentBid = TotalMoney;
            TotalMoney = 0;
            moneyModel.currentPlayerBalance = TotalMoney;
            MoneyModel.currentBid = CurrentBid;
            cardSystemController.UpdateTableTxt();
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
                return buttonContainerModel.getVast;
            }
        }
        
        public int TotalMoney
        {
            get
            {
                return buttonContainerModel.TotalMoney;
            }

            set
            {
                buttonContainerModel.TotalMoney = value;
            }
        }

        public int CurrentBid
        {
            get
            {
                return buttonContainerModel.CurrentBid;
            }

            set
            {
                buttonContainerModel.CurrentBid = value;
            }
        }

        ////switch turn
        //public void switchTurn()
        //{
        //    gameController.switchTurn();
        //}
    }
}
