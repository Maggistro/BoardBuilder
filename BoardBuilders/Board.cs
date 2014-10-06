using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoardBuilders
{
    class Board
    {
        private Field[,] board;
        private Random rand;
        public int[] boardsize;
       

        public Board(int[] sizes){
            rand = new Random();
            boardsize = sizes;
            generateBoard();
        }   

        void generateBoard(){
            board = new Field[boardsize[0],boardsize[1]];
            for (int posX = 0; posX < boardsize[0]; posX++)
            {
                for (int posY = 0; posY < boardsize[1]; posY++)
                    board[posX,posY] = new Field(rand.Next(1,Enum.GetNames(typeof(FIELDTYPE)).Length));
            }
        }

        public Field getField(int x, int y)
        {
            return board[x, y];
        }
    }
}
