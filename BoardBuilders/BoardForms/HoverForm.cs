using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BoardBuilders.BoardForms
{
    public enum HOVERMOUSEPOSITION {
        CENTER,LEFT,TOP,RIGHT,BOTTOM, UP, DOWN
    }

    public partial class HoverForm : Form
    {
        private List<FieldButton> extraButtons = new List<FieldButton>();
        private int size = 0;
        private bool up = false;
        private System.Drawing.Drawing2D.Matrix rotMatrix;
        private System.Drawing.Point savedLocation = new Point(0,0);
        private HOVERMOUSEPOSITION lastposition = HOVERMOUSEPOSITION.CENTER;

        public HoverForm()
        {
            Opacity = 0.6;
            size = 1;
            InitializeComponent();
            this.fieldButton1.BackColor = Color.WhiteSmoke;
            this.fieldButton1.Click += fieldButton1_Click;
            this.fieldButton1.drawCenterX = 50;
            this.fieldButton1.drawCenterY = 43;
            for (int i = 0; i < Game.MAXBUILDINGSIZE; i++)
            {
                FieldButton f = new FieldButton();
                f.BackColor = Color.WhiteSmoke;
                f.Parent = this;
                f.Name = "extraButton_" + i;
                f.Size = new Size(fieldButton1.Width, fieldButton1.Height);
                f.Click += fieldButton1_Click;
                f.MouseMove += HoverForm_MouseMove;
                this.extraButtons.Add(f);
                this.Controls.Add(f);
            }
            this.fieldButton1.MouseMove += HoverForm_MouseMove;
            rotMatrix = new System.Drawing.Drawing2D.Matrix();
            rotMatrix.RotateAt(180, new PointF(fieldButton1.drawCenterX, fieldButton1.drawCenterY));
        }

        void HoverForm_MouseMove(object sender, MouseEventArgs e)
        {
                HOVERMOUSEPOSITION position = initExtraButtons(e.Location.X, e.Location.Y);
                Debug.WriteLine("position "+position);
                if (position != lastposition && position!=HOVERMOUSEPOSITION.CENTER)
                { //if new area reached
                    setExtraButtonPositon(position);
                    lastposition = position;
                }
        }

        public void updateLocation(System.Drawing.Point newLocation)
        {

            if (newLocation != savedLocation)
            {
                this.Location = newLocation;
                savedLocation = newLocation;
            }
        }


        void fieldButton1_Click(object sender, EventArgs e)
        {
            InvokeOnClick(this,e);
        }

        public void setShape(System.Drawing.Drawing2D.GraphicsPath newShape)
        {
            this.fieldButton1.setShape(newShape);
            Invalidate();
        }

        public HOVERMOUSEPOSITION getHoverPosition()
        {
            return lastposition;
        }

        public void setSize(int p)
        {
            size = p;
            for (int i = 0; i < Game.MAXBUILDINGSIZE; i++) //activate size-1 extra buttons
            {
                if (i < size-1)
                    extraButtons.ElementAt(i).Show();
                else
                    extraButtons.ElementAt(i).Hide();
            }

            //resize form depending on the new button count
            this.Size = new Size(fieldButton1.Size.Height * (int)Math.Round(Math.Log(size+1,2)) , fieldButton1.Size.Width * (int)Math.Round(Math.Log(size+1,2))); 
         
       }

        public void setUp(bool up)
        {
            this.up = up;
        }
 
        //initialises the extra buttons depending on the mouseposition and size 
        private HOVERMOUSEPOSITION initExtraButtons(int x, int y){
            switch(size)
            {
                case 1:
                    return HOVERMOUSEPOSITION.CENTER;
                case 2:
                    if (up)
                    {
                        if ((y) > fieldButton1.Size.Height * 2 / 3) //check if at the bottom
                            return HOVERMOUSEPOSITION.BOTTOM;

                        if ((x )  >= fieldButton1.Size.Width/2) // if not check right and left
                            return HOVERMOUSEPOSITION.RIGHT;
                        else
                            return HOVERMOUSEPOSITION.LEFT;
                    }
                    else
                    {
                        if ((y) < fieldButton1.Size.Height / 3) // check if at the top
                            return HOVERMOUSEPOSITION.TOP;

                        if ((x) >= fieldButton1.Size.Width / 2) // if not check right and left
                            return HOVERMOUSEPOSITION.RIGHT;
                        else
                            return HOVERMOUSEPOSITION.LEFT;
                    }
                //now the special building. As these have fixed forms, we only need to know the orientation ( up/down)
                case 4:
                    goto case 31;
                case 10:
                    goto case 31;
                case 19:
                    goto case 31;
                case 31:
                    if (up)
                        return HOVERMOUSEPOSITION.DOWN;
                    else
                        return HOVERMOUSEPOSITION.UP;
            }


            return HOVERMOUSEPOSITION.CENTER; //per default center position

        }



        private void setExtraButtonPositon(HOVERMOUSEPOSITION position)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = (System.Drawing.Drawing2D.GraphicsPath)fieldButton1.getShape().Clone();
            System.Drawing.Point tPoint = savedLocation;
            
            switch (position)
            {
                //first check cases with 1 additional button
                case HOVERMOUSEPOSITION.BOTTOM:
                    this.Location = tPoint;
                    shape.Transform(rotMatrix); //rotate
                    fieldButton1.Location = new Point(0, 0);
                    extraButtons.ElementAt(0).setShape(shape);
                    extraButtons.ElementAt(0).Location = new Point(0, 87);
                    break;
                case HOVERMOUSEPOSITION.TOP:
                    tPoint.Offset(new Point(0, -87));
                    this.Location = tPoint;
                    shape.Transform(rotMatrix); //rotate secondary shape
                    fieldButton1.Location = new Point(0, 87); //shift mainbutton down
                    extraButtons.ElementAt(0).setShape(shape); //set new shape for secondary button
                    extraButtons.ElementAt(0).Location = new Point(0, 0); //set secondary button to top
                    break;
                case HOVERMOUSEPOSITION.RIGHT:
                    this.Location = tPoint;
                    shape.Transform(rotMatrix); //rotate
                    fieldButton1.Location = new Point(0, 0);
                    extraButtons.ElementAt(0).setShape(shape);
                    extraButtons.ElementAt(0).Location = new Point(50, 0);
                    break;
                case HOVERMOUSEPOSITION.LEFT:
                    tPoint.Offset(new Point(-50, 0));
                    this.Location = tPoint;
                    shape.Transform(rotMatrix); //rotate
                    fieldButton1.Location = new Point(50, 0);
                    extraButtons.ElementAt(0).setShape(shape);
                    extraButtons.ElementAt(0).Location = new Point(0, 0);
                    break;
                case HOVERMOUSEPOSITION.DOWN:
                    break;
                case HOVERMOUSEPOSITION.UP:
                    break;
                case HOVERMOUSEPOSITION.CENTER:
                    break;
            }
            Invalidate();
        }
    }
}
