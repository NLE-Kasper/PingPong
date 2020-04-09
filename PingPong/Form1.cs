using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {

        private int speed_vertical = 2;
        private int speed_hor = 2;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            GamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);
            


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) ;
            this.Close();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GamePanel.Left = Cursor.Position.X - (GamePanel.Width / 2);

            Boll.Left += speed_hor;
            Boll.Top += speed_vertical;

            if (Boll.Left <= BackGround.Left)
                speed_hor *= -1;
            if (Boll.Right >= BackGround.Right)
                speed_hor *= -1;
            if (Boll.Top <= BackGround.Top)
                speed_vertical *= -1;
            if (Boll.Bottom >= BackGround.Bottom)
                timer.Enabled = false;

            if (Boll.Bottom >= GamePanel.Top && Boll.Bottom <= GamePanel.Bottom &&
                Boll.Left >= GamePanel.Left && Boll.Right <= GamePanel.Right)
            {
                speed_hor += 2;
                speed_vertical += 2;
                speed_vertical *= -1;
                score += 1;

            }



        }

        
    }
}
