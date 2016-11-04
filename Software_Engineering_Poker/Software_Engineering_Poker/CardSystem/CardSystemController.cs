using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (cardsInUse.Count == 52)
            {
                Console.WriteLine("There were " + cardsInUse.Count + " different random cards generated so far");
                Console.WriteLine("Generated card: " + card);
                Console.WriteLine("Max amount of different cards generated. Reshuffling the deck");
                cardsInUse.Clear();
            }
            else
            {
                Console.WriteLine("There were " + cardsInUse.Count + " different random cards generated so far");
                Console.WriteLine("Generated card: " + card);
            }
            
            //cardSystemUI.dealerCard2.Image = Properties.Resources.hart_10;
            //return card;

            //De 2 bovenstaande lijnen code werkten nog niet vanwege het gebrek aan kennis van windows Forms
        }

        public void UpdateTableTxt()
        {
            cardSystemUI.currentBidLabel.Text = "currentBid:" + MoneyModel.currentBid + "$";
            cardSystemUI.tableMoneyValue.Text = MoneyModel.tableMoney + "$";
        }

        public int TableMoneyValue
        {
            get
            {
                return tableModel.TableMoneyValue;
            }

            set
            {
                tableModel.TableMoneyValue = value;
            }
        }

        public int TableMoneyBid
        {
            get
            {
                return tableModel.TableMoneyBid;
            }

            set
            {
                tableModel.TableMoneyBid = value;
            }
        }
    }
}
