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
    public partial class TableContainerUI : UserControl
    {
        private TableContainerController mController;

        public TableContainerUI(TableContainerController controller)
        {
            mController = controller;
            InitializeComponent();
        }
        

    }
}
