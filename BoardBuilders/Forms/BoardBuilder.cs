using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardBuilders
{

    public partial class BoardBuilder : Form
    {
        Board mainBoard;
        FieldButton[,] mainField;
        public BoardBuilder()
        {
            InitializeComponent();
        }

        private void generateBoard(int x, int y)
        {
            base.Invalidate();
            mainBoard = new Board(new int[2]{x,y});
            mainField = new FieldButton[x,y];
            generateField();
        }

        private void generateField()
        {
            int posX = 0;
            int posY = 0;
            for (int line = 0; line < mainBoard.boardsize[1]; line++)
            {
                for (int col = 0; col < mainBoard.boardsize[0]; col++)
                {
                    
                    if ( (col+line) % 2==0)
                    {
                        mainField[col,line] = new FieldButton(new Point[3] { new Point(0, 86), new Point(100, 86), new Point(50, 0) }, mainBoard.getField(col, line).type);
                    }
                    else
                    {
                        mainField[col,line] = new FieldButton(new Point[3] { new Point(0, 0), new Point(100, 0), new Point(50, 86) }, mainBoard.getField(col, line).type);
                    }
                    mainField[col, line].Parent = this;
                    mainField[col, line].Location = new System.Drawing.Point(posX, posY);
                    mainField[col, line].Size = new System.Drawing.Size(100, 86);
                    mainField[col, line].Name = "fieldButton_" + posX + ":" + posY;
                    mainField[col, line].Click += new System.EventHandler(this.fieldButton_Click);
                    this.Controls.Add(mainField[col, line]);
                    posX += 51;
                }
                posX = 0;
                posY += 87;
            }
        }

        private void fieldButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked at " + ((FieldButton)sender).Name);
        }


        private void generiereWeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateForm dialog = new GenerateForm();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                int x = 0, y = 0;
                try
                {
                    x = int.Parse(dialog.getColumn());
                    y = int.Parse(dialog.getRow());
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Number Format! Only Numbers are allowed", "OK", MessageBoxButtons.OK);
                }
                this.generateBoard(x, y);
            }
            else
            {
                //do nothing
            }

            dialog.Dispose();

        }




    }


}
