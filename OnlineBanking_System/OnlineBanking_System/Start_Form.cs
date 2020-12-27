using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }
        //Require Attribute
        public static string UserName ;
        public static string U_Name;
        public static int User_ID;
        public static int Amount;
        //Functions
        private  void Hide_panel(Panel pnl) 
        {
            pnl.Visible = false;
        }
        private void Show_panel(Panel pnl) 
        {
            pnl.Visible = true;
        }

        private void inner_closePage_Click(object sender, EventArgs e)
        {
            //Return the sign in panel to default size 
            SignIn_panel.Size = new Size(474, 770);
            //return the sign up panel to default size 
            SignUp_panel.Size = new Size(741, 770);
            //Show the signup panel 
            Show_panel(SignUp_panel);
            //close inner panel sign in 
            Hide_panel(Inner_panel_DDesign);            
            Transition.ShowSync(SignIn_panel);
        }

        private void Signin_btn_show_panel_Click(object sender, EventArgs e)
        {
            //hide sign up panel 
            Hide_panel(SignUp_panel);
            //New sign in panel size 
            Hide_panel(SignIn_panel);
            MessageBox.Show("Hint for admin sing in \n Name : admin \n password : adminadmin", "Sign in Note ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SignIn_panel.Size = new Size(1212, 770);
            Transition.ShowSync(SignIn_panel);
            //show the inner design panel 
            Show_panel(Inner_panel_DDesign);
            Hide_panel(Inner_panel_DDesign);
            Transition.ShowSync(Inner_panel_DDesign);
        }

        private void Exit_pictureBox_Click(object sender, EventArgs e)
        {
           
            var msg = MessageBox.Show("Are you sure do you want close application ?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Messagebox to close the form by yesNo button 
            if (msg == DialogResult.Yes)
            { //Exit the app or you can use this.close() ;
                Application.Exit();
            }
        
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineBankingSystemDBDataset1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.onlineBankingSystemDBDataset1.Users);
            Random random = new Random();
            Amount = random.Next(1, 90000);
        }

        void Wating()
        {
            //wating functions , using thread . sleep (500) 
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);
            }
        }
        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                //check inner name box if it's empty
                if (Signin_NameTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Error empty box", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Signin_NameTextBox.Focus();
                }
                else if (signin_PasswordTextBox.Text == string.Empty)
                {//check password field if it's empty
                    MessageBox.Show("Error empty password box", "Empty detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    signin_PasswordTextBox.Focus();
                }
                else if (signin_PasswordTextBox.Text.Length < 8)
                {//validate password length 
                    MessageBox.Show("Error short password , password should be 8 digit or more ", "short password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    signin_PasswordTextBox.Focus();
                    signin_PasswordTextBox.SelectAll();
                }
              else if (usersTableAdapter.get_Name(Signin_NameTextBox.Text) != null)
                {//check the name from database
                    if (usersTableAdapter.get_Password(signin_PasswordTextBox.Text) != null)
                    {
                        //check password and open the form
                        UserName = "Welcome Back " + Signin_NameTextBox.Text;
                        U_Name = Signin_NameTextBox.Text;
                        User_ID = int.Parse(usersTableAdapter.Get_User_ID(Signin_NameTextBox.Text).ToString());
                        // MessageBox.Show(usersTableAdapter.get_Name(Signin_NameTextBox.Text), "Welcome Back", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Display the loading form
                        this.Hide();
                        using (Loading_Form frm = new Loading_Form(Wating))
                        {
                            frm.ShowDialog(this);
                        }
                        //Display the main form 
                        Main_Form main = new Main_Form();
                        main.Show();
                    }
                    else 
                    {
                        //display error messsage if password error 
                        MessageBox.Show("Error Password Entry", "Error name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        signin_PasswordTextBox.Focus();
                        signin_PasswordTextBox.SelectAll();
                    }
                }
                else 
                {//Display an error message if name incorrect
                    MessageBox.Show("Error Name Entry", "Error name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Signin_NameTextBox.Focus();
                    Signin_NameTextBox.SelectAll();
                }
            }
            catch (Exception data_entry) 
            {//Display exception message error if there some error detected , keep it is needed 
                MessageBox.Show(data_entry.Message, "Exception message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_textbox.Text == string.Empty) 
                {
                    MessageBox.Show("Empty ID Box", "Empty detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID_textbox.Focus();
                }
                //check the signup name box if it's empty 
                if (Name_TextBox.Text == string.Empty)
                {
                    MessageBox.Show("Empty Name Box", "Empty detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Name_TextBox.Focus();

                }//check te signup password box if it's empty 
                else if (Password_TextBox.Text == string.Empty)
                {
                    MessageBox.Show("Empty Password Box", "Empty detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Password_TextBox.Focus();
                }
                else if (Email_textBox.Text == string.Empty)
                {//Check email box
                    MessageBox.Show("Please enter your email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Email_textBox.Focus();
                }
                //check the digit of password 
                else if (Password_TextBox.Text.Length < 8)
                {
                    MessageBox.Show("Hint: short password , password should be 8 digit or more ", "short password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Password_TextBox.Focus();
                    Password_TextBox.SelectAll();
                }
                else if (ID_textbox.Text.Length < 9) 
                {
                    MessageBox.Show("Hint: short ID , ID should 9 digit or more ", "Short user ID ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID_textbox.Focus();
                    ID_textbox.SelectAll();
                }
                else
                {
                    //Enter new data  iin database 
                    OnlineBankingSystemDBDataset.UsersRow row;
                    row = onlineBankingSystemDBDataset1.Users.NewUsersRow();

                    row.User_ID = int.Parse(ID_textbox.Text);
                    User_ID = int.Parse(ID_textbox.Text);
                    U_Name = Name_TextBox.Text;
                    row.Name = Name_TextBox.Text;
                    row.Email = Email_textBox.Text;
                    row.Password = Password_TextBox.Text;
                    onlineBankingSystemDBDataset1.Users.Rows.Add(row);

                    this.usersTableAdapter.Update(onlineBankingSystemDBDataset1.Users);
                    if (usersTableAdapter.Check_data_Entry(Name_TextBox.Text) != null)
                    {
                        MessageBox.Show("Account created", "Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Cannot enter");
                } 
            }
            catch (Exception data_signup) 
            {
                MessageBox.Show(data_signup.Message, "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Guest_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Use the text in loading form 
            UserName = "Welcome  to our application";
            //hide the form 
            this.Hide();
            //Display the loading form
            using (Loading_Form frm = new Loading_Form(Wating))
            {
                frm.ShowDialog(this);
            }
  
            Main_Form Main = new Main_Form();
            //Disable the buttons in main form 
            Main.Account_btn.Enabled = false;
            Main.Transactions_btn.Enabled = false;
            Main.PaysBill_btn.Enabled = false;
            //Display the main form 
            Main.Show();
        }
 
    }
}
