﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class CardSystemController
    {
        protected CardSystemUI cardSystemUI;
        protected CardSystemModel tableModel;
        public string[] cards = { "hart_", "schop_", "klaver_", "ruit_" };
        public List<string> cardsInUse = new List<string>();

        public Bitmap test = Software_Engineering_Poker.Properties.Resources.hart_11;
        string startupPath = Environment.CurrentDirectory;

        public CardSystemController()
        {
            //create tableContainer model
            tableModel = new CardSystemModel();

            cardSystemUI = new CardSystemUI(this);
        }

        //return instance of the view
        public CardSystemUI view
        {
            get
            {
                return cardSystemUI;
            }
        }

        public void RandomCard() //Returns a string (a random card) and puts it in a list so it can not be generated again
        {
            Random rnd = new Random();
            string card;
            do
            {
                card = cards[rnd.Next(0, cards.Length)] + rnd.Next(1, 14);
            }
            while (cardsInUse.Contains(card));
            cardsInUse.Add(card);
            Console.WriteLine(card);
            Console.WriteLine(cardsInUse.Count);
            Console.WriteLine(startupPath);
            Console.ReadKey();
            //cardSystemUI.dealerCard3.Image
            cardSystemUI.Refresh();

            //return card;
        }
    }
}
