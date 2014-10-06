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
    public partial class FieldButtonDemo : Form
    {
        Point[] triangle;
        public FieldButtonDemo()
        {
            triangle = new Point[3] { new Point(0, 0), new Point(100, 0), new Point(50, 86) };
            InitializeComponent();
        }

        private void customButton_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            myGraphicsPath.AddPolygon(triangle);
            //Change the button's background color so that it is easy
            //to see.
            customButton.Size = new System.Drawing.Size(100, 100);
            customButton.Region = new Region(myGraphicsPath);
        }

        private void customButton_Click(object sender, System.EventArgs e)
        {
            customButton.BackColor = Color.Red;
        }
    }
}
