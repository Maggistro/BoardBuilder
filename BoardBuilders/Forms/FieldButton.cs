using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardBuilders
{
    public partial class FieldButton : Control
    {
        private Point[] triangle;
        BoardBuilder parent;
        public int x, y, drawX, drawY;

        public FieldButton()
        {
            //set triangle for button shape
            triangle = new Point[3] { new Point(0, 0), new Point(100, 0), new Point(50, 86) };
            this.BackColor = Color.Black;
            InitializeComponent();
        }



        //post constructor initialisation
        public void initFieldButton()
        {
            //set parent Object
            parent = (BoardBuilder)this.Parent;
            //get position from name
            string[] pos = this.Name.Split(':');
            x = int.Parse(pos[1]);
            y = int.Parse(pos[2]);
            drawX = int.Parse(pos[3]) + triangle[2].X;
            drawY = int.Parse(pos[4]) + (triangle[2].Y + triangle[1].Y)/2;
        }

        public FieldButton(Point[] size, FIELDTYPE type)
        {
            triangle = size;
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
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            myGraphicsPath.AddPolygon(triangle);
            //Change the button's background color so that it is easy
            //to see.
            this.Size = new System.Drawing.Size(100, 100);
            this.Region = new Region(myGraphicsPath);
        }
   

    }
}
