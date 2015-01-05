using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoardBuilders
{
    class Game
    {
        //all game elements
        private Field[,] board;
        private Random rand;
        private int[] boardsize;
        private List<Player> players= new List<Player>();
        private int activePlayer;
        private int turn = 0;
        public static int MAXBUILDINGSIZE = 31;
       

        public Game(int[] sizes, List<string> newPlayers)
        {
            
            foreach (string name in newPlayers) //create player list from names
            {
                players.Add(new Player(name));
            }

            boardsize = sizes; //set boardsize
            generateBoard(); //generate board
        }   

        //randomly fill board with Fields
        void generateBoard()
        {

            rand = new Random(); //init random object
            board = new Field[boardsize[0],boardsize[1]];
            for (int posX = 0; posX < boardsize[0]; posX++)
            {
                for (int posY = 0; posY < boardsize[1]; posY++)
                    board[posX,posY] = new Field(rand.Next(1,5));
            }
        }
        
        //return field at position x,y
        public Field getField(int x, int y)
        {
            return board[x, y];
        }

        //return currently active player
        public Player getActivePlayer()
        {
            return players.ElementAt<Player>(activePlayer);
        }

        //get boardsize
        public int[] getBoardSize()
        {
            return boardsize;
        }

        //get turn
        public int getTurn()
        {
            return turn;
        }

        public void startGame()
        {
            activePlayer = rand.Next(0, players.Count()); // set random start player
            players.ElementAt(activePlayer).startTurn(); //start players turn
        }

        public void endTurn()
        {
            players.ElementAt(activePlayer).endTurn(); //end active players turn
            activePlayer = ++activePlayer % players.Count(); //circle through list
            players.ElementAt(activePlayer).startTurn(); //start next active players turn
            turn++; //increment turn counter
        }

        //destroy building at position x,y
        public void destroy(int x_pos, int y_pos)
        {
            players.ElementAt(activePlayer).removeBuilding(board[x_pos, y_pos].building); //remove building from players buildings
            board[x_pos, y_pos].building = new Building(); //remove Building from board         

        }

        //repair building at position x,y
        public bool repair(int x_pos, int y_pos)
        {
            if (players.ElementAt(activePlayer).pay( board[x_pos, y_pos].building.getRepairCost() ))//check if repair can be paid
            {
                board[x_pos, y_pos].building.repair(); // if so repair
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
