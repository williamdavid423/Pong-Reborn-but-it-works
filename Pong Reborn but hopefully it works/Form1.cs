using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Reborn_but_hopefully_it_works
{
    public partial class Form1 : Form
    {
        int scene = 0;

        int paddle1X = 10;
        int paddle1Y = 170;
        int player1Score = 0;

        int paddle2X = 580;
        int paddle2Y = 170;
        int player2Score = 0;

        int paddleWidth = 10;
        int paddleHeight = 60;
        int paddleSpeed = 4;

        int ballX = 295;
        int ballY = 195;
        int ballXSpeed = 6;
        int ballYSpeed = 6;
        int ballWidth = 10;
        int ballHeight = 10;



        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;



        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (scene == 1)
            {
                ballX += ballXSpeed;
                ballY += ballYSpeed;

                if (wDown == true && paddle1Y > 0)
                {
                    paddle1Y -= paddleSpeed;
                }
                if (sDown == true && paddle1Y < this.Height - paddleHeight)
                {
                    paddle1Y += paddleSpeed;
                }

                if (upArrowDown == true && paddle2Y > 0)
                {
                    paddle2Y -= paddleSpeed;
                }
                if (downArrowDown == true && paddle2Y < this.Height - paddleHeight)
                {
                    paddle2Y += paddleSpeed;
                }

                Refresh();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (scene == 1)
            {
                e.Graphics.FillRectangle(whiteBrush, ballX, ballY, ballWidth, ballHeight);

                e.Graphics.FillRectangle(blueBrush, paddle1X, paddle1Y, paddleWidth, paddleHeight);
                e.Graphics.FillRectangle(blueBrush, paddle2X, paddle2Y, paddleWidth, paddleHeight);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (scene == 0) { scene = 1; }

            switch (scene)
            {
                case 0:

                    break;
                case 1:
              
                    fastButton.Visible = false;
                    break;
                case 2:

                    break;
            }
        }
    }
}
