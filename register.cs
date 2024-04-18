using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SNAKEatestat
{
    public partial class register : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        datatable dt;
        SqlDataReader dr;
        string qs;

        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stefa\OneDrive\Desktop\ATESTAT\SNAKEatestat\snakeusers.mdf;Integrated Security=True");
            con.Open();
        }

        private void registernow_Click(object sender, EventArgs e)
        {
            if(usernamebox.Text != string.Empty || pwbox.Text != string.Empty || confirmpwbox.Text != string.Empty)
            {
                if(pwbox.Text == confirmpwbox.Text)
                {
                    cmd = new SqlCommand("SELECT * FROM users WHERE username='" + usernamebox.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close ();
                        cmd = new SqlCommand("insert into users(username, password) values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", usernamebox.Text);
                        cmd.Parameters.AddWithValue("password", pwbox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logagain_Click(object sender, EventArgs e)
        {
            this.Hide();
            login form = new login();
            form.ShowDialog();
        }
    }
}
