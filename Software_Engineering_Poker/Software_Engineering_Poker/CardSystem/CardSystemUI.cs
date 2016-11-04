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
    public partial class CardSystemUI : UserControl
    {
        private CardSystemController mController;

        public CardSystemUI(CardSystemController controller)
        {
            mController = controller;
            InitializeComponent();

            //tableMoneyValue.Text = mController.TableMoneyValue + "$";
            tableMoneyValue.Text = MoneyModel.currentBid + "$";
        }
        

    }
}
