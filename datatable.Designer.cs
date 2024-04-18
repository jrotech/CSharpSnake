namespace SNAKEatestat
{
    partial class datatable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snakeusersDataSet = new SNAKEatestat.snakeusersDataSet();
            this.usersTableAdapter = new SNAKEatestat.snakeusersDataSetTableAdapters.usersTableAdapter();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeusersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.highscoreDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 523);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 250;
            // 
            // highscoreDataGridViewTextBoxColumn
            // 
            this.highscoreDataGridViewTextBoxColumn.DataPropertyName = "highscore";
            this.highscoreDataGridViewTextBoxColumn.HeaderText = "highscore";
            this.highscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.highscoreDataGridViewTextBoxColumn.Name = "highscoreDataGridViewTextBoxColumn";
            this.highscoreDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 250;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.snakeusersDataSet;
            // 
            // snakeusersDataSet
            // 
            this.snakeusersDataSet.DataSetName = "snakeusersDataSet";
            this.snakeusersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.goback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.goback.FlatAppearance.BorderSize = 0;
            this.goback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.goback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goback.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.goback.ForeColor = System.Drawing.Color.Black;
            this.goback.Location = new System.Drawing.Point(0, 525);
            this.goback.Margin = new System.Windows.Forms.Padding(0);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(826, 58);
            this.goback.TabIndex = 1;
            this.goback.TabStop = false;
            this.goback.Text = "BACK";
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // datatable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 583);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "datatable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "datatable";
            this.Load += new System.EventHandler(this.datatable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeusersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private snakeusersDataSet snakeusersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private snakeusersDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button goback;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}