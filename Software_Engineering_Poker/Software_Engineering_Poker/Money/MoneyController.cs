﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class MoneyController
    {
        protected MoneyUI moneyUI;

        public static MoneyModel moneyModel;
        public MoneyController()
        {
            //create money model
            moneyModel = new MoneyModel();

            moneyUI = new MoneyUI(this);
        }
        //public int calculateBalance(int currentBalance)
        //{
        //    int amountBid = 50;
        //    int newBalance = currentBalance - amountBid;
        //    return newBalance;
        //}

        public int currentPlayerBalance
        {
            get
            {
                return moneyModel.currentPlayerBalance;
            }

            set
            {
                moneyModel.currentPlayerBalance = value;
            }
        }

        public MoneyUI view
        {
            get
            {
                return moneyUI;
            }

            
        }
    }
}
