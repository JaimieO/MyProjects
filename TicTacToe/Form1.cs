using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTow
{
    public partial class Form1 : Form
    {
        private bool win = false;
        private int[,] arr = new int[3,3];
        private int i = new int();
        private int j = new int();
        private int count = new int();
        private int row = new int();
        private bool player1 = true;
        private bool player2 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Blue); 
            g.DrawLine(p,120,170,490,170);
            g.DrawLine(p,120,330,490,330);
            g.DrawLine(p,220,70,220,430);
            g.DrawLine(p,390,70,390,430);
            Playe1_Button.BackColor = Color.DarkCyan;
            Playe1_Button.ForeColor = Color.Cyan;
            Array.Clear(arr, 0, 9);//מחיקה של מערך,(כמות התאים למחיקה, מיקום התחלתי במערך, שם המערך) שש
            count = 0;
            player1 = true;
            player2 = false;
            win = false;
            textBox1.Text = "";
        }

        private void Player2_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Playe1_Button_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!win)
            {
                if (e.X >= 120 && e.X <= 220 && e.Y >= 70 && e.Y <= 170 && arr[0, 0] == 0) //שמאל למעלה
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(140, 150, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[0, 0] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 140, 150, 140 + 50, 150 - 50);
                        g.DrawLine(p, 140, 150 - 50, 140 + 50, 150);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[0, 0] = 1;
                    }
                }
                else if (e.X >= 390 && e.X <= 490 && e.Y >= 70 && e.Y <= 170 && arr[0, 2] == 0) // ימין למעלה
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(410, 150, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[0, 2] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 410, 150, 410 + 50, 150 - 50);
                        g.DrawLine(p, 410, 150 - 50, 410 + 50, 150);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[0, 2] = 1;
                    }
                }
                else if (e.X >= 120 && e.X <= 220 && e.Y >= 330 && e.Y <= 430 && arr[2, 0] == 0)// שמאל למטה
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(140, 410, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[2, 0] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 140, 410, 140 + 50, 410 - 50);
                        g.DrawLine(p, 140, 410 - 50, 140 + 50, 410);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[2, 0] = 1;
                    }
                }
                else if (e.X >= 390 && e.X <= 490 && e.Y >= 330 && e.Y <= 430 && arr[2, 2] == 0)// ימין למטה
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(410, 410, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[2, 2] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 410, 410, 410 + 50, 410 - 50);
                        g.DrawLine(p, 410, 410 - 50, 410 + 50, 410);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[2, 2] = 1;
                    }
                }
                else if (e.X >= 120 && e.X <= 220 && e.Y >= 170 && e.Y <= 330 && arr[1, 0] == 0) // שמאל אמצע
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(140, 280, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[1, 0] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 140, 280, 140 + 50, 280 - 50);
                        g.DrawLine(p, 140, 280 - 50, 140 + 50, 280);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[1, 0] = 1;
                    }
                }
                else if (e.X >= 390 && e.X <= 490 && e.Y >= 170 && e.Y <= 330 && arr[1, 2] == 0)// ימין אמצע
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(410, 280, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[1, 2] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 410, 280, 410 + 50, 280 - 50);
                        g.DrawLine(p, 410, 280 - 50, 410 + 50, 280);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[1, 2] = 1;
                    }
                }
                else if (e.X >= 220 && e.X <= 390 && e.Y >= 70 && e.Y <= 170 && arr[0, 1] == 0)// אמצע למעלה
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(280, 150, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[0, 1] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 280, 150, 280 + 50, 150 - 50);
                        g.DrawLine(p, 280, 150 - 50, 280 + 50, 150);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[0, 1] = 1;
                    }
                }
                else if (e.X >= 220 && e.X <= 390 && e.Y >= 330 && e.Y <= 430 && arr[2, 1] == 0)// אמצע למטה
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(280, 410, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[2, 1] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 280, 410, 280 + 50, 410 - 50);
                        g.DrawLine(p, 280, 410 - 50, 280 + 50, 410);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[2, 1] = 1;
                    }
                }
                else if (e.X >= 220 && e.X <= 390 && e.Y >= 170 && e.Y <= 330 && arr[1, 1] == 0)// אמצע
                {
                    if (player2)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.MediumPurple);
                        Rectangle r = new Rectangle(280, 275, 60, -60);
                        g.DrawEllipse(p, r);
                        player2 = false;
                        player1 = true;
                        Playe1_Button.BackColor = Color.DarkCyan;
                        Playe1_Button.ForeColor = Color.Cyan;
                        Player2_button.BackColor = Color.MediumPurple;
                        Player2_button.ForeColor = Color.Indigo;
                        arr[1, 1] = 2;
                    }
                    else if (player1)
                    {
                        Graphics g = this.CreateGraphics();
                        Pen p = new Pen(Color.Cyan);
                        g.DrawLine(p, 280, 275, 280 + 50, 275 - 50);
                        g.DrawLine(p, 280, 275 - 50, 280 + 50, 275);
                        player2 = true;
                        player1 = false;
                        Playe1_Button.BackColor = Color.Cyan;
                        Playe1_Button.ForeColor = Color.DarkCyan;
                        Player2_button.BackColor = Color.Indigo;
                        Player2_button.ForeColor = Color.MediumPurple;
                        arr[1, 1] = 1;
                    }
                }


                for (i = 0; i < 3; i++)
                {

                    if (arr[i, j] == arr[i, j + 1] && arr[i, j] == arr[i, j + 2] && arr[i, j] != 0)
                    {
                        win = true;
                        break;
                    }
                    count++;

                    if (arr[row, i] == arr[row + 1, i] && arr[row, i] == arr[row + 2, i] && arr[row, i] != 0)
                    {
                        win = true;
                        break;
                    }
                    count++;

                    if (count < 5)
                    {
                        if (arr[i, j] == arr[i + 1, j + 1] && arr[i, j] == arr[i + 2, j + 2] && arr[i, j] != 0)
                        {
                            win = true;
                            break;
                        }

                        count++;
                    }
                    if (count < 5)
                    {
                        if (arr[i, j + 2] == arr[i + 1, j + 1] && arr[i, j + 2] == arr[i + 2, j] && arr[i, j + 2] != 0)
                        {
                            win = true;
                            break;
                        }
                        if (count < 5)
                            count++;
                    }
                }
            }
            if(win)
            {
                if(!player1)
                {
                    textBox1.Text = "Player 1 Wins!!!";
                    textBox1.ForeColor = Color.Cyan;
                }
                if(!player2)
                {
                    textBox1.Text = "Player 2 Wins!!!";
                    textBox1.ForeColor = Color.MediumPurple;
                }
                Graphics g = this.CreateGraphics();
                Pen p1 = new Pen(Color.Red);
                switch (count)
                {
                    case 0: g.DrawLine(p1, 120, 120, 490, 120);//שורה למעלה
                        break;
                    case 1: g.DrawLine(p1, 170, 70, 170, 430);//טור שמאל
                        break;
                    case 2: g.DrawLine(p1, 120, 70, 490, 430);//אלכסון שמאל למעלה
                        break;
                    case 3: g.DrawLine(p1, 120, 430, 490, 70);//אלכסון שמאל למטה
                        break;
                    case 4: g.DrawLine(p1, 120, 250, 490, 250);//שורה אמצע
                        break;
                    case 5: g.DrawLine(p1, 305, 70, 305, 430);//טור אמצעי
                        break;
                    case 6: g.DrawLine(p1, 120, 380, 490, 380);//שורה למטה
                        break;
                    case 7: g.DrawLine(p1, 440, 70, 440, 430);//טור ימני
                        break;
                }
            }
            else
            {
                count = 0;
            }


        }

        }
}
    

