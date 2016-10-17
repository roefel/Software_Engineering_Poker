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
    public partial class MoneyUI : UserControl
    {
        private MoneyController MoneyController;
        //private MoneyModel moneyModel;

        public MoneyUI(MoneyController _moneyController)

        {
            MoneyController = _moneyController;
            InitializeComponent();
        }

        //private void updateMoney()
        //{
        //    int NewBalance = MoneyController.calculateBalance(moneyModel.CurrentPlayerBalance);

        //}

        //private void playerMoneyLabel_Click(object sender, EventArgs e)
        //{
        //    updateMoney();
        //}
    }
}
