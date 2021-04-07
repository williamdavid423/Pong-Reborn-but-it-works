using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pong_Reborn_but_hopefully_it_works
{
    public partial class Form1 : Form
    {
        int scene = 0;

        int wallSpeed = 5;
        int wall1X = 195;
        int wall1Y = 160;
        int wallWidth = 10;
        int wallHeight = 80;

        int wall2X = 395;
        int wall2Y = 160;


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
        int ball2X = 295;
        int ball2Y = 205;
        int ballXSpeed = 6;
        int ballYSpeed = 6;
        int ballWidth = 10;
        int ballHeight = 10;



        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;


        Pen blackPen = new Pen(Color.White);
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
                gameMechanics();

                Rectangle player1Rec = new Rectangle(paddle1X, paddle1Y, paddleWidth, paddleHeight);
                Rectangle player2Rec = new Rectangle(paddle2X, paddle2Y, paddleWidth, paddleHeight);
                Rectangle ballRec = new Rectangle(ballX, ballY, ballWidth, ballHeight);

                if (player1Rec.IntersectsWith(ballRec))
                {
                    ballXSpeed *= Convert.ToInt32(-1.1);
                    ballX = paddle1X + paddleWidth + 1;
                }
                if (player2Rec.IntersectsWith(ballRec))
                {
                    ballXSpeed *= Convert.ToInt32(-1.1);
                    ballX = paddle2X - ballWidth - 1;
                }



                Console.WriteLine(paddle1Y);
                Refresh();
            }
            if (scene == 2)
            {
                Rectangle player1Rec = new Rectangle(paddle1X, paddle1Y, paddleWidth, paddleHeight);
                Rectangle player2Rec = new Rectangle(paddle2X, paddle2Y, paddleWidth, paddleHeight);
                Rectangle ballRec = new Rectangle(ballX, ballY, ballWidth, ballHeight);
                Rectangle wall1Rec = new Rectangle(wall1X, wall1Y, wallWidth, wallHeight);
                Rectangle wall2Rec = new Rectangle(wall2X, wall2Y, wallWidth, wallHeight);

                gameMechanics();

                if (player1Rec.IntersectsWith(ballRec))
                {
                    ballXSpeed *= -1;
                    ballX = paddle1X + paddleWidth + 1;
                }
                if (player2Rec.IntersectsWith(ballRec))
                {
                    ballXSpeed *= -1;
                    ballX = paddle2X - ballWidth - 1;
                }

                wall1Y += wallSpeed;

                if (wall1Y < 100)
                {
                    wallSpeed *= -1;
                }
                else if (wall1Y + wallHeight > 300)
                {
                    wallSpeed *= -1;
                }

                wall2Y -= wallSpeed;

                if (wall1Y < 100)
                {
                    wallSpeed *= -1;
                }
                else if (wall2Y + wallHeight > 300)
                {
                    wallSpeed *= -1;
                }
                if (wall1Rec.IntersectsWith(ballRec))
                {
                    ballXSpeed *= -1;
                }
                if (wall2Rec.IntersectsWith(ballRec))
                {
                    ballXSpeed *= -1;
                }

                scoring();

                Refresh();


            }
            if (scene == 3)
            {
                paddleSpeed = 6;

                gameMechanics();
                if (ball2Y < 0)
                {
                    ballYSpeed *= -1;
                }
                else if (ball2Y + ballHeight > 400)
                {
                    ballYSpeed *= -1;
                }


                ball2X -= ballXSpeed;
                ball2Y -= ballYSpeed;

                if (ballX > 600)
                {
                    player1Score++;
                    p1ScoreLabel.Text = $"{player1Score}";

                    ballX = 295;
                    ballY = 185;
                }
                else if (ballX < 0)
                {
                    player2Score++;
                    p2ScoreLabel.Text = $"{player2Score}";

                    ballX = 295;
                    ballY = 185;
                }

                if (ball2X > 600)
                {
                    player1Score++;
                    p1ScoreLabel.Text = $"{player1Score}";

                    ball2X = 295;
                    ball2Y = 205;
                }
                else if (ball2X < 0)
                {
                    player2Score++;
                    p2ScoreLabel.Text = $"{player2Score}";

                    ball2X = 295;
                    ball2Y = 205;
                }

                if (player1Score == 3)
                {
                    outputLabel.Visible = true;
                    outputLabel.Text = "Player 1 Wins";
                    Refresh();
                    Thread.Sleep(1000);
                    scene = 0;
                    player1Score = 0;
                    player2Score = 0;
                    p1ScoreLabel.Text = "0";
                    p2ScoreLabel.Text = "0";
                    outputLabel.Text = "";
                    outputLabel.Visible = false;
                    p1ScoreLabel.Visible = false;
                    p2ScoreLabel.Visible = false;
                    fastButton.Visible = true;
                    wallsButton.Visible = true;
                    twoButton.Visible = true;
                    Refresh();
                    gameTimer.Enabled = false;
                }
                else if (player2Score == 3)
                {
                    outputLabel.Visible = true;
                    outputLabel.Text = "Player 2 Wins";
                    Refresh();
                    Thread.Sleep(1000);
                    scene = 0;
                    player1Score = 0;
                    player2Score = 0;
                    p1ScoreLabel.Text = "0";
                    p2ScoreLabel.Text = "0";
                    outputLabel.Text = "";
                    outputLabel.Visible = false;
                    p1ScoreLabel.Visible = false;
                    p2ScoreLabel.Visible = false;
                    fastButton.Visible = true;
                    wallsButton.Visible = true;
                    twoButton.Visible = true;
                    Refresh();
                    gameTimer.Enabled = false;
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
                if (scene == 2)
                {
                    e.Graphics.FillRectangle(whiteBrush, ballX, ballY, ballWidth, ballHeight);

                    e.Graphics.FillRectangle(blueBrush, paddle1X, paddle1Y, paddleWidth, paddleHeight);
                    e.Graphics.FillRectangle(blueBrush, paddle2X, paddle2Y, paddleWidth, paddleHeight);

                    e.Graphics.DrawRectangle(blackPen, wall1X, wall1Y, wallWidth, wallHeight);
                    e.Graphics.FillRectangle(whiteBrush, wall1X, wall1Y, wallWidth, wallHeight);

                    e.Graphics.DrawRectangle(blackPen, wall2X, wall2Y, wallWidth, wallHeight);
                    e.Graphics.FillRectangle(whiteBrush, wall2X, wall2Y, wallWidth, wallHeight);

                }
                if (scene == 3)
                {
                    e.Graphics.FillRectangle(whiteBrush, ballX, ballY, ballWidth, ballHeight);
                    e.Graphics.FillRectangle(whiteBrush, ball2X, ball2Y, ballWidth, ballHeight);

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
                        player1Score = 0;
                        player2Score = 0;
                        p1ScoreLabel.Visible = false;
                        p2ScoreLabel.Visible = false;
                        fastButton.Visible = true;
                        wallsButton.Visible = true;

                        break;
                    case 1:
                        gameTimer.Enabled = true;
                        fastButton.Visible = false;
                        wallsButton.Visible = false;
                        twoButton.Visible = false;
                        p1ScoreLabel.Visible = true;
                        p2ScoreLabel.Visible = true;
                        paddleSpeed = 6;
                        this.Focus();
                        break;

                }
            }

            private void WallsButton_Click(object sender, EventArgs e)
            {
                if (scene == 0) { scene = 2; }

                switch (scene)
                {
                    case 2:
                        gameTimer.Enabled = true;
                        fastButton.Visible = false;
                        wallsButton.Visible = false;
                        twoButton.Visible = false;
                        p1ScoreLabel.Visible = true;
                        p2ScoreLabel.Visible = true;
                        this.Focus();
                        break;
                }
            }
            public void gameMechanics()
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

                if (ballY < 0)
                {
                    ballYSpeed *= -1;
                }
                else if (ballY + ballHeight > 400)
                {
                    ballYSpeed *= -1;
                }
            }
            private void scoring()
            {
                if (ballX > 600)
                {
                    player1Score++;
                    p1ScoreLabel.Text = $"{player1Score}";

                    ballX = 295;
                    ballY = 195;
                    wall1X = 195;
                    wall1Y = 160;
                    wall2X = 395;
                    wall2Y = 160;
                    paddle1X = 10;
                    paddle1Y = 170;
                    paddle2X = 580;
                    paddle2Y = 170;
                }
                else if (ballX < 0)
                {
                    player2Score++;
                    p2ScoreLabel.Text = $"{player2Score}";

                    ballX = 295;
                    ballY = 195;
                    ballX = 295;
                    ballY = 195;
                    wall1X = 195;
                    wall1Y = 160;
                    wall2X = 395;
                    wall2Y = 160;
                    paddle1X = 10;
                    paddle1Y = 170;
                    paddle2X = 580;
                    paddle2Y = 170;
                }
                if (player1Score == 3)
                {
                    outputLabel.Visible = true;
                    outputLabel.Text = "Player 1 Wins";
                    Refresh();
                    Thread.Sleep(1000);
                    scene = 0;
                    player1Score = 0;
                    player2Score = 0;
                    p1ScoreLabel.Text = "0";
                    p2ScoreLabel.Text = "0";
                    outputLabel.Text = "";
                    outputLabel.Visible = false;
                    p1ScoreLabel.Visible = false;
                    p2ScoreLabel.Visible = false;
                    fastButton.Visible = true;
                    wallsButton.Visible = true;
                    twoButton.Visible = true;
                    Refresh();
                    gameTimer.Enabled = false;
                }
                else if (player2Score == 3)
                {
                    outputLabel.Visible = true;
                    outputLabel.Text = "Player 2 Wins";
                    Refresh();
                    Thread.Sleep(1000);
                    scene = 0;
                    player1Score = 0;
                    player2Score = 0;
                    p1ScoreLabel.Text = "0";
                    p2ScoreLabel.Text = "0";
                    outputLabel.Text = "";
                    outputLabel.Visible = false;
                    p1ScoreLabel.Visible = false;
                    p2ScoreLabel.Visible = false;
                    fastButton.Visible = true;
                    wallsButton.Visible = true;
                    twoButton.Visible = true;
                    Refresh();
                    gameTimer.Enabled = false;
                }
            }

            private void TwoButton_Click(object sender, EventArgs e)
            {
                if (scene == 0) { scene = 3; }

                switch (scene)
                {
                    case 3:
                        ballY = 185;
                        gameTimer.Enabled = true;
                        fastButton.Visible = false;
                        wallsButton.Visible = false;
                        twoButton.Visible = false;
                        p1ScoreLabel.Visible = true;
                        p2ScoreLabel.Visible = true;
                        this.Focus();
                        break;
                }
            }
        }
    }
