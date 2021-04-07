namespace Pong_Reborn_but_hopefully_it_works
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.fastButton = new System.Windows.Forms.Button();
            this.wallsButton = new System.Windows.Forms.Button();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.twoButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // fastButton
            // 
            this.fastButton.BackColor = System.Drawing.Color.White;
            this.fastButton.Font = new System.Drawing.Font("NewsGoth BdXCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastButton.Location = new System.Drawing.Point(30, 172);
            this.fastButton.Name = "fastButton";
            this.fastButton.Size = new System.Drawing.Size(90, 56);
            this.fastButton.TabIndex = 0;
            this.fastButton.Text = "Fast Pace";
            this.fastButton.UseVisualStyleBackColor = false;
            this.fastButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // wallsButton
            // 
            this.wallsButton.BackColor = System.Drawing.Color.White;
            this.wallsButton.Font = new System.Drawing.Font("NewsGoth BdXCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallsButton.Location = new System.Drawing.Point(167, 172);
            this.wallsButton.Name = "wallsButton";
            this.wallsButton.Size = new System.Drawing.Size(90, 56);
            this.wallsButton.TabIndex = 1;
            this.wallsButton.Text = "Walls";
            this.wallsButton.UseVisualStyleBackColor = false;
            this.wallsButton.Click += new System.EventHandler(this.WallsButton_Click);
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.AutoSize = true;
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Location = new System.Drawing.Point(191, 10);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.p1ScoreLabel.TabIndex = 2;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1ScoreLabel.Visible = false;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Location = new System.Drawing.Point(391, 10);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.p2ScoreLabel.TabIndex = 3;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2ScoreLabel.Visible = false;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(47, 99);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(498, 36);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Visible = false;
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.White;
            this.twoButton.Font = new System.Drawing.Font("NewsGoth BdXCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(319, 172);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(90, 56);
            this.twoButton.TabIndex = 5;
            this.twoButton.Text = "Two Balls";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // swapButton
            // 
            this.swapButton.BackColor = System.Drawing.Color.White;
            this.swapButton.Font = new System.Drawing.Font("NewsGoth BdXCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapButton.Location = new System.Drawing.Point(455, 172);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(90, 56);
            this.swapButton.TabIndex = 6;
            this.swapButton.Text = "Swapped";
            this.swapButton.UseVisualStyleBackColor = false;
            this.swapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.Controls.Add(this.wallsButton);
            this.Controls.Add(this.fastButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button fastButton;
        private System.Windows.Forms.Button wallsButton;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button swapButton;
    }
}

