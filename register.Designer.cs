namespace SNAKEatestat
{
    partial class register
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
            this.registernow = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmpwbox = new System.Windows.Forms.TextBox();
            this.logagain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registernow
            // 
            this.registernow.BackColor = System.Drawing.Color.SeaGreen;
            this.registernow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registernow.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.registernow.Location = new System.Drawing.Point(321, 311);
            this.registernow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registernow.Name = "registernow";
            this.registernow.Size = new System.Drawing.Size(165, 71);
            this.registernow.TabIndex = 0;
            this.registernow.Text = "Register";
            this.registernow.UseVisualStyleBackColor = false;
            this.registernow.Click += new System.EventHandler(this.registernow_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(389, 141);
            this.usernamebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(206, 20);
            this.usernamebox.TabIndex = 1;
            // 
            // pwbox
            // 
            this.pwbox.Location = new System.Drawing.Point(389, 188);
            this.pwbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(206, 20);
            this.pwbox.TabIndex = 2;
            this.pwbox.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.username.Location = new System.Drawing.Point(210, 141);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(81, 27);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(210, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(210, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // confirmpwbox
            // 
            this.confirmpwbox.Location = new System.Drawing.Point(389, 231);
            this.confirmpwbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmpwbox.Name = "confirmpwbox";
            this.confirmpwbox.Size = new System.Drawing.Size(206, 20);
            this.confirmpwbox.TabIndex = 5;
            this.confirmpwbox.UseSystemPasswordChar = true;
            // 
            // logagain
            // 
            this.logagain.BackColor = System.Drawing.Color.SeaGreen;
            this.logagain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logagain.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.logagain.Location = new System.Drawing.Point(321, 402);
            this.logagain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logagain.Name = "logagain";
            this.logagain.Size = new System.Drawing.Size(165, 78);
            this.logagain.TabIndex = 7;
            this.logagain.Text = "Already have an account? Login!";
            this.logagain.UseVisualStyleBackColor = false;
            this.logagain.Click += new System.EventHandler(this.logagain_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 583);
            this.Controls.Add(this.logagain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmpwbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pwbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.registernow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registernow;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmpwbox;
        private System.Windows.Forms.Button logagain;
    }
}