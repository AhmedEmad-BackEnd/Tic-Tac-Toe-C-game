using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X__O_game.Properties;

namespace X__O_game
{
    public partial class frmGame : Form
    {
        enPlayer PlayerTurn = enPlayer.Player1;
        stGameStatus GameStatus;
        public frmGame()
        {
            InitializeComponent();
        }
        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);
            Pen pen = new Pen(Color.Red);
            Pen pen2 = new Pen(Color.White);
            pen.Width = 10;
            pen2.Width = 10;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;  
            e.Graphics.DrawLine(pen2, 310, 700, 310, 0);//فاصل
            e.Graphics.DrawLine(pen, 620, 580, 620, 80);//vertical
            e.Graphics.DrawLine(pen, 840, 580, 840, 80);//vertical
            e.Graphics.DrawLine(pen, 400, 240, 1050, 240);//horzintal
            e.Graphics.DrawLine(pen, 400, 410, 1050, 410);//horzintal
        }
        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short GameCount;
        }
        void EndGame()
        {
            labChangPlayer.Text = "Game Over";

            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    LapWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    LapWinner.Text = "Player 2";
                    break;
                default:
                    LapWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool CheckValues(Button btn1, Button btn2,Button btn3)
        {
            if(btn1.Tag.ToString()!="?"&&btn1.Tag.ToString()==btn2.Tag.ToString()&&btn1.Tag.ToString()==btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if(btn1.Tag.ToString()=="X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;
            return false;

        }
        public void CheckWinner()
        {


            //checked rows
            //check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;


        }
        public void ChangeImage(Button btn)
        {
            if(btn.Tag.ToString()=="?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.BackgroundImage = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        labChangPlayer.Text = "Player 2";
                        GameStatus.GameCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.BackgroundImage = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        labChangPlayer.Text = "Player 1";
                        GameStatus.GameCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;

                }
                
            }
            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.GameCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        private void RestButton(Button btn)
        {
            btn.BackgroundImage = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }
        private void RestartGame()
        {

            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            labChangPlayer.Text = "Player 1";
            GameStatus.GameCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            LapWinner.Text = "In Progress";
        }
        private void buttonClick(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
