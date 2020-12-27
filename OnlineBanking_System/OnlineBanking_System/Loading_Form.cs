using System;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Loading_Form : Form
    {
        public Action Worker { get; set; } 
        private  string get_UserName() 
        {//return the name 
            return Start_Form.UserName;
        }
        public Loading_Form(Action worker)
        {

            InitializeComponent();
            timer.Start();
            Welcome_label.Text = "" + get_UserName();

            if (worker == null) 
            {//check the worker
                throw new ArgumentNullException();
            }
        }
        int Count = 0;
        protected override void OnLoad(EventArgs e)
        {//start the loading progress
            base.OnLoad(e);
            WinProgressIndicator.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {//Close the  loading form by timer
            Count++;
            if (Count ==85) 
            {//stop timer
                timer.Stop();
                //Close the form
                this.Close();
            }
        }
    }
}
