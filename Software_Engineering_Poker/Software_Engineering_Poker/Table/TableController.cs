using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class TableController
    {
        protected TableUI tableUI;
        protected TableModel tableModel;

        public TableController()
        {
            //create table model
            tableModel = new TableModel();

            tableUI = new TableUI(this);
        }

        //return instance of the view
        public TableUI view
        {
            get
            {
                return tableUI;
            }
        }
    }
}
