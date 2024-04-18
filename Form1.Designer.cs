namespace SNAKEatestat
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
            this.close = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.registrersql = new System.Windows.Forms.Button();
            this.scoresopensql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.close.Location = new System.Drawing.Point(598, 493);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(171, 46);
            this.close.TabIndex = 0;
            this.close.Text = "Exit";
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.GreenYellow;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play.Location = new System.Drawing.Point(78, 314);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(130, 56);
            this.play.TabIndex = 1;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // registrersql
            // 
            this.registrersql.BackColor = System.Drawing.Color.YellowGreen;
            this.registrersql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrersql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrersql.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrersql.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrersql.Location = new System.Drawing.Point(78, 435);
            this.registrersql.Name = "registrersql";
            this.registrersql.Size = new System.Drawing.Size(130, 56);
            this.registrersql.TabIndex = 2;
            this.registrersql.Text = "Register";
            this.registrersql.UseVisualStyleBackColor = false;
            this.registrersql.Click += new System.EventHandler(this.registrersql_Click);
            // 
            // scoresopensql
            // 
            this.scoresopensql.BackColor = System.Drawing.Color.ForestGreen;
            this.scoresopensql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scoresopensql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoresopensql.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresopensql.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoresopensql.Location = new System.Drawing.Point(78, 372);
            this.scoresopensql.Name = "scoresopensql";
            this.scoresopensql.Size = new System.Drawing.Size(130, 56);
            this.scoresopensql.TabIndex = 3;
            this.scoresopensql.Text = "Leaderboard";
            this.scoresopensql.UseVisualStyleBackColor = false;
            this.scoresopensql.Click += new System.EventHandler(this.scoresopensql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 126);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "SNAKE GAME";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Lime;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(78, 493);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(130, 56);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.userLabel.Location = new System.Drawing.Point(29, 268);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(110, 27);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Current User:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SNAKEatestat.Properties.Resources.snake1;
            this.pictureBox1.Location = new System.Drawing.Point(598, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 583);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoresopensql);
            this.Controls.Add(this.registrersql);
            this.Controls.Add(this.play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button registrersql;
        private System.Windows.Forms.Button scoresopensql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

