namespace PongGame
{
    partial class Pong
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
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player1.Location = new System.Drawing.Point(12, 253);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(30, 181);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player2.Location = new System.Drawing.Point(1510, 253);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(30, 181);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.Location = new System.Drawing.Point(753, 317);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(34, 34);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.BackColor = System.Drawing.Color.Transparent;
            this.player1Score.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1Score.Location = new System.Drawing.Point(554, 51);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(33, 34);
            this.player1Score.TabIndex = 3;
            this.player1Score.Text = "0";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2Score.Location = new System.Drawing.Point(929, 51);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(33, 34);
            this.player2Score.TabIndex = 4;
            this.player2Score.Text = "0";
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(652, 467);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(238, 88);
            this.start.TabIndex = 5;
            this.start.Text = "Press to Play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1569, 749);
            this.Controls.Add(this.start);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Button start;
    }
}

