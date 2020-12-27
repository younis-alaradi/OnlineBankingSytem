using System;
using System.Windows.Forms;

namespace OnlineBanking_System
{
    public partial class Calculations : Form
    {
        public Calculations()
        {
            InitializeComponent();
        }
        double Result_value = 0;
        string operations;

        private void Button_click(object sender, EventArgs e)
        {
            //Try-catch block to skip any errors occurance 
            try
            {
                //Excute the numbers from buttons 
                Guna.UI2.WinForms.Guna2GradientButton btn = (Guna.UI2.WinForms.Guna2GradientButton)sender;
                //add the number to the textbox 
                Result_TextBox.Text = Result_TextBox.Text + btn.Text;
            }
            catch (Exception numeric) 
            {
                MessageBox.Show(numeric.Message);
            }
        }

        private void guna2GradientButton17_Click(object sender, EventArgs e)
        {//Delete buttons 
            Result_TextBox.Clear();
            //Return the values 
            Result_value = 0;
            Operator_label.Text = string.Empty;
        }

        private void Operations_Calcu(object sender, EventArgs e)
        {
            //Excute the operator sign's from buttons 
            Guna.UI2.WinForms.Guna2GradientButton opeer = (Guna.UI2.WinForms.Guna2GradientButton)sender;

            //check if the textbox empty or not 
            if (Result_TextBox.Text == string.Empty)
            {
                MessageBox.Show("No numbers found", "No numbers founds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Result_TextBox.Focus();
            }
            else
            {
                //Parse the numbers and do some operations 
                operations = opeer.Text;
                //Generate the first number  
                Result_value = double.Parse(Result_TextBox.Text);
                Operator_label.Text = Result_value.ToString() + operations;
                Result_TextBox.Text = "";
            }
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
            //Equal buttons 
            if (Result_TextBox.Text == string.Empty)
            {
                MessageBox.Show("No numbers found", "No numbers founds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Result_TextBox.Focus();
            }
            else { // Generate the second numbers and define the operations 
                double value_two;

            value_two = double.Parse(Result_TextBox.Text);

                switch (operations)
                {
                    case "+":
                        Result_TextBox.Text = (Result_value + value_two).ToString();
                        break;
                    case "-":
                        Result_TextBox.Text = (Result_value - value_two).ToString();
                        break;
                    case "X":
                        Result_TextBox.Text = (Result_value * value_two).ToString();
                        break;
                    case "/":
                        Result_TextBox.Text = (Result_value / value_two).ToString();
                        break;
                    default:
                        break;

                }
            }
        }

        private void guna2GradientButton18_Click(object sender, EventArgs e)
        {
            //Display calulator panel 
            Calculator_panel.Visible = false;
        }

        private void Income_Btn_Click(object sender, EventArgs e)
        {
            //Custom things 
            Intro_Panel.Visible = false;
            Calculator_panel.Visible = false;
            Calculator_Title_Label.Visible = false;
            EdgeDesign_Calculator.Visible = false;

            Edge_Design_Income.Visible = true;
            Income_panel_Transition1.ShowSync(Income_panel);
        }

        private void Calculator_Btn_Click(object sender, EventArgs e)
        {
            //Custom things  
            Intro_Panel.Visible = false;
            Calculator_panel.Visible = false;
            Income_panel.Visible = false;
            Transition1.ShowSync(Calculator_panel);
            Calculator_Title_Label.Visible = true;
            EdgeDesign_Calculator.Visible = true ;

            Edge_Design_Income.Visible = false;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {//Return to main page 
            Main_Form main = new Main_Form();
            this.Hide();
            main.ShowDialog();
        }
        //Counter Attribute
     
        int Revenue_Count = 0, Expense_Count = 0;
        private void EnterRevenue_btn_Click(object sender, EventArgs e)
        {
            //icome section //
            //Revenue sections 
            double RevenueValues = 0;
            if (Revenue_textBox.Text == string.Empty)
            {
                MessageBox.Show("Empty Revenue Box", "Empty detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Revenue_textBox.Focus();
            }
            else if (double.TryParse(Revenue_textBox.Text, out RevenueValues))
            {
                Revenue_Combobox.Items.Add(RevenueValues);
                Revenue_textBox.Text = String.Empty;
                Revenue_Count++;
                Count_ItemRevenue_Notif.Text = Revenue_Count.ToString();
            }
            else 
            {
                MessageBox.Show("Error Revenue Entry", "Error detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Revenue_textBox.Focus();
                Revenue_textBox.SelectAll();
            }
            Count_ItemRevenue_Notif.Text = Revenue_Count.ToString();
       
        }

        private void ClearRevenue_btn_Click(object sender, EventArgs e)
        { 
            if (Revenue_Combobox.Items.Count == 0)
            {
                MessageBox.Show("There is no values in box", "Revenue Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Revenue_Combobox.Focus();
            }
            else   
            {    
               Revenue_Combobox.Items.Clear();
               Revenue_Count = 0;
               Count_ItemRevenue_Notif.Text = Revenue_Count.ToString();
            }
        }

        private void Calculations_Load(object sender, EventArgs e)
        {
     
            
        }
        //Expenses sections //
        private void Clear_ExpBox_btn_Click(object sender, EventArgs e)
        {
            if (Expense_Combobox.Items.Count == 0)
            {
                MessageBox.Show("There is no values in box", "Expenses Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expense_Combobox.Focus();
            }
            else
            {
                Expense_Combobox.Items.Clear();
                Expense_Count = 0;
                Count_ItemExpenses_Notfi.Text = Expense_Count.ToString();
            }
        }

        private void GenerateIncome_btn_Click(object sender, EventArgs e)
        {
            if (Revenue_Combobox.Items.Count == 0)
            {
                MessageBox.Show("There is no revenues", "Revenues Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Revenue_Combobox.Focus();
            }
            else if (Expense_Combobox.Items.Count == 0)
            {
                MessageBox.Show("There is no Expenses", "Expenses Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expense_Combobox.Focus();
            }
            else
            {
                double Total_expenses = 0, Total_revenue = 0, Income;
                //Calculate the  sum of the revenues 
                for (int i = 0; i < Revenue_Combobox.Items.Count; i++)
                {
                    Total_revenue += double.Parse(Revenue_Combobox.Items[i].ToString());
                }
                //Calculate the sum of expenses 
                for (int i = 0; i < Expense_Combobox.Items.Count; i++)
                {
                    Total_expenses += double.Parse(Expense_Combobox.Items[i].ToString());
                }


                Income_label.Visible = true;

                Icome_TRev_label.Visible = true;
                Icome_TExp_label.Visible = true;

                T_REvenue_Label.Visible = true;
                Total_Expenses.Visible = true;
                Total_Result_label.Visible = true;


                Income = Total_revenue - Total_expenses;

                T_REvenue_Label.Text = Total_revenue + " $";
                Total_Expenses.Text = Total_expenses + " $";

                if (Total_revenue > Total_expenses)
                    Total_Result_label.Text = "Net Income = " + Income + " $";

                else if (Total_expenses > Total_revenue)
                {
                    Total_Result_label.Text = "Net loss = " + Income + " $";
                }
                else if (Total_expenses == Total_revenue) 
                {
                    Total_Result_label.Text = "The values are same";
                }
            }


        }

        private void Clear_Everythings_btn_Click(object sender, EventArgs e)
        {
            //Revenue section
            Revenue_textBox.Text = String.Empty;
            Count_ItemRevenue_Notif.Text = "0";
            Revenue_Combobox.Items.Clear();

            //Expenses sections
            Expense_textBox.Text = String.Empty;
            Count_ItemExpenses_Notfi.Text = "0";
            Expense_Combobox.Items.Clear();

            //Income statement section
            T_REvenue_Label.Text = String.Empty;
            Total_Expenses.Text = String.Empty;
            Total_Result_label.Text = "-";

        }
        private void animations_pictures(Guna.UI2.WinForms.Guna2PictureBox pictureBox) 
        {
            pictureBox.Visible = false;
            Transition1.ShowSync(pictureBox);
        }

        private void guna2PictureBox1_MouseHover(object sender, EventArgs e)
        {
            //Animaite pictureBox;
            animations_pictures(guna2PictureBox1);
        }

        private void guna2PictureBox2_MouseHover(object sender, EventArgs e)
        {
            animations_pictures(guna2PictureBox2);
        }

        private void guna2PictureBox3_MouseHover(object sender, EventArgs e)
        {
            animations_pictures(guna2PictureBox3);
        }

        private void Exp_btn_Click(object sender, EventArgs e)
        {
            Transition1.ShowSync(Intro_Panel);
            Income_panel.Visible = false;
            Calculator_panel.Visible = false;
            Calculator_Title_Label.Visible = false;
            EdgeDesign_Calculator.Visible = false;
            Edge_Design_Income.Visible = false;
        }

        private void EnterExpense_btn_Click(object sender, EventArgs e)
        {
            double ExpenseValue = 0;
            if (Expense_textBox.Text == string.Empty)
            {
                MessageBox.Show("Empty Revenue Box", "Empty detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Expense_textBox.Focus();
            }
            else if (double.TryParse(Expense_textBox.Text, out ExpenseValue))
            {
                Expense_Combobox.Items.Add(ExpenseValue);
                Expense_textBox.Text = String.Empty;
                Expense_Count++;
                Count_ItemExpenses_Notfi.Text = Expense_Count.ToString();
            }
            else
            {
                MessageBox.Show("Error Revenue Entry", "Error detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Expense_textBox.Focus();
                Expense_textBox.SelectAll();
            }
        }
    }
    }

