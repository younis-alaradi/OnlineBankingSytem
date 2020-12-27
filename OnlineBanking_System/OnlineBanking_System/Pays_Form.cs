using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Pays_Form : Form
    {
        public Pays_Form()
        {
            InitializeComponent();
        }

        double Account_Balance = 0;
        //Require functions
        private string Get_Name()
        { // get the name of the user 
            return Start_Form.U_Name;
        }
        private void save_function() 
        {
            try
            {

                var msg = MessageBox.Show("Are you sure do you want save ? ", "Save informations", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (msg == DialogResult.Yes)
                {
                    this.Validate();
                    this.paysBindingSource.EndEdit();
                    this.paysTableAdapter.Update(onlineBankingSystemDBDataset1.Pays);
                    MessageBox.Show("Saved information", "Save manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception cs)
            {
                MessageBox.Show(cs.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private int get_Amount() 
        {
            return Start_Form.Amount;
        }  
        private int get_UserID() 
        {
            return Start_Form.User_ID;
        }
        private void Hide_panel(Panel Pnl) 
        {
            Pnl.Visible = false;
        }
        private void Show_panel(Panel pnl) 
        {
            pnl.Visible = true;
        }
        private void MoveUp ()
        {
            try
            {
                paysBindingSource.MovePrevious();
            }
            catch (Exception cs)
            {
                MessageBox.Show(cs.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MoveDown() 
        {
            try
            {
                paysBindingSource.MoveNext();
            }
            catch (Exception cs)
            {
                MessageBox.Show(cs.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /************************************Main buttons*************************************************/
        private void Return_btn_Click(object sender, EventArgs e)
        {
            var put = MessageBox.Show("Are You Sure You Want To Close The Pay Bills Form And Go Back To Main Form???", "Closing Pay Bills", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
            if (put == DialogResult.Yes)
            {
                this.Hide();
                Main_Form Main = new Main_Form();
                Main.Show();
            }
        }

        private void Market_btn_Click(object sender, EventArgs e)
        {
            Show_panel(MainMarketPanel);
            Hide_panel(MainUniversityPanel);
            Hide_panel(MainNetworkPanel);
        }

        private void University_btn_Click(object sender, EventArgs e)
        {
            Hide_panel(MainMarketPanel);
            Hide_panel(MainNetworkPanel);
            Show_panel(MainUniversityPanel);
        }

        private void Networks_btn_Click(object sender, EventArgs e)
        {
            Hide_panel(MainMarketPanel);
            Hide_panel(MainUniversityPanel);
            Show_panel(MainNetworkPanel);
        }

        private void Pays_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineBankingSystemDBDataset1.Pays' table. You can move, or remove it, as needed.
            this.paysTableAdapter.Fill(this.onlineBankingSystemDBDataset1.Pays);
            //Get the account name 
            AccountName_label.Text = Get_Name();
            //Generate rendom number for account balance 
            Account_Balance = get_Amount();
            //Display the date and time
            DateTime_label.Text = DateTime.Now.ToString();

            Markets_panel.Visible = true;
        }

        private void Show_Balance_btn_Click(object sender, EventArgs e)
        {
            Show_Balance_btn.Text = Account_Balance.ToString("c");
        }
        /*******************Market panel functions********************/
        private void Clear_btn_Click(object sender, EventArgs e)
        {

            if (Markets_combbox.SelectedIndex == -1 && Invoice_textBox.Text == string.Empty && Amount_textBox.Text == string.Empty && Comment_textBoxx.Text == string.Empty)
            {
                MessageBox.Show("The box's already empty", "Empty box's", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Markets_combbox.SelectedIndex = -1;
                Invoice_textBox.Text = string.Empty;
                Amount_textBox.Text = string.Empty;
                Comment_textBoxx.Text = string.Empty;
                MessageBox.Show("Items Deleted", "Delete items", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            double amount = 0;

            if (Markets_combbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the market to complete the transaction", "Market Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Markets_combbox.Focus();
            }
            else if (Invoice_textBox.Text == string.Empty)
            {
                MessageBox.Show("Enter the invoice number", "Invoice Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Invoice_textBox.Focus();
            }
            else if (Amount_textBox.Text == string.Empty)
            {
                MessageBox.Show("Enter the amount", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Amount_textBox.Focus();
            }
            else
            {
                if (double.TryParse(Amount_textBox.Text, out amount))
                {
                    var Msg = MessageBox.Show("Are you sure  to send " + amount.ToString("c") + " ?", "Funds Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Msg == DialogResult.Yes)
                    {
                        try
                        {
                            OnlineBankingSystemDBDataset.PaysRow pay;
                            pay = onlineBankingSystemDBDataset1.Pays.NewPaysRow();
                            pay.Shop_Name_ = Markets_combbox.SelectedItem.ToString();
                            pay.Invoice_No = Invoice_textBox.Text;
                            pay.Comment = Comment_textBoxx.Text;
                            pay.User_Name = Get_Name();
                            onlineBankingSystemDBDataset1.Pays.Rows.Add(pay);                   
                            MessageBox.Show("Funds send successfully", "Funds manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account_Balance-=amount;

                        }
                        catch (Exception ErrorEntry)
                        {
                            MessageBox.Show(ErrorEntry.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
                else 
                {
                    MessageBox.Show("Error Number Format ", "Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Amount_textBox.Focus();
                    Amount_textBox.SelectAll();
                }

            }
        }

        private void Market_History_btn_Click(object sender, EventArgs e)
        {
            paysTableAdapter.Fill_SuperMarkets(onlineBankingSystemDBDataset1.Pays);
            Hide_panel(Market_panel);
            Transition.ShowSync(Markets_DataGrid_panel);
           Markets_DataGrid_panel.Size = new Size(1210, 463);

        }

        private void Back_TOPanelBTN_Click(object sender, EventArgs e)
        {
            Hide_panel(Markets_DataGrid_panel);
            Transition.ShowSync(Market_panel);
        }

        private void Up_btn_Click(object sender, EventArgs e)
        {
            MoveUp();
          
        }

        private void Down_btn_Click(object sender, EventArgs e)
        {
            MoveDown();
        }
        

        private void save_btn_Click(object sender, EventArgs e)
        {
            save_function();
        }
        /*******************University panel functions***************************/
        private void University_PayBtn_Click(object sender, EventArgs e)
        {
            double amount = 0;

            if (UniversityName_Combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the University Name to complete the transaction", "University Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UniversityName_Combobox.Focus();
            }
            else if (UniversityInvoice_textbox.Text == string.Empty)
            {
                MessageBox.Show("Enter the invoice number", "Invoice Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UniversityInvoice_textbox.Focus();
            }
            else if (University_AmountTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter the amount", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                University_AmountTextBox.Focus();
            }
            else
            {
                if (double.TryParse(University_AmountTextBox.Text, out amount))
                {
                    var Msg = MessageBox.Show("Are you sure  to send " + amount.ToString("c") + " ?", "Funds Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Msg == DialogResult.Yes)
                    {
                        try
                        {
                            OnlineBankingSystemDBDataset.PaysRow University;
                            University = onlineBankingSystemDBDataset1.Pays.NewPaysRow();
                            University.Shop_Name_ = UniversityName_Combobox.SelectedItem.ToString();
                            University.Invoice_No = UniversityInvoice_textbox.Text;
                            University.Comment = UniversityComment_TextBox.Text;
                            University.User_Name = Get_Name();
                            onlineBankingSystemDBDataset1.Pays.Rows.Add(University);
                            MessageBox.Show("Funds send successfully", "Funds manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account_Balance -= amount;

                        }
                        catch (Exception ErrorEntry)
                        {
                            MessageBox.Show(ErrorEntry.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Error Number Format ", "Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    University_AmountTextBox.Focus();
                    University_AmountTextBox.SelectAll();
                }

            }
        }

        private void University_ClearBtn_Click(object sender, EventArgs e)
        {
            if (UniversityName_Combobox.SelectedIndex == -1 && UniversityInvoice_textbox.Text == string.Empty && University_AmountTextBox.Text == string.Empty && UniversityComment_TextBox.Text == string.Empty)
            {
                MessageBox.Show("The box's already empty", "Empty box's", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UniversityName_Combobox.SelectedIndex = -1;
                UniversityInvoice_textbox.Text = string.Empty;
                University_AmountTextBox.Text = string.Empty;
                UniversityComment_TextBox.Text = string.Empty;
                MessageBox.Show("Items Deleted", "Delete items", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Unversity_UpBtn_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void University_DownBtn_Click(object sender, EventArgs e)
        {
            MoveDown();

        }

        private void University_SaveBtn_Click(object sender, EventArgs e)
        {
            save_function();

        }

        private void University_historyBtn_Click(object sender, EventArgs e)
        {
            paysTableAdapter.FillUniversity_Result(onlineBankingSystemDBDataset1.Pays);
            UniversityDatagridViewPanel.Size = new Size(1198, 449);
            Transition.ShowSync(UniversityDatagridViewPanel);
        }

        private void UniversityBackBtn_Click(object sender, EventArgs e)
        {
            Hide_panel(UniversityDatagridViewPanel);
        }
        /*************************Network provider sfunctions*********************/

        private void Net_PayBtn_Click(object sender, EventArgs e)
        {
            double amount = 0;

            if (Net_Combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the University Name to complete the transaction", "University Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Net_Combobox.Focus();
            }
            else if (Net_InvoiceTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter the invoice number", "Invoice Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Net_InvoiceTextBox.Focus();
            }
            else if (Net_AmountTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter the amount", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Net_AmountTextBox.Focus();
            }
            else
            {
                if (double.TryParse(Net_AmountTextBox.Text, out amount))
                {
                    var Msg = MessageBox.Show("Are you sure  to send " + amount.ToString("c") + " ?", "Funds Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Msg == DialogResult.Yes)
                    {
                        try
                        {
                            OnlineBankingSystemDBDataset.PaysRow NetworkPay;
                            NetworkPay = onlineBankingSystemDBDataset1.Pays.NewPaysRow();
                            NetworkPay.Shop_Name_ = UniversityName_Combobox.SelectedItem.ToString();
                            NetworkPay.Invoice_No = UniversityInvoice_textbox.Text;
                            NetworkPay.Comment = UniversityComment_TextBox.Text;
                            NetworkPay.User_Name = Get_Name();
                            onlineBankingSystemDBDataset1.Pays.Rows.Add(NetworkPay);
                            MessageBox.Show("Funds send successfully", "Funds manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account_Balance -= amount;

                        }
                        catch (Exception ErrorEntry)
                        {
                            MessageBox.Show(ErrorEntry.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Error Number Format ", "Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Net_AmountTextBox.Focus();
                    Net_AmountTextBox.SelectAll();
                }

            }

        }

        private void Net_ClearBtn_Click(object sender, EventArgs e)
        {
            if (Net_Combobox.SelectedIndex == -1 && Net_InvoiceTextBox.Text == string.Empty && Net_AmountTextBox.Text == string.Empty && Net_CommentTextBox.Text == string.Empty)
            {
                MessageBox.Show("The box's already empty", "Empty box's", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Net_Combobox.SelectedIndex = -1;
                Net_InvoiceTextBox.Text = string.Empty;
                Net_AmountTextBox.Text = string.Empty;
                Net_CommentTextBox.Text = string.Empty;
                MessageBox.Show("Items Deleted", "Delete items", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Net_BackBtn_Click(object sender, EventArgs e)
        {
            Hide_panel(NetworkDatagridPanel);
        }

        private void Net_Upbtn_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void Net_SaveBtn_Click(object sender, EventArgs e)
        {
            save_function();
        }

        private void net_DownBtn_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void Net_HistoryBtn_Click(object sender, EventArgs e)
        {
            paysTableAdapter.Fill_NetworkProviderr();
            Transition.ShowSync(NetworkDatagridPanel);
        }
    }
}
