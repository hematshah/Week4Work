using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterOnTheRun
{
    public partial class MainBodyForm : Form
    {

        // public bool isJumping = false;
        // int jumpingHigh = 200;



        bool goingLeft;
        bool goingRight;
        bool jumping = false;

        int jumpingSpeed = 10;
        int force = 8;
       // int score = 0;


        public MainBodyForm()
        {
            InitializeComponent();
           
        }


        /*  void MainBodyFormKeys(object sender, KeyEventArgs e) 
          {
              int x = pictureBox1.Location.X;
              int y = pictureBox1.Location.Y;

              switch (e.KeyCode)
              {
                  case Keys.Right:
                       x += 2;
                      pictureBox1.Location = new Point(x,y);
                      break;
                  case Keys.Left:
                      x -= 2;
                      pictureBox1.Location = new Point(x, y);
                      break;
                  case Keys.Space:
                      JumpTimer.Start();
                      break;


                  default:
                      break;
              }

          } */

        /*  void MainBodyFormKeyRelease(object sender, KeyEventArgs e)
          {

              switch (e.KeyCode)
              {

                  case Keys.Space:
                      JumpTimer.Stop();
                      break;


                  default:
                      break;
              }

          }*/

           //private void GravityTimer_Tick(object sender, EventArgs e)
           //{
           //    if (!pictureBox1.Bounds.IntersectsWith(Ground.Bounds) && jumping == false) 
           //    {
           //        pictureBox1.Top += 10;
           //    }

           //    if (jumping == true) 
           //    {
           //        jumping = false;
           //    }
           //}


        //private void keyIsDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Left) 
        //    {
        //        goingLeft = true;
        //    }
        //    if (e.KeyCode == Keys.Right) 
        //    {
        //        goingRight = true;
        //    }
        //    if (e.KeyCode == Keys.Space && !jumping) 
        //    {
        //        jumping = true;
        //    }

        //}

        //private void keyIsUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Left) 
        //    {
        //        goingLeft = false;
        //    }
        //    if (e.KeyCode == Keys.Right) 
        //    {
        //        goingRight = false;
        //    }
        //    if (jumping) 
        //    {
        //        jumping = false;
        //    }

        //}

        //private void JumpTimer_Tick(object sender, EventArgs e)
        //{
        //    pictureBox1.Top = jumpingHigh;
        //    isJumping = true;

        //    pictureBox1.Top += jumpingSpeed;
        //    if (jumping && force < 0)
        //    {
        //        jumping = false;

        //    }
        //    if (goingLeft && pictureBox1.Left > 5)
        //    {
        //        pictureBox1.Left -= 5;
        //    }
        //    if (goingRight && pictureBox1.Left < 455)
        //    {
        //        pictureBox1.Left += 5;
        //    }
        //    if (jumping)
        //    {
        //        jumpingSpeed = -12;
        //        force -= 1;
        //    }
        //    else
        //    {
        //        jumpingSpeed = 12;
        //    }

        //    foreach (Control item in this.Controls)
        //    {
        //        if (item is PictureBox && item.Name == "Platform1")
        //        {
        //            if (pictureBox1.Bounds.IntersectsWith(item.Bounds) && !jumping)
        //            {
        //                //force = 8;
        //                CollisionTop(pictureBox1);
        //                CollisionBottom(Platform1);
        //            }

        //        }


        //        if (item is PictureBox && item.Tag == "Platform") 
        //        {

        //            if (pictureBox1.Bounds.IntersectsWith(item.Bounds) && !jumping)
        //            {
        //                force = 8;
        //                pictureBox1.Top = item.Top - pictureBox1.Height;
        //            }
                    
        //        }    

        //    }
        //}

        private bool CollisionTop(PictureBox pic)
        {
            foreach (Control item in this.Controls)
            {
                if (item != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = item.Bounds;
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);

                    if (pic.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }

            }
            return false;
        }

        private bool CollisionBottom(PictureBox pic)
        {
            foreach (Control item in this.Controls)
            {
                if (item != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = item.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y +temp1.Height, temp1.Width, 1);

                    if (pic.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }

            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goingRight == true) { Player.Left += 5; }
            if (goingLeft == true) { Player.Left -= 5; }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left){ goingLeft = true; }
            if (e.KeyCode == Keys.Right){ goingRight = true;}

            //if (e.KeyCode == Keys.Space && !jumping)
            //{
            //    jumping = true;
            //}

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left){ goingLeft = false; }
            if (e.KeyCode == Keys.Right){ goingRight = false; }
           
            //    if (jumping) 
            //    {
            //        jumping = false;
            //    }

        }

       
    }
}
