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
    public partial class GenerateForm : Form
    {
        public GenerateForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string getColumn()
        {
            return columnTextBox.Text;
        }

        public string getRow()
        {
            return rowTextBox.Text;
        }

        //returns all involved player names seperated by ':' or noplayer1 if no name is entered
        public string getPlayers()
        {
            string players = "";
            if(player1TextBox.Text.Equals("") || player1TextBox.Text.Equals("Spielername"))
                return players;
            else
                players += player1TextBox.Text;
            
            if(! ( player2TextBox.Text.Equals("") || player2TextBox.Text.Equals("Spielername")) )
                players += ":"+player2TextBox;

            if (!(player3TextBox.Text.Equals("") || player3TextBox.Text.Equals("Spielername")))
                players += ":" + player3TextBox;

            if (!(player4TextBox.Text.Equals("") || player4TextBox.Text.Equals("Spielername")))
                players += ":" + player4TextBox;

            return players;
        }

    }
}
