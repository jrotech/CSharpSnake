namespace SNAKEatestat
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtscore = new System.Windows.Forms.Label();
            this.txthighscore = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.snakebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakebox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(21, 12);
            this.txtscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(73, 19);
            this.txtscore.TabIndex = 1;
            this.txtscore.Text = "Score:";
            // 
            // txthighscore
            // 
            this.txthighscore.AutoSize = true;
            this.txthighscore.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold);
            this.txthighscore.Location = new System.Drawing.Point(308, 12);
            this.txthighscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txthighscore.Name = "txthighscore";
            this.txthighscore.Size = new System.Drawing.Size(111, 19);
            this.txthighscore.TabIndex = 2;
            this.txthighscore.Text = "Highscore";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.PaleGreen;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.start.Location = new System.Drawing.Point(672, 4);
            this.start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(123, 40);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // snakebox
            // 
            this.snakebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.snakebox.Location = new System.Drawing.Point(-2, 48);
            this.snakebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.snakebox.Name = "snakebox";
            this.snakebox.Size = new System.Drawing.Size(829, 537);
            this.snakebox.TabIndex = 0;
            this.snakebox.TabStop = false;
            this.snakebox.Click += new System.EventHandler(this.snakebox_Click);
            this.snakebox.Paint += new System.Windows.Forms.PaintEventHandler(this.snakebox_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 583);
            this.Controls.Add(this.start);
            this.Controls.Add(this.txthighscore);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.snakebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snakebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakebox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label txthighscore;
        private System.Windows.Forms.Button start;
    }
}