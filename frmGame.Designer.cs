namespace X__O_game
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LapWinner = new System.Windows.Forms.Label();
            this.labChangPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Red;
            this.btnRestart.Location = new System.Drawing.Point(34, 431);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(239, 80);
            this.btnRestart.TabIndex = 20;
            this.btnRestart.Text = "Restart Game🔥🔥";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Turn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Winner:";
            // 
            // LapWinner
            // 
            this.LapWinner.AutoSize = true;
            this.LapWinner.BackColor = System.Drawing.Color.Black;
            this.LapWinner.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LapWinner.Location = new System.Drawing.Point(54, 352);
            this.LapWinner.Name = "LapWinner";
            this.LapWinner.Size = new System.Drawing.Size(235, 45);
            this.LapWinner.TabIndex = 7;
            this.LapWinner.Text = "In Progress";
            // 
            // labChangPlayer
            // 
            this.labChangPlayer.AutoSize = true;
            this.labChangPlayer.BackColor = System.Drawing.Color.Black;
            this.labChangPlayer.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChangPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labChangPlayer.Location = new System.Drawing.Point(54, 232);
            this.labChangPlayer.Name = "labChangPlayer";
            this.labChangPlayer.Size = new System.Drawing.Size(171, 45);
            this.labChangPlayer.TabIndex = 8;
            this.labChangPlayer.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(529, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tic-Tac-Toe Game❌⭕";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(446, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 103);
            this.button1.TabIndex = 21;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::X__O_game.Properties.Resources.x________o;
            this.pictureBox1.Image = global::X__O_game.Properties.Resources.x________o;
            this.pictureBox1.Location = new System.Drawing.Point(34, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(869, 444);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 103);
            this.button9.TabIndex = 22;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonClick);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(659, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 103);
            this.button8.TabIndex = 23;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonClick);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(446, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 103);
            this.button7.TabIndex = 24;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonClick);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(869, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 103);
            this.button6.TabIndex = 25;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonClick);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(671, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 103);
            this.button5.TabIndex = 26;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonClick);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(446, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 103);
            this.button4.TabIndex = 27;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonClick);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(869, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 103);
            this.button3.TabIndex = 28;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::X__O_game.Properties.Resources.question_mark_96;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(659, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 103);
            this.button2.TabIndex = 29;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(34, 538);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(239, 80);
            this.button10.TabIndex = 30;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1116, 630);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labChangPlayer);
            this.Controls.Add(this.LapWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LapWinner;
        private System.Windows.Forms.Label labChangPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
    }
}