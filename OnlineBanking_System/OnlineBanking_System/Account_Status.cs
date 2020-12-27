using System;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Account_Status : Form
    {
        public Account_Status()
        {
            InitializeComponent();
        }
        private string getName() 
        {
            return Start_Form.U_Name;

        }

        private void Account_Status_Load(object sender, EventArgs e)
        {
            AccountName_label.Text = getName();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            var nut = MessageBox.Show("Are You Sure You Want To Close The Account Status Form And Go Back To Main Form???", "Closing Account Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
            if (nut == DialogResult.Yes)
            {
                this.Hide();
                Main_Form Main = new Main_Form();
                Main.Show();
            }
        }
    }
}
