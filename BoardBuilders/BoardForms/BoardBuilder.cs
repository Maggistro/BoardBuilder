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

namespace BoardBuilders.BoardForms
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

        //form for hover highlighting
        HoverForm hoverForm = new HoverForm();
        int[] hoverPosition = new int[2];

        //temporary Building for placing
        Building tempBuilding;
        Image tempImage;

        public BoardBuilder()
        {
            this.status = FIELDSTATUS.NORMAL;
            this.tempBuilding = new Building();
            
            //set initial info label parameters
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.Parent = this;
            this.infoLabel.BackColor = Color.White;
            this.infoLabel.Name = "infoLabel";
            this.Controls.Add(this.infoLabel);

            //set initial hoverForm
            this.LocationChanged += BoardBuilder_LocationChanged; //update hoverform
            this.hoverForm.Location = this.Location;
            this.hoverForm.Name = "hoverForm";
            this.hoverForm.Click += hoverForm_Click;
            

            InitializeComponent();
        }

        //update location of all subforms
        void BoardBuilder_LocationChanged(object sender, EventArgs e)
        {
            this.hoverForm.Location = this.Location; //TODO: relative offset or recalculate complete position
        }

        //generate game board with x,y size
        private void generateBoard(int x, int y, List<string> playerNames)
        {
            base.Invalidate();
            mainBoard = new Game(new int[2]{x,y}, playerNames); //init game logic
            mainField = new FieldButton[x,y]; //init game view
            generateField(); //set up game view
            mainBoard.startGame(); //start game
            turnLabel.Text = "Zug Nr. "+mainBoard.getTurn().ToString(); //set turnlabel
            activePlayerLabel.Text = mainBoard.getActivePlayer().getName(); //set active Player
        }

        //generate buttons for the field
        private void generateField()
        {
            int posX = 0;
            int posY = this.GameMenu.Height;
            for (int line = 0; line < mainBoard.getBoardSize()[1]; line++)
            {
                for (int col = 0; col < mainBoard.getBoardSize()[0]; col++)
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
                    mainField[col, line].MouseLeave += new System.EventHandler(this.FieldButton_MouseLeave);
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

        private void prepareBuild()
        {
            //check for building cost
            if (mainBoard.getActivePlayer().pay(tempBuilding.getBuildCost()))
            {
                status = FIELDSTATUS.BUILDING;
                hoverForm.setSize(tempBuilding.getBuildPlace().Count);
                hoverForm.Show(this);
            }
            else
            {
                MessageBox.Show(this,"Not enough ressources. Need " + tempBuilding.getBuildCost().ToString()); //not enough cards to pay
            }
        }

        //checks if underlying fields match the required field for building
        private bool checkFieldTypeForBuild()
        {
            if (tempBuilding.getBuildPlace().Count == 1)
                return mainBoard.getField(hoverPosition[0], hoverPosition[1]).type == tempBuilding.getBuildPlace().ElementAt(0);
            else
                return false;
        }

        /**
        * HANDLERS FOR BUTTON MOUSE EVENTS
        * 
        */

        #region BUTTONMOUSEEVENTS
        //gets a mouseposition on x,y and checks 


        //handles click on hoverform
        void hoverForm_Click(object sender, EventArgs e)
        {
            if (status == FIELDSTATUS.BUILDING)
            {
                //check for building place
                if (checkFieldTypeForBuild())
                {
                    tempBuilding.build(hoverPosition[0], hoverPosition[1]); //build building
                    mainBoard.getField(hoverPosition[0], hoverPosition[1]).building = tempBuilding; //add to field
                    mainBoard.getActivePlayer().addBuilding(tempBuilding); //add to players buildings
                    mainField[hoverPosition[0], hoverPosition[1]].setBuildingImage(tempImage);
                }
                else
                {
                    MessageBox.Show(this,"Wrong field selected. Need "+tempBuilding.getBuildPlace().ElementAt(0).ToString()); //inform about error
                    mainBoard.getActivePlayer().addCard(new List<Card>(tempBuilding.getBuildCost())); //reimburse player for payed cost
                }
                status = FIELDSTATUS.NORMAL;
                hoverForm.Hide();
            }
            else
            {
                hoverForm.Hide();
            }
        }

        //handler for click on field
        private void FieldButton_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Clicked at " + ((FieldButton)sender).Name);
        }

        //handler for disbanding hover information
        void FieldButton_MouseLeave(object sender, EventArgs e)
        {
            infoLabel.Hide();
            //((FieldButton)sender).ForeColor = Color.Transparent;
        }
        
        //handler for showing hover information
        void FieldButton_MouseHover(object sender, EventArgs e)
        {
            if (status == FIELDSTATUS.NORMAL) //if nothing special is active, display information about the field while hovering
            {
                string info = "";
                info += getUnitAt(((FieldButton)sender).x, ((FieldButton)sender).y);
                if (info != "")
                    info += " ";
                info += getBuildingAt(((FieldButton)sender).x, ((FieldButton)sender).y);
                infoLabel.Text = info;
                infoLabel.Location = new Point(((FieldButton)sender).drawCenterX, ((FieldButton)sender).drawCenterY);
                infoLabel.Show();
            }
            else if (status == FIELDSTATUS.BUILDING) //if player wants to build, highlight field with hoverForm
            {
                int borderWidth = (this.Width - this.ClientSize.Width) / 2;
                int titleBarHeight = this.Height - this.ClientSize.Height - borderWidth;
                hoverForm.setShape(((FieldButton)sender).getShape());
                Point hoverPoint = this.Location;
                hoverPoint.Offset(new Point(((FieldButton)sender).drawX + borderWidth, ((FieldButton)sender).drawY + titleBarHeight));
                hoverForm.setUp((((FieldButton)sender).x + ((FieldButton)sender).y) % 2 == 0);
                hoverForm.updateLocation(hoverPoint);
                hoverPosition[0] = ((FieldButton)sender).x;
                hoverPosition[1] = ((FieldButton)sender).y;
            }
        }

        #endregion

        /**
        * HANDLERS FOR GAME MENU
        * 
        */

        #region GAMEMENUHANDLER
        //handler for showing gamestart menu
        private void generiereWeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateForm dialog = new GenerateForm(); //call dialog for Game settings
            bool canGenerate = true;

            if (dialog.ShowDialog(this) == DialogResult.OK) // if returns....
            {
                //read field size 
                int x = 0, y = 0;
                try
                {
                    x = int.Parse(dialog.getColumn());
                    y = int.Parse(dialog.getRow());
                }
                catch (Exception) //catch wrong input ( e.g. no numbers )
                {
                    MessageBox.Show("Wrong Number Format! Only Numbers are allowed", "OK", MessageBoxButtons.OK);
                    canGenerate &= false;
                }

                //read player names
                List<string> playerNames = dialog.getPlayers().Split(':').ToList<string>();
                if (playerNames.Count() == 0) //catch no players entered
                {
                    MessageBox.Show("Not enough players declared. At least one needed", "OK", MessageBoxButtons.OK);
                    canGenerate &= false;
                }

                //if all went well, generate game board
                if(canGenerate) 
                    this.generateBoard(x, y,playerNames);
            }
            else
            {
                //do nothing, should not happen
                MessageBox.Show("Unexpected Error! GenerateForm closed without result==OK!", "OK", MessageBoxButtons.OK);
            }

            dialog.Dispose();

        }
        #endregion 

        /**
         * HANDLER FOR PLAYER MENU
         * 
         */
        #region PLAYERMENUHANDLER

        private void endturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainBoard.endTurn();
            turnLabel.Text = "Zug Nr. " + mainBoard.getTurn().ToString(); //set turnlabel
            activePlayerLabel.Text = mainBoard.getActivePlayer().getName(); //set active Player
        }

        private void handToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hand = "";
            foreach(Card card in mainBoard.getActivePlayer().getHand())
            {
                hand += card.getType().ToString() + "; ";
            }
            //Debug hand display
            MessageBox.Show(hand, "OK", MessageBoxButtons.OK);

        }


        private void tradeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        /**
         * HANDLER FOR BUILDING MENU
         * 
         */
        #region BUIDLINGMENUHANDLER

        //handler for creating a woodcutter object
        private void woodcutterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Woodcutter();
            tempImage = BoardBuilders.Properties.Resources.woodcutter;
            prepareBuild();
        }

        private void stonemasonToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tempBuilding = new Stonemason();
            tempImage = BoardBuilders.Properties.Resources.stonemason;
            prepareBuild();
        }

        private void fruitfarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Fruitfarm();
            tempImage = BoardBuilders.Properties.Resources.fruitfarm;
            prepareBuild();
        }

        private void hunterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Hunter();
            tempImage = BoardBuilders.Properties.Resources.hunter;
            prepareBuild();
        }

        private void fischerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Fischinghut();
            prepareBuild();
        }

        private void coalmineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Coalmine();
            tempImage = BoardBuilders.Properties.Resources.coalmine;
            prepareBuild();
        }

        private void ironmineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempBuilding = new Ironmine();
            prepareBuild();
        }

        #endregion


    }


}
