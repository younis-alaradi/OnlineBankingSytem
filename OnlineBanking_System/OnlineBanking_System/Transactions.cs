using System;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        //Functions 

        private string get_Name()
        {
            return Start_Form.U_Name;

        }
        private int get_Amount()
        {
            return Start_Form.Amount;
        }

        double Amount_Balance = 0;


        private void Back_btn_Click(object sender, EventArgs e)
        {
            var pet = MessageBox.Show("Are You Sure You Want To Close The Transaction Form And Go Back To Main Form???", "Closing Transactions", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (pet == DialogResult.Yes)
            {
                this.Hide();
                Main_Form Main = new Main_Form();
                Main.Show();
            }
            
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineBankingSystemDBDataset.MoneyRequest' table. You can move, or remove it, as needed.
            this.moneyRequestTableAdapter.Fill(this.onlineBankingSystemDBDataset.MoneyRequest);
            // TODO: This line of code loads data into the 'onlineBankingSystemDBDataset1.MoneyTransfer' table. You can move, or remove it, as needed.
            this.moneyTransferTableAdapter.Fill(this.onlineBankingSystemDBDataset1.MoneyTransfer);
            AccountName_label.Text = get_Name();
            Amount_Balance = get_Amount();
            DateTime_label.Text = DateTime.Now.ToString();
            R_TransactionBtn.Enabled = false;
            S_TranscriptButton.Enabled = false;
        }

        private void Show_Balance_btn_Click(object sender, EventArgs e)
        {
            Show_Balance_btn.Text = Amount_Balance.ToString("c");
        }

        private void S_pay_btn_Click(object sender, EventArgs e)
        {
            //Validate the input 
            int amount = 0;

            if (S_IBAN_textBox.Text == String.Empty)
            {
                MessageBox.Show("Empty IBAN Box ", "Empty Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_IBAN_textBox.Focus();
            }
            else if (S_AmountTextBox.Text == String.Empty)
            {
                MessageBox.Show("Empty Amount Box ", "Empty Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_AmountTextBox.Focus();
            }
            else
            {
                if (int.TryParse(S_AmountTextBox.Text, out amount))
                {
                    try
                    {
                        var msg = MessageBox.Show("Are you sure to transfer " + amount.ToString("c"), "Transfer Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (msg == DialogResult.Yes)
                        {
                            OnlineBankingSystemDBDataset.MoneyTransferRow Transfer;
                            Transfer = onlineBankingSystemDBDataset1.MoneyTransfer.NewMoneyTransferRow();
                            Transfer.IBAN = S_IBAN_textBox.Text;
                            Transfer.Amount = amount;
                            Transfer.Comment = S_CommentTextBox.Text;
                            Transfer.UserName = get_Name();
                            onlineBankingSystemDBDataset1.MoneyTransfer.Rows.Add(Transfer);
                            Amount_Balance -= amount;

                            MessageBox.Show("Money transfer successfully", "Transfer Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception dataentry)
                    {
                        MessageBox.Show(dataentry.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Amount", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    S_AmountTextBox.Focus();
                    S_AmountTextBox.SelectAll();
                    S_TranscriptButton.Enabled = true;
                }
            }

        }

        private void S_transactionsBtn_Click(object sender, EventArgs e)
        {
            string Name = get_Name();
            moneyTransferTableAdapter.Fill_UserResultTransfer(onlineBankingSystemDBDataset1.MoneyTransfer, Name);
            Transition1.ShowSync(TransferDataGridView);
        }

        private void S_Clear_btn_Click(object sender, EventArgs e)
        {
            if (S_IBAN_textBox.Text == String.Empty && S_AmountTextBox.Text == String.Empty && S_CommentTextBox.Text == String.Empty)
            {
                MessageBox.Show("The box's Already empty", "Empty box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var ser = MessageBox.Show("Do you want clear the box's?", "Clear", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (ser == DialogResult.Yes)
                {
                    S_IBAN_textBox.Text = String.Empty;
                    S_CommentTextBox.Text = String.Empty;
                    S_AmountTextBox.Text = String.Empty;
                    MessageBox.Show("Text cleared", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SendMoney_btn_Click(object sender, EventArgs e)
        {
            RequestMoneyPanel.Visible = false;
            Transition1.ShowSync(SendMoneyPanel);
        }

        private void RequestMoney_btn_Click(object sender, EventArgs e)
        {
            SendMoneyPanel.Visible = false;
            Transition1.ShowSync(RequestMoneyPanel);
        }

        private void R_PayBtn_Click(object sender, EventArgs e)
        {
            int amount = 0;

            if (R_IBANTextBox.Text == String.Empty)
            {
                MessageBox.Show("Empty IBAN Box ", "Empty Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                R_IBANTextBox.Focus();
            }
            else if (R_AmountTextBox.Text == String.Empty)
            {
                MessageBox.Show("Empty Amount Box ", "Empty Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                R_AmountTextBox.Focus();
            }
            else
            {
                if (int.TryParse(R_AmountTextBox.Text, out amount))
                {
                    try
                    {
                        var msg = MessageBox.Show("Are you sure to request " + amount.ToString("c"), "Request Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (msg == DialogResult.Yes)
                        {
                            moneyRequestTableAdapter.Insert
                                (
                                R_IBANTextBox.Text,
                                amount,
                                R_CommentTextBox.Text,
                                get_Name()
                                );

                            MessageBox.Show("Money Requested successfully", "Request Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception dataentry)
                    {
                        MessageBox.Show(dataentry.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Amount", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    S_AmountTextBox.Focus();
                    S_AmountTextBox.SelectAll();
                    R_TransactionBtn.Enabled = true;
                }
            }
        }

        private void R_ClearBtn_Click(object sender, EventArgs e)
        {
            if (R_IBANTextBox.Text == String.Empty && R_AmountTextBox.Text == String.Empty && R_CommentTextBox.Text == String.Empty)
            {
                MessageBox.Show("The box's Already empty", "Empty box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var ser = MessageBox.Show("Do you want clear the box's?", "Clear", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (ser == DialogResult.Yes)
                {
                    R_IBANTextBox.Text = String.Empty;
                    R_CommentTextBox.Text = String.Empty;
                    R_AmountTextBox.Text = String.Empty;
                    MessageBox.Show("Text cleared", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void R_TransactionBtn_Click(object sender, EventArgs e)
        {
            String Name = get_Name();
            moneyRequestTableAdapter.Fill_UsersREquest(onlineBankingSystemDBDataset.MoneyRequest, Name);
            Transition1.ShowSync(Requst_datagridview);
        }

        private void S_TranscriptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Money Transcript:" + "\n" +
                            "Transcript ID: " + moneyRequestTableAdapter.getsendTranscriptId(onlineBankingSystemDBDataset.MoneyRequest) + "\n" +
                            "User Name: " + get_Name() + "\n" +
                            "IBAN Number:  " + moneyRequestTableAdapter.getsendIBAN(onlineBankingSystemDBDataset.MoneyRequest) + "\n" +
                            "Amount:  " + moneyRequestTableAdapter.getsendAmount(onlineBankingSystemDBDataset.MoneyRequest) + "\n"
                            );
        }

        private void R_TranscriptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Money Transcript:" + "\n" +
                            "Transcript ID: " + moneyTransferTableAdapter.getrequestTranscriptID() + "\n" +
                            "User Name: " + get_Name() + "\n" +
                            "IBAN Number:  " + moneyTransferTableAdapter.getrequestIBAN(onlineBankingSystemDBDataset.MoneyTransfer) + "\n" +
                            "Amount:  " + moneyTransferTableAdapter.getrequestAmount(onlineBankingSystemDBDataset.MoneyTransfer) + "\n"
                            );
        }
    }
}

