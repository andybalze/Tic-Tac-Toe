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
    public partial class Form1 : Form
    {
        bool turn = true;//true = X turn, False = Y turn
        static bool VSComputer;
        int turnCount = 0;//Amount of turns
        static string playerX, playerO;
        public static void setPlayerNames(string NameX, string NameO, string againstComputer)
        {
            playerX = NameX;
            playerO = NameO;
            if (againstComputer == "System.Windows.Forms.CheckBox, CheckState: 1")
            {
                VSComputer = true;
            }
            else
            {
                VSComputer = false;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {

                MessageBox.Show("You pressed ctrl + c");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
            if (playerX != "") { xWinCountLabel.Text = playerX; } else { playerX = "X"; }
            if (playerO != "") { oWinCountLabel.Text = playerO; } else { playerO = "O"; }
            xWinCountLabel.Text = playerX;
            oWinCountLabel.Text = playerO;
            whoTurn.Text = playerX + "'s turn";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Weston Fausett", "Tic Tac Toe About");
        }
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            if (turn)
            {
                whoTurn.Text = playerX + "'s turn";
            }
            else
            {
                whoTurn.Text = playerO + "'s turn";
            }

            b.Enabled = false;
            turnCount++;
            checkForWin();

            //Check's to see if playing against the computer and if it is O's turn
            if ((VSComputer) && (!turn))
                computerMakeMove();
        }
        private void computerMakeMove()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if
            if (turnCount == 9)
            { }
            else
            {
                move.PerformClick();
            }
        }
        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }
        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }
        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
        private void New_Game(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            foreach (Component c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//End Try
                catch { }
            }//End Foreach
        }
        private void checkForWin()
        {
            //Horizontal Wins
            bool isWinner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != ""))
                isWinner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
                isWinner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
                isWinner = true;

            //Vertical Wins
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
                isWinner = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
                isWinner = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
                isWinner = true;

            //Diagonal Wins
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
                isWinner = true;
            if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (A3.Text != ""))
                isWinner = true;

            if (isWinner) //If a winner is found
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = playerO;
                    oWinCount.Text = (Int32.Parse(oWinCount.Text) + 1).ToString();
                }
                else
                {
                    winner = playerX;
                    xWinCount.Text = (Int32.Parse(xWinCount.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!");
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("A Tie between \'" + playerO + "\' and \'" + playerX + "\' has occured", "Tie");
                    drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString();
                }
            }
        }//End Winner Check

        private void newGameVComputer(object sender, EventArgs e)
        {
            VSComputer = true;
            turn = true;
            turnCount = 0;
            foreach (Component c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//End Try
                catch { }
            }//End Foreach
        }

        private void showScores(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(367, 310);
        }

        private void disableButtons()
        {
            foreach (Component c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }//End Foreach

        }

        private void resetWinCounts(object sender, EventArgs e)
        {
            drawCount.Text = "0";
            oWinCount.Text = "0";
            xWinCount.Text = "0";
        }
    }
}
