using BoardBuilders.Buildings;
using BoardBuilders.Units;
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
        NORMAL,BUILDING,RECRUITING
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
        ContextMenuStrip infoMenu = new ContextMenuStrip();
        ToolStripDropDownButton buildingMenuStrip = new ToolStripDropDownButton();
        ToolStripDropDownButton unitMenuStrip = new ToolStripDropDownButton();

        //form for hover highlighting
        HoverForm hoverForm = new HoverForm();
        int[] hoverPosition = new int[2];

        //temporary Building for placing
        Building tempBuilding;

        //temporary Unit for placing
        Unit tempUnit;

        //temporary image for drawwing to-be-placed class
        Image tempImage;
        public BoardBuilder()
        {
            this.status = FIELDSTATUS.NORMAL;
            this.tempBuilding = new Building();
            this.tempUnit = new Unit();
            
            //set initial info label parameters
            this.infoMenu.AutoSize = true;
            this.infoMenu.Location = new System.Drawing.Point(0, 0);
            this.infoMenu.Size = new System.Drawing.Size(35, 13);
            this.infoMenu.TopLevel = false;
            this.infoMenu.Parent = this;
            this.infoMenu.BackColor = Color.White;
            this.infoMenu.Name = "infoMenu";
            this.Controls.Add(this.infoMenu);

            //set initial hoverForm
            this.LocationChanged += BoardBuilder_LocationChanged; //update hoverform
            this.hoverForm.Location = this.Location;
            this.hoverForm.Name = "hoverForm";
            this.hoverForm.Click += hoverForm_Click;
            

            InitializeComponent();

            List<string> DebugPlayerList = new List<string>();
            DebugPlayerList.Add("Hans");
            DebugPlayerList.Add("Kurt");
            generateBoard(10, 10, DebugPlayerList);
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
        
        //extract building name from game logic
        public string getBuildingNameAt(int x, int y)
        {
            return mainBoard.getField(x, y).building.getName();
        }

        //extract unit name from game logic
        private string getUnitNameAt(int x, int y)
        {
            return mainBoard.getField(x, y).unit.getName();
        }

        //check if building can be paid and init hoverform for placement selection
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

        //check if unit can be paid and init hoverform for placement selection
        private void prepareUnit()
        {
            //check for building cost
            if (mainBoard.getActivePlayer().pay(tempUnit.getRecruitmentCost()))
            {
                status = FIELDSTATUS.RECRUITING;
                hoverForm.setSize(1);
                hoverForm.Show(this);
            }
            else
            {
                MessageBox.Show(this, "Not enough ressources. Need " + tempUnit.getRecruitmentCost().ToString()); //not enough cards to pay
            }
        }

        //checks if underlying fields allows building
        private bool checkFieldTypeForBuild()
        {
            if (tempBuilding.getBuildPlace().Count == 1){
                if(!(mainBoard.getField(hoverPosition[0], hoverPosition[1]).type == tempBuilding.getBuildPlace().ElementAt(0))){
                    MessageBox.Show(this,"Wrong field selected. Need "+tempBuilding.getBuildPlace().ElementAt(0).ToString()); //inform about error
                    return false;
                }
                return true;
            }
            else if (tempBuilding.getBuildPlace().Count == 2)
            {
                List<FIELDTYPE> found = new List<FIELDTYPE>();
                found.Add(mainBoard.getField(hoverPosition[0], hoverPosition[1]).type);
                switch(hoverForm.getHoverPosition())
                {
                    case HOVERMOUSEPOSITION.CENTER:
                        break;
                    case HOVERMOUSEPOSITION.BOTTOM:
                        if(hoverPosition[1]<mainBoard.getBoardSize()[1])
                        found.Add(mainBoard.getField(hoverPosition[0], hoverPosition[1]+1).type);
                        break;
                    case HOVERMOUSEPOSITION.TOP:
                        if(hoverPosition[1]>0)
                            found.Add(mainBoard.getField(hoverPosition[0], hoverPosition[1]-1).type);
                        break;
                    case HOVERMOUSEPOSITION.LEFT:
                        if (hoverPosition[0] > 0)
                            found.Add(mainBoard.getField(hoverPosition[0]-1, hoverPosition[1]).type);
                        break;
                    case HOVERMOUSEPOSITION.RIGHT:
                        if (hoverPosition[0] < mainBoard.getBoardSize()[0])
                            found.Add(mainBoard.getField(hoverPosition[0]+1, hoverPosition[1]).type);
                        break;
                    case HOVERMOUSEPOSITION.DOWN:
                        break;
                }
                if(!found.Contains(tempBuilding.getBuildPlace().ElementAt(0))){ //check first
                    MessageBox.Show(this,"Wrong field selected. Need "+tempBuilding.getBuildPlace().ElementAt(0).ToString()); //inform about error
                    return false;
                }

                if(!found.Contains(tempBuilding.getBuildPlace().ElementAt(1))){ //check second
                    MessageBox.Show(this,"Wrong field selected. Need "+tempBuilding.getBuildPlace().ElementAt(1).ToString()); //inform about error
                    return false;
                }
                return true;
                    
            }
            else
                return false;
        }

        //check if underlying field allows unit spawning
        private bool checkFieldTypeForSpawn()
        {
            if (!tempUnit.getSpawningPlace().Contains(mainBoard.getField(hoverPosition[0], hoverPosition[1]).type))
            {
                MessageBox.Show(this, "Wrong field selected. Need " + tempUnit.getSpawningPlace().ElementAt(0).ToString()); //inform about error
                return false;
            }
            return true;
        }

        //populate the popup menu for units depending on allowed actions
        private void populateUnitMenu(ref Unit unit)
        {
            unitMenuStrip.DropDownItems.Clear();
            foreach(UNITACTION action in unit.getAllowedActions())
            {
                ToolStripButton unitActionButton = new ToolStripButton(action.ToString());
                switch (action)
                {
                    case UNITACTION.ATTACK:
                        unitActionButton.Click += unitActionButton_Attack_Click;
                        break;
                    case UNITACTION.MOVE:
                        unitActionButton.Click += unitActionButton_Move_Click;
                        break;
                    case UNITACTION.SCOUT:
                        unitActionButton.Click += unitActionButton_Scout_Click;
                        break;
                    case UNITACTION.SETTLE:
                        unitActionButton.Click += unitActionButton_Settle_Click;
                        break;
                }
                unitMenuStrip.DropDownItems.Add(unitActionButton);
            }
        }

        //populate the popup menu for buildings depending on allowed actions
        private void populateBuildingMenu(ref Building building)
        {
            buildingMenuStrip.DropDownItems.Clear();
            foreach (BUILDINGACTION action in building.getAllowedActions())
            {
                ToolStripButton buildingActionButton = new ToolStripButton(action.ToString());
                switch (action)
                {
                    case BUILDINGACTION.DESTROY:
                        buildingActionButton.Click += buildingActionButton_Destroy_Click;
                        break;
                    case BUILDINGACTION.RAID:
                        buildingActionButton.Click += buildingActionButton_Raid_Click;
                        break;
                    case BUILDINGACTION.REPAIR:
                        buildingActionButton.Click += buildingActionButton_Repair_Click;
                        break;
                    case BUILDINGACTION.TOGGLEPRODUKTION:
                        buildingActionButton.Click += buildingActionButton_ToggleProduction_Click;
                        break;
                    case BUILDINGACTION.UPGRADE:
                        buildingActionButton.Click += buildingActionButton_Upgrade_Click;
                        break;
                }

                buildingMenuStrip.DropDownItems.Add(buildingActionButton);
            }
        }

        /**
         * HANDLER FOR BUILDING ACTIONS
         * 
         */

        #region BUILDINGACTIONHANDLER

        void buildingActionButton_Upgrade_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void buildingActionButton_ToggleProduction_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void buildingActionButton_Repair_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void buildingActionButton_Raid_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void buildingActionButton_Destroy_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        /**
         * HANDLERS FOR UNIT ACTIONS
         * 
         */

        #region UNITACTIONHANDLER

        void unitActionButton_Move_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void unitActionButton_Attack_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void unitActionButton_Scout_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void unitActionButton_Settle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        /**
        * HANDLERS FOR BUTTON MOUSE EVENTS
        * 
        */

        #region BUTTONMOUSEEVENTS

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
                    mainBoard.getActivePlayer().addCard(new List<Card>(tempBuilding.getBuildCost())); //reimburse player for payed cost
                }
                status = FIELDSTATUS.NORMAL;
                hoverForm.Hide();
            }
            else if (status == FIELDSTATUS.RECRUITING)
            {
                //check for building place
                if (checkFieldTypeForSpawn())
                {
                    tempUnit.rectruit(hoverPosition[0], hoverPosition[1]); //spawn unit
                    mainBoard.getField(hoverPosition[0], hoverPosition[1]).unit = tempUnit; //add to field
                    mainBoard.getActivePlayer().addUnit(tempUnit); //add to players units
                    mainField[hoverPosition[0], hoverPosition[1]].setUnitImage(tempImage);
                }
                else
                {
                    mainBoard.getActivePlayer().addCard(new List<Card>(tempUnit.getRecruitmentCost())); //reimburse player for payed cost
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
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                infoMenu.Hide();
                infoMenu.Items.Clear();
                //MessageBox.Show("Left Clicked at " + ((FieldButton)sender).Name);
            }
            else if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                //MessageBox.Show("Right Clicked at " + ((FieldButton)sender).Name);
            }
        }

        //handler for disbanding hover information
        private void FieldButton_MouseLeave(object sender, EventArgs e)
        {
            //infoMenu.Hide();
            //infoMenu.Items.Clear();
            //((FieldButton)sender).ForeColor = Color.Transparent;
        }
        
        //handler for showing hover information
        private void FieldButton_MouseHover(object sender, EventArgs e)
        {
            if (status == FIELDSTATUS.NORMAL) //if nothing special is active, display information about the field while hovering
            {
                infoMenu.Hide();
                infoMenu.Items.Clear();
                string info = "";
                info += getUnitNameAt(((FieldButton)sender).x, ((FieldButton)sender).y);
                //add unit handler
                if(info!=""){
                    populateUnitMenu(ref mainBoard.getField(((FieldButton)sender).x, ((FieldButton)sender).y).unit);
                    unitMenuStrip.Text = info;
                    infoMenu.Items.Add(unitMenuStrip);
                    info = "";
                }

                info += getBuildingNameAt(((FieldButton)sender).x, ((FieldButton)sender).y);
                //add building handler
                if (info != "")
                {
                    populateBuildingMenu(ref mainBoard.getField(((FieldButton)sender).x, ((FieldButton)sender).y).building);
                    buildingMenuStrip.Text = info;
                    infoMenu.Items.Add(buildingMenuStrip);
                    info = "";
                }
                infoMenu.Show(new Point(((FieldButton)sender).drawCenterX, ((FieldButton)sender).drawCenterY));
                infoMenu.PerformLayout();
            }
            else if (status == FIELDSTATUS.BUILDING || status == FIELDSTATUS.RECRUITING) //if player wants to build, highlight field with hoverForm
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
            tempImage = BoardBuilders.Properties.Resources.fischer;
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
            tempImage = BoardBuilders.Properties.Resources.ironmine;
            prepareBuild();
        }

        #endregion


        /**
         * HANDLER FOR UNIT MENU
         * 
         */

        #region UNITMENUHANDLER
        
        private void settlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempUnit = new Settler();
            tempImage = BoardBuilders.Properties.Resources.settler;
            prepareUnit();
        }

        private void scoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bowmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void swordsmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        
  
    }


}
