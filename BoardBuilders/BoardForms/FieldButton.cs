using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardBuilders.BoardForms
{
    public partial class FieldButton : Control
    {
        private Point[] triangle;
        private System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
        BoardBuilder parent;
        public int x, y, drawX, drawY, drawCenterX, drawCenterY;
        private Bitmap building;
        private Bitmap unit;
        private Bitmap burning = BoardBuilders.Properties.Resources.damaged;
        private bool damaged = false;
        private Size imageSize;
        Graphics g;

        public FieldButton()
        {
            //set triangle for button shape
            triangle = new Point[3] { new Point(0, 0), new Point(100, 0), new Point(50, 86) };
            //set up shape and add triangle
            shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddPolygon(triangle);
            //set default background
            this.BackColor = Color.Black;
            InitializeComponent();
        }

        public System.Drawing.Drawing2D.GraphicsPath getShape()
        {
            return shape;
        }

        //method for manually setting a shape CARE: THIS DOES NOT UPDATE THE DRAWCENTER AND DRAW POINTS
        public void setShape(System.Drawing.Drawing2D.GraphicsPath newShape)
        {
            shape = newShape;
        }

        //post constructor initialisation
        public void initFieldButton()
        {
            //set parent Object
            parent = (BoardBuilder)this.Parent;
            //get position from name
            string[] pos = this.Name.Split(':');
            //position on the game grid array
            x = int.Parse(pos[1]);
            y = int.Parse(pos[2]);
            //position of the center of the fieldbutton in pixels for the parent form
            drawCenterX = int.Parse(pos[3]) + triangle[2].X;
            drawCenterY = int.Parse(pos[4]) + (triangle[2].Y + triangle[1].Y) / 2;
            //position of the upper left corner of the fieldbutton in pixels for the parent form
            drawX = int.Parse(pos[3]);
            drawY = int.Parse(pos[4]);
            //position for the image to be drawn relative to the fieldbutton
            imageSize = new Size(triangle[1].X / 2, (triangle[2].Y + triangle[1].Y) / 2);
 
        }

        public FieldButton(Point[] size, FIELDTYPE type)
        {
            //set triangle
            triangle = size;
            //add to shape
            shape.AddPolygon(triangle);
            //get background color from type
            switch (type){
                case FIELDTYPE.GRASS: 
                    this.BackColor = Color.LawnGreen; 
                    break;
                case FIELDTYPE.MOUNTAIN: 
                    this.BackColor = Color.LightGray; 
                    break;
                case FIELDTYPE.WATER: 
                    this.BackColor = Color.LightBlue; 
                    break;
                case FIELDTYPE.WOODS: 
                    this.BackColor = Color.ForestGreen; 
                    break;
                default: 
                    this.BackColor = Color.Black;
                    break;
            }
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Change the button's background color so that it is easy
            //to see.
            this.Size = new System.Drawing.Size(100, 100);
            this.Region = new Region(shape);
            //draw building
            if (building != null)
            {
                g.DrawImage(building, triangle[1].X / 4, (triangle[1].Y + triangle[2].Y) / 5);
                g.Flush();
            }
            //draw unit
            if (unit != null)
            {
                g.DrawImage(unit, triangle[1].X / 4, (triangle[1].Y + triangle[2].Y) / 5);
                g.Flush();
            }
            //draw burning overlay
            if (damaged)
            {
                g.DrawImage(burning, triangle[1].X / 4, (triangle[1].Y + triangle[2].Y) / 5);
                g.Flush();
            }
        }

        //set building image
        public void setBuildingImage(Image buildingImage)
        {
            //position for the image to be drawn relative to the fieldbutton
            Bitmap temp = new Bitmap(buildingImage);
            temp.MakeTransparent(Color.White);
            this.building = new Bitmap(temp,imageSize);
            g = this.CreateGraphics();
            g.DrawImage(building, triangle[1].X/4, (triangle[1].Y+triangle[2].Y)/5);
            g.Flush();
        }

        //delete buidling image
        public void resetBuildingImage()
        {
            this.building = null; //reset image
            this.Invalidate(); //redraw
        }

        //set unit Image
        public void setUnitImage(Image unitImage)
        {
            //position for the image to be drawn relative to the fieldbutton
            Bitmap temp = new Bitmap(unitImage);
            temp.MakeTransparent(Color.White);
            this.unit = new Bitmap(temp, imageSize);
            g = this.CreateGraphics();
            g.DrawImage(unit, triangle[1].X / 4, (triangle[1].Y + triangle[2].Y) / 5);
            g.Flush();
        }


        //toggle burning overlay
        public void toggleBurning()
        {
            damaged = !damaged;
            this.Invalidate();
        }
    }
}
