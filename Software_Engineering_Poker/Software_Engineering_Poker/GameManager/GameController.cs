using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker.GameManager
{
    class GameController
    {
        //array to indicate which player's turn it is. [0] is the player, [1] 1sth NPC and so on..
        bool[] playerTurn = new bool[2];
        //number to 'save' which player's turn it is.
        private int _numPlayerTurn;

        public int numPlayerTurn
        {
            get
            {
                return numPlayerTurn;
            }

            set
            {
                numPlayerTurn = value;
            }
        }

        public void gameController()
        {
            numPlayerTurn = 0;
            playerTurn[numPlayerTurn] = true;
            playerTurn[numPlayerTurn+1] = false;

        }

        //method start() excecutes at the start of the application
        public void Start()
        {
            gameController();
        }
    }
}
