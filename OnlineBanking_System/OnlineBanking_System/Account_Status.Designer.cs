
namespace OnlineBanking_System
{
    partial class Account_Status
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Status));
            this.CustomBorder = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Back_btn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountName_label = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomBorder
            // 
            this.CustomBorder.AnimateWindow = true;
            this.CustomBorder.BorderRadius = 50;
            this.CustomBorder.ContainerControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(252)))));
            this.guna2Panel1.Controls.Add(this.Back_btn);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_btn.Image = global::OnlineBanking_System.Properties.Resources.back;
            this.Back_btn.Location = new System.Drawing.Point(21, 21);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.ShadowDecoration.Parent = this.Back_btn;
            this.Back_btn.Size = new System.Drawing.Size(55, 61);
            this.Back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_btn.TabIndex = 1;
            this.Back_btn.TabStop = false;
            this.toolTip1.SetToolTip(this.Back_btn, "Back To Main Form");
            this.Back_btn.UseTransparentBackground = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::OnlineBanking_System.Properties.Resources.kyc;
            this.guna2PictureBox3.Location = new System.Drawing.Point(718, 135);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(70, 62);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 9;
            this.guna2PictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.guna2PictureBox3, "Verified Account");
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::OnlineBanking_System.Properties.Resources.yes;
            this.guna2PictureBox2.Location = new System.Drawing.Point(718, 272);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(70, 62);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.guna2PictureBox2, "Account Active");
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "C Bank ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountName_label
            // 
            this.AccountName_label.BackColor = System.Drawing.Color.Black;
            this.AccountName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountName_label.ForeColor = System.Drawing.Color.White;
            this.AccountName_label.Location = new System.Drawing.Point(96, 366);
            this.AccountName_label.Name = "AccountName_label";
            this.AccountName_label.Size = new System.Drawing.Size(356, 62);
            this.AccountName_label.TabIndex = 7;
            this.AccountName_label.Text = "Account Name";
            this.AccountName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::OnlineBanking_System.Properties.Resources.bank_1300155_1280;
            this.guna2PictureBox1.Location = new System.Drawing.Point(71, 106);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(619, 332);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Account_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.AccountName_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account status";
            this.Load += new System.EventHandler(this.Account_Status_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm CustomBorder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox Back_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label AccountName_label;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}