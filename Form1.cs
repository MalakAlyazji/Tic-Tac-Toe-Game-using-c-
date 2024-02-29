using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoeproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white);
            pen.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(pen, 400, 460, 1050, 460);
            e.Graphics.DrawLine(pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(pen, 840, 140, 840, 620);
        }
        enum enplayer { player1, player2 };
        enplayer playerturn = enplayer.player1;
        stgamestatus gamestatus;
        struct stgamestatus
        {
            public int count;
            public enwinner winner;
            public bool gameover;
        }
        enum enwinner
        {
            player1, player2, draw, gameinprogress
        }
        void endgame()
        {
            lbturn.Text = "Game Over";
            switch (gamestatus.winner)
            {
                case enwinner.player1:
                    lbwinner.Text = "player1";
                    break;
                case enwinner.player2:
                    lbwinner.Text = "player2";
                    break;
                default:
                    lbwinner.Text = "Draw";
                    break;
                    
            }
            MessageBox.Show("Game Over", "Game Over",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        public bool checkvalues(Button b1, Button b2, Button b3)
        {
            if (b1.Tag.ToString() != "?" && (b1.Tag.ToString() == b2.Tag.ToString()) && (b1.Tag.ToString() == b3.Tag.ToString()))
            {
                if (b1.Tag.ToString() == "X")
                {
                    gamestatus.winner = enwinner.player1;
                    gamestatus.gameover = true;
                    endgame();
                    return true;
                }
                else
                {
                    gamestatus.winner = enwinner.player2;
                    gamestatus.gameover = true;
                    endgame();
                    return true;
                }

            }
            gamestatus.winner = enwinner.draw;
            gamestatus.gameover = false;
            return false;
            
        }
    public void checkwinner()
    {
        if (checkvalues(bt1, bt2, bt3)) return;
        if (checkvalues(bt4, bt5, bt6)) return;
        if (checkvalues(bt7, bt8, bt9)) return;
        if (checkvalues(bt1, bt5, bt9)) return;
        if (checkvalues(bt3, bt5, bt7)) return;
        if (checkvalues(bt1, bt4, bt7)) return;
        if (checkvalues(bt2, bt5, bt8)) return;
        if (checkvalues(bt3, bt6, bt9)) return;
        
    }
    public void changeimage(Button bn)
    {
        if (bn.Tag.ToString() == "?")
        {
            switch (playerturn)
            {
                case enplayer.player1:
                    bn.Image = Image.FromFile(@"C:\Users\hp\Downloads\X.png");
                    playerturn = enplayer.player2;
                    lbturn.Text = "Player 2";
                    bn.Tag = "X";
                    gamestatus.count++;
                        checkwinner();
                    break;
                case enplayer.player2:
                    bn.Image = Image.FromFile(@"C:\Users\hp\Downloads\O.png");
                    playerturn = enplayer.player1;
                    lbturn.Text = "Player 1";
                    bn.Tag = "O";
                    gamestatus.count++;
                    checkwinner();
                        break;
            }
            }
            else
            {
             MessageBox.Show("Wrong choice", "choice", MessageBoxButtons.OK); 
            }
            if (gamestatus.count == 9&& gamestatus.gameover==false)
            {
                gamestatus.winner = enwinner.draw;
                gamestatus.gameover = true;
                endgame();
            }

        }
        private void bt_Click(object sender, EventArgs e)
        {
            changeimage((Button)sender);
        }
        private void RestButton(Button btn)
        {
            btn.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
            btn.Tag = "?";
        }
        private void RestartGame()
        {
            RestButton(bt1);
            RestButton(bt2);
            RestButton(bt3);
            RestButton(bt4);
            RestButton(bt5);
            RestButton(bt6);
            RestButton(bt7);
            RestButton(bt8);
            RestButton(bt9);
            playerturn = enplayer.player1;
            lbturn.Text = "Player 1";
            gamestatus.count = 0;
            gamestatus.gameover = false;
            gamestatus.winner = enwinner.gameinprogress;
            lbwinner.Text = "In Progress";
        }

        private void btrestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}

