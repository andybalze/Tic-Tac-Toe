using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void submitPlay(object sender, EventArgs e)
        {
            Form1.setPlayerNames(playerX.Text, playerO.Text, VSComputer.ToString());
            this.Close();
        }
        private void VSComputer_UnCheckedChanged(object sender, EventArgs e)
        {
            playerO.Enabled = true;
        }
        private void VSComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (VSComputer.Checked == true)
            {
                playerO.Enabled = false;
                playerO.Text = "Computer";
            }
            else
            {
                playerO.Enabled = true;
                playerO.Text = "";
            }
        }
    }
}
