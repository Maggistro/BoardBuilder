using BoardBuilders.Buildings;
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
    public enum FIELDSTATUS
    {
        NORMAL,BUILDING
    }

    public partial class BoardBuilder : Form
    {
        //mainboard holds logic
        Game mainBoard;

        //mainfield holds visual
        FieldButton[,] mainField;
        
        //status the visual board is in
        FIELDSTATUS status;

        //additional label for hover information
        Label infoLabel = new Label();

        //temporary Building for placing
        Building tempBuilding;

        public BoardBuilder()
        {
            this.status = FIELDSTATUS.NORMAL;
            this.tempBuilding = new Building();
            
            //set initial info label parameters
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(320, 120);
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.Parent = this;
            this.infoLabel.BackColor = Color.White;
            this.infoLabel.Name = "infoLabel";
            this.Controls.Add(this.infoLabel);

            //initialise the transparent form
            

            InitializeComponent();
        }

        //generate game board with x,y size
        private void generateBoard(int x, int y)
        {
            base.Invalidate();
            mainBoard = new Game(new int[2]{x,y});
            mainField = new FieldButton[x,y];
            generateField();
        }

        //generate buttons for the field
        private void generateField()
        {
            int posX = 0;
            int posY = 0;
            for (int line = 0; line < mainBoard.boardsize[1]; line++)
            {
                for (int col = 0; col < mainBoard.boardsize[0]; col++)
                {
                    //depending on the position flip triangle to cover area
                    if ( (col+line) % 2==0)
                    {
                        mainField[col,line] = new FieldButton(new Point[3] { new Point(0, 86), new Point(100, 86), new Point(50, 0) }, mainBoard.getField(col, line).type);
                    }
                    else
                    {
                        mainField[col,line] = new FieldButton(new Point[3] { new Point(0, 0), new Point(100, 0), new Point(50, 86) }, mainBoard.getField(col, line).type);
                    }
                    //set parameters for button and add handler
                    mainField[col, line].Parent = this;
                    mainField[col, line].Location = new System.Drawing.Point(posX, posY);
                    mainField[col, line].Size = new System.Drawing.Size(100, 86);
                    mainField[col, line].Name = "fieldButton:" + col + ":" + line + ":"+posX+":"+posY;
                    mainField[col, line].Click += new System.EventHandler(this.FieldButton_Click);
                    mainField[col, line].MouseHover += new System.EventHandler(this.FieldButton_MouseHover);
                    mainField[col, line].MouseHover += new System.EventHandler(this.FieldButton_MouseLeave);
                    mainField[col, line].initFieldButton();
                    this.Controls.Add(mainField[col, line]);
                    posX += 51;
                }
                posX = 0;
                posY += 87;
            }
        }
        

      
        public string getBuildingAt(int x, int y)
        {
            return mainBoard.getField(x, y).building.getName();
        }

        private string getUnitAt(int x, int y)
        {
            return mainBoard.getField(x, y).unit.getName();
        }

       /**
       * HANDLERS FOR BUTTONS, MENU ETC.
       * 
       */
        //handler for click on field
        private void FieldButton_Click(object sender, EventArgs e)
        {
            if (status == FIELDSTATUS.BUILDING)
            {
                tempBuilding.build(((FieldButton)sender).x, ((FieldButton)sender).y);
            }
            else if (status == FIELDSTATUS.NORMAL)
            {
                MessageBox.Show("Clicked at " + ((FieldButton)sender).Name);
            }
        }

        //handler for disbanding hover information
        void FieldButton_MouseLeave(object sender, EventArgs e)
        {
            //infoLabel.Hide();
            ((FieldButton)sender).ForeColor = Color.Transparent;
        }
        
        //handler for showing hover information
        void FieldButton_MouseHover(object sender, EventArgs e)
        {
            if (status == FIELDSTATUS.NORMAL)
            {
                string info = "";
                info += getUnitAt(((FieldButton)sender).x, ((FieldButton)sender).y);
                if (info != "")
                    info += " ";
                info += getBuildingAt(((FieldButton)sender).x, ((FieldButton)sender).y);
                infoLabel.Text = info;
                infoLabel.Location = new Point(((FieldButton)sender).drawX, ((FieldButton)sender).drawY);
                infoLabel.Show();
            }
            else if (status == FIELDSTATUS.BUILDING)
            {
                ((FieldButton)sender).ForeColor = Color.WhiteSmoke;
            }
        }


        //handler for showing gamestart menu
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

        //handler for creating a woodcutter object
        private void holzfällerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Woodcutter();
            status = FIELDSTATUS.BUILDING;
        }




    }


}
