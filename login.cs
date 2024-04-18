using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SNAKEatestat
{
    public partial class login : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public login()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (pw.Text != string.Empty || username.Text != string.Empty)
            {
                cmd = new SqlCommand (@"SELECT * FROM users WHERE username ='" + username.Text + "' AND password ='" + pw.Text + "'",con);
                dr= cmd.ExecuteReader ();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    int currentHighscore = 0;
                    string currentDate = null ;
                    string currentUsername = username.Text;
                    cmd = new SqlCommand (@"SELECT highscore FROM users WHERE username ='" + username.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        currentHighscore = dr.GetInt32(0);
                    }
                    dr.Close();

                    cmd = new SqlCommand(@"SELECT date FROM users WHERE username ='" + username.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                         currentDate = Convert.ToString(DateTime.Now.ToString());
                    }
                    dr.Close();
                    User currentUser = new User(currentUsername, currentHighscore, currentDate);
                    Form1 form = new Form1(currentUser);
                    form.ShowDialog();
                }
                else
                {
                    dr.Close ();
                    MessageBox.Show("Nu exista cont cu acest nume și parolă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vă rog introduceți informații în toate câmpurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stefa\OneDrive\Desktop\ATESTAT\SNAKEatestat\snakeusers.mdf;Integrated Security=True");
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register form = new register();
            form.ShowDialog();
        }
    }
}
