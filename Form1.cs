using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SNAKEatestat
{
    public partial class Form1 : Form
    {
        private User currentUser;
        
        public Form1()
        {
            currentUser = null;
            InitializeComponent();
            userLabel.Text = userLabel.Text + " Niciun utilizator conectat";
        }
        //polymorphism achieved by overloading the constructor
        //overloading  = declarat mai multe metode cu acelasi nume
        public Form1(User currentUser)
        {
            this.currentUser= currentUser;
            InitializeComponent();
            userLabel.Text = userLabel.Text + " " + currentUser.getName();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if(currentUser == null)
            {
                MessageBox.Show("No user active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form2 form = new Form2(currentUser);
                form.ShowDialog();
                this.Close();
            }
            
        }

        private void scoresopensql_Click(object sender, EventArgs e)
        {
            this.Hide();
            datatable form = new datatable(currentUser);
            form.ShowDialog();
            this.Close();
        }

        private void registrersql_Click(object sender, EventArgs e)
        {
            this.Hide();
            register form = new register();
            form.ShowDialog();
            this.Close();
        }
        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login form = new login();
            form.ShowDialog();
        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
