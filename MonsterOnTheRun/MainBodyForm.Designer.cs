namespace MonsterOnTheRun
{
    partial class MainBodyForm
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.GravityTimer = new System.Windows.Forms.Timer(this.components);
            this.JumpTimer = new System.Windows.Forms.Timer(this.components);
            this.Platform = new System.Windows.Forms.PictureBox();
            this.Platform7 = new System.Windows.Forms.PictureBox();
            this.Platform5 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.Platform1 = new System.Windows.Forms.PictureBox();
            this.Platform2 = new System.Windows.Forms.PictureBox();
            this.Platform6 = new System.Windows.Forms.PictureBox();
            this.Platform4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform4)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Player.Location = new System.Drawing.Point(48, 313);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(25, 25);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Ground.Location = new System.Drawing.Point(-7, 335);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(518, 33);
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            this.Ground.Tag = "Platform";
            // 
            // GravityTimer
            // 
            this.GravityTimer.Enabled = true;
            this.GravityTimer.Interval = 10;
            // 
            // JumpTimer
            // 
            this.JumpTimer.Enabled = true;
            this.JumpTimer.Interval = 20;
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform.Location = new System.Drawing.Point(194, 258);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(100, 20);
            this.Platform.TabIndex = 3;
            this.Platform.TabStop = false;
            this.Platform.Tag = "Platform";
            // 
            // Platform7
            // 
            this.Platform7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform7.Location = new System.Drawing.Point(245, 21);
            this.Platform7.Name = "Platform7";
            this.Platform7.Size = new System.Drawing.Size(100, 20);
            this.Platform7.TabIndex = 4;
            this.Platform7.TabStop = false;
            this.Platform7.Tag = "Platform";
            // 
            // Platform5
            // 
            this.Platform5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform5.Location = new System.Drawing.Point(128, 21);
            this.Platform5.Name = "Platform5";
            this.Platform5.Size = new System.Drawing.Size(100, 20);
            this.Platform5.TabIndex = 5;
            this.Platform5.TabStop = false;
            this.Platform5.Tag = "Platform";
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.platform3.Location = new System.Drawing.Point(392, 58);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(100, 20);
            this.platform3.TabIndex = 6;
            this.platform3.TabStop = false;
            this.platform3.Tag = "Platform";
            // 
            // Platform1
            // 
            this.Platform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform1.Location = new System.Drawing.Point(141, 58);
            this.Platform1.Name = "Platform1";
            this.Platform1.Size = new System.Drawing.Size(100, 20);
            this.Platform1.TabIndex = 7;
            this.Platform1.TabStop = false;
            this.Platform1.Tag = "Platform";
            // 
            // Platform2
            // 
            this.Platform2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform2.Location = new System.Drawing.Point(262, 58);
            this.Platform2.Name = "Platform2";
            this.Platform2.Size = new System.Drawing.Size(100, 20);
            this.Platform2.TabIndex = 8;
            this.Platform2.TabStop = false;
            this.Platform2.Tag = "Platform";
            // 
            // Platform6
            // 
            this.Platform6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform6.Location = new System.Drawing.Point(12, 21);
            this.Platform6.Name = "Platform6";
            this.Platform6.Size = new System.Drawing.Size(100, 20);
            this.Platform6.TabIndex = 9;
            this.Platform6.TabStop = false;
            this.Platform6.Tag = "Platform";
            // 
            // Platform4
            // 
            this.Platform4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Platform4.Location = new System.Drawing.Point(356, 21);
            this.Platform4.Name = "Platform4";
            this.Platform4.Size = new System.Drawing.Size(100, 20);
            this.Platform4.TabIndex = 10;
            this.Platform4.TabStop = false;
            this.Platform4.Tag = "Platform";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainBodyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 361);
            this.Controls.Add(this.Platform4);
            this.Controls.Add(this.Platform6);
            this.Controls.Add(this.Platform2);
            this.Controls.Add(this.Platform1);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.Platform5);
            this.Controls.Add(this.Platform7);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Ground);
            this.Name = "MainBodyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer GravityTimer;
        private System.Windows.Forms.Timer JumpTimer;
        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox Platform7;
        private System.Windows.Forms.PictureBox Platform5;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox Platform1;
        private System.Windows.Forms.PictureBox Platform2;
        private System.Windows.Forms.PictureBox Platform6;
        private System.Windows.Forms.PictureBox Platform4;
        private System.Windows.Forms.Timer timer1;
    }
}

