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
    public partial class HoverForm : Form
    {
        private int size = 0;

        public HoverForm()
        {
            Opacity = 0.6;
            size = 1;
            InitializeComponent();
            this.fieldButton1.BackColor = Color.WhiteSmoke;
            this.fieldButton1.Click += fieldButton1_Click;
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

        public void setSize(int p)
        {
            size = p;
        }
    }
}
