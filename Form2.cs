using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKEatestat
{
    public partial class Form2 : Form
    {

        //SNAKE UL
        private List<circle> snake = new List<circle>(); /// class we created and the constructor called
        private circle food = new circle();

        int maxwidth;
        int maxheight;

        int score;
        int highscore;
        User currentUser;
        Random rand = new Random();

        bool goleft, goright, godown, goup;

        int spaceBarClicked = 0;

        public Form2()
        {
            currentUser=null;
            InitializeComponent();
            new settings();
        }
        public Form2(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            new settings();
        }
        private void snakebox_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics; ///leaga the e event to the canvas
            
            Brush snakecolor;
            for (int i = 0; i < snake.Count; i++)
            {

                if (i == 0)
                {
                    snakecolor = Brushes.Black;
                }
                else
                {
                    snakecolor = Brushes.DarkBlue;
                    
                }

                canvas.FillEllipse(snakecolor, new Rectangle
                    (snake[i].x * settings.width,
                    snake[i].y * settings.height,
                    settings.width, settings.height
                    ));

            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                    (food.x * settings.width,
                    food.y * settings.height,
                    settings.width, settings.height
                    ));

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goleft)
                settings.direction = "left";

            if (goright)
                settings.direction = "right";

            if (goup)
                settings.direction = "up";

            if (godown)
                settings.direction = "down";

            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (settings.direction)
                    {
                        case "left":
                            snake[i].x--;
                            break;
                        case "right":
                            snake[i].x++;
                            break;
                        case "up":
                            snake[i].y--;
                            break;
                        case "down":
                            snake[i].y++;
                            break;
                    }

                    if (snake[i].x < 0)
                    {
                        snake[i].x = maxwidth;
                    }
                    if (snake[i].x > maxwidth)
                    {
                        snake[i].x = 0;
                    }

                    if (snake[i].y < 0)
                    {
                        snake[i].y = maxheight;
                    }
                    if (snake[i].y > maxheight)
                    {
                        snake[i].y = 0;
                    }

                    if (snake[i].x == food.x && snake[i].y == food.y)
                    {
                        eatfood(); ///adauga food la body
                    }

                    for(int j=1; j<snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x && snake[i].y == snake[j].y)
                        {

                            gameover();
                        }
                    }

                }
                else
                {
                    snake[i].x = snake[i - 1].x; ///animatia de miscare continua a snake ului
                    snake[i].y = snake[i - 1].y;
                }
            }


            snakebox.Invalidate();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            ///directiile in care se misca snake ul
            if (e.KeyCode == Keys.Left && settings.direction != "right")
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right && settings.direction != "left")
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up && settings.direction != "down")
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down && settings.direction != "up")
            {
                godown = true;
            }

            //if player presses space pause game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    timer1.Stop();
                    this.Hide();
                ///    MessageBox.Show("Are you sure");
                    Form1 form = new Form1(currentUser);
                    form.ShowDialog();
                    this.Close();
                }
              
                
                spaceBarClicked++;

            }

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

       
        private void start_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                int sc = currentUser.getHighscore();
                Console.Write(sc);
                txthighscore.Text = txthighscore.Text + ": " + Convert.ToString(currentUser.getHighscore());
            }
            Restartgame();
            
                
        }

        private void snakebox_Click(object sender, EventArgs e)
        {

        }

        public void Restartgame()
        {
            maxwidth = snakebox.Width / settings.width - 1;
            maxheight = snakebox.Height/  settings.height - 1;

            snake.Clear();

            start.Enabled = false;

            score = 0;
            txtscore.Text = "Score : " + score;

            circle head = new circle { x = 10, y = 5 };
            snake.Add(head); ///ad capul la snake


            for (int i = 0; i < 10; i++)
            {
                circle body = new circle();
                snake.Add(body);
            }

             food = new circle { x = rand.Next(2, maxwidth), y = rand.Next(2, maxheight) };


            timer1.Start();
        }

        private void eatfood()
        {
            score += 1;
            txtscore.Text  = "Score : " + score;
            circle body = new circle
            {
                x = snake[snake.Count - 1].x,
                y = snake[snake.Count - 1].y
            };

            snake.Add(body);

            food = new circle { x = rand.Next(2, maxwidth), y = rand.Next(2, maxheight) };

        }


        private void gameover()
        {
            timer1.Stop();
            start.Enabled = true;

            if(score > highscore)
            {
                highscore = score;
                SqlConnection con;
                SqlCommand cmd;
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stefa\OneDrive\Desktop\ATESTAT\SNAKEatestat\snakeusers.mdf;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand(@"UPDATE users SET highscore = " + Convert.ToString(highscore) + " WHERE username IN (SELECT username FROM users WHERE username = '" + currentUser.getName() + "')", con);

                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(@"UPDATE users SET date = GETDATE() WHERE username IN (SELECT username FROM users WHERE username = '" + currentUser.getName() + "')", con);
                cmd.ExecuteNonQuery();
                txthighscore.Text = "Scor maxim : "  + highscore;
                txthighscore.ForeColor = Color.Maroon;
                txthighscore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

    }
}

