using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker
{
    public class TableContainerController
    {
        protected TableContainerUI tableUI;
        protected TableContainerModel tableModel;

        public TableContainerController()
        {
            //create table model
            tableModel = new TableContainerModel();

            tableUI = new TableContainerUI(this);
        }

        //return instance of the view
        public TableContainerUI view
        {
            get
            {
                return tableUI;
            }
        }
    }
}
