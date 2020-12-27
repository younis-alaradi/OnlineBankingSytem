using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            timer.Start();
        }


        private void Right_btn_Click(object sender, EventArgs e)
        {
            Left_panel.Size = new Size(294, 811);
            Left_btn.Visible = true;

            icon_image.Visible = true;
            Right_btn.Visible = false;
            Left_Icon.Visible = false;
            Left_label.Visible = false;
            Left_panel.Visible = false;
            Transition.ShowSync(Left_panel);
            ticks = 0;
            picture_timers(ticks);


        }

        private void Left_btn_Click(object sender, EventArgs e)
        {
            Left_panel.Size = new Size(87, 811);
            Right_btn.Visible = true;
            Left_Icon.Visible = true;
            Left_label.Visible = true;

            icon_image.Visible = false;
            Left_btn.Visible = false;
            Left_panel.Visible = false;
            //Animations
            Transition.ShowSync(Left_panel);

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Form start = new Start_Form();
            start.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {

            var msg = MessageBox.Show("Are you sure do you wnat close the app ?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes) 
            {
                Application.Exit();
            }
            
        
        }
        private int ticks = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;

            picture_timers(ticks - 1);


        }

        private void picture_timers(int tickss)
        {
            if (tickss == 2)
            {
                Step1_pic.Visible = true;
            }
            else if (tickss == 4)
            {
                Step1_pic.Visible = false;
                step2_pic.Visible = true;
            }
            else if (tickss == 5)
            {
                step2_pic.Visible = false;
                step_3_pic.Visible = true;
            }
            else if (tickss == 6)
            {
                step_3_pic.Visible = false;
                step4_pic.Visible = true;
            }
            else if (tickss == 8)
            {
                step4_pic.Visible = false;
                step5_pic.Visible = true;

            }


        }

        private void icon_image_MouseEnter(object sender, EventArgs e)
        {
            icon_image.Size = new Size(320, 320);
        }

        private void icon_image_MouseLeave(object sender, EventArgs e)
        {
            icon_image.Size = new Size(200, 200);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox_1_MouseEnter(object sender, EventArgs e)
        {

            onMouseEnter(PictureBox_1);
        }

        private void PictureBox_1_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeave(PictureBox_1);

        }
        private void onMouseEnter(PictureBox pc) 
        {
            pc.Size = new Size(140, 180);
       
        }
        private void onMouseLeave(PictureBox pc) 
        {
            pc.Size = new Size(104, 113);

        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnter(PictureBox3);
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeave(PictureBox3);
        }

        private void Picturebox_2_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnter(Picturebox_2);
        }

        private void Picturebox_2_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeave(Picturebox_2);
        }


        private void changeFontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            colorDialog.Color = label1.ForeColor;

            colorDialog.ShowDialog();

            label1.ForeColor = colorDialog.Color;

        }

        private void changeFontStyleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog.Font = label1.Font;

            fontDialog.ShowDialog();

            label1.Font = fontDialog.Font;

        }

        private void Calculation_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Open Calculate forms 
            Calculations calculate_Form = new Calculations();
            calculate_Form.ShowDialog();
        }
  
        //Animations
        private void animations(Control panel)  
         {
            panel.Visible = false;
            Transition2.ShowSync(panel);
         }

      
        //Shadows box animation on hover 
        private void guna2ShadowPanel1_MouseHover(object sender, EventArgs e)
        {
            animations(guna2ShadowPanel1);
        }
        private void guna2ShadowPanel3_MouseHover(object sender, EventArgs e)
        {
            animations(guna2ShadowPanel3);
        }
        private void guna2ShadowPanel2_MouseHover(object sender, EventArgs e)
        {
            animations(guna2ShadowPanel2);
        }
        //Groupbox 
        private void guna2GroupBox1_MouseHover(object sender, EventArgs e)
        {
            animations(guna2GroupBox1);
        }

        private void PaysBill_btn_Click(object sender, EventArgs e)
        {
            Hide();
            Pays_Form payForm = new Pays_Form();
            payForm.Show();
        }

        private void Transactions_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions tran = new Transactions();
            tran.ShowDialog();
        }

        private void Exit_bttn_Click(object sender, EventArgs e)
        {
            var RateMessage = MessageBox.Show("Do you want to rate our application", "Rating", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (RateMessage == DialogResult.Yes)
            {
                RatePanel.Visible = true;
            

            }
            else if (RateMessage == DialogResult.No)
            {

                var msg = MessageBox.Show("Do you want close the app ? ", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (msg == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Status accountant = new Account_Status();
            accountant.ShowDialog();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
