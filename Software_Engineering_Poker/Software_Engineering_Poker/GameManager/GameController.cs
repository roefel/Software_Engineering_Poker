using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Poker.GameManager
{
    class GameController
    {
        private int _amountOfPlayers;  //constant number of amount of players/NPCs in the game
        bool[] playerTurn;     //array to indicate which player's turn it is. [0] is the player, [1] 1sth NPC and so on..     
        private int _numPlayerTurn;      //number to 'save' which player's turn it is.
        private int _firstTurn;
        private bool _isFirstTurn;
        //ComputerAI.ComputerAIController computerAI;
        Random rnd = new Random();


        void gameController()      //constructor
        {

            amountOfPlayers = 2;
            firstTurn = rnd.Next(amountOfPlayers);
            playerTurn = new bool[amountOfPlayers];
            numPlayerTurn = firstTurn;
            startFirstTurn();
        }

        //method start() excecutes at the start of the application
        public void Start()
        {
            isFirstTurn = true;
            gameController();
            isFirstTurn = false;
        }
        // method to switch the turn to the next player
        public void switchTurn()
        {
            playerTurn[numPlayerTurn] = false;
            numPlayerTurn++;
            if (numPlayerTurn == amountOfPlayers)
            {
                numPlayerTurn = 0;
            }
            playerTurn[numPlayerTurn] = true;

            if (numPlayerTurn != 0)
            {

            }
        }

        void startFirstTurn()
        {
            for (int i = 0; i < amountOfPlayers; i++)   //to ensure that everything is set to false
            {
                playerTurn[i] = false;
            }
            playerTurn[numPlayerTurn] = true; //sets the first players turn to true
        }

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

        public int amountOfPlayers
        {
            get
            {
                return _amountOfPlayers;
            }

            set
            {
                _amountOfPlayers = value;
            }
        }

        public int firstTurn
        {
            get
            {
                return _firstTurn;
            }

            set
            {
                _firstTurn = value;
            }
        }

        public bool isFirstTurn
        {
            get
            {
                return _isFirstTurn;
            }

            set
            {
                _isFirstTurn = value;
            }
        }
    }
}
