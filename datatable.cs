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

namespace SNAKEatestat
{
    public partial class datatable : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        User currentUser;
        public datatable()
        {
            InitializeComponent();
            currentUser = null;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stefa\OneDrive\Desktop\ATESTAT\SNAKEatestat\snakeusers.mdf;Integrated Security=True");
            con.Open();
            afisare();
        }
        public datatable(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stefa\OneDrive\Desktop\ATESTAT\SNAKEatestat\snakeusers.mdf;Integrated Security=True");
            con.Open();
            afisare();
        }

        void afisare()
        {
            string qs = @"SELECT username, highscore, date FROM users";

            cmd = new SqlCommand(qs, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void datatable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'snakeusersDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.snakeusersDataSet.users);

        }

        private void goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form;
            if (currentUser != null)
            {
                form = new Form1(currentUser);
            }  
            else
            {
                form = new Form1();
            }
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
