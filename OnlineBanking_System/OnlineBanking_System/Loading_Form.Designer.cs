
namespace OnlineBanking_System
{
    partial class Loading_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Form));
            this.CustomBorder = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Design_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WinProgressIndicator = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomBorder
            // 
            this.CustomBorder.AnimateWindow = true;
            this.CustomBorder.BorderRadius = 50;
            this.CustomBorder.ContainerControl = this;
            this.CustomBorder.ShadowColor = System.Drawing.Color.White;
            this.CustomBorder.TransparentWhileDrag = true;
            // 
            // Design_panel
            // 
            this.Design_panel.BackColor = System.Drawing.Color.White;
            this.Design_panel.Location = new System.Drawing.Point(1, 205);
            this.Design_panel.Name = "Design_panel";
            this.Design_panel.ShadowDecoration.Parent = this.Design_panel;
            this.Design_panel.Size = new System.Drawing.Size(767, 23);
            this.Design_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to c-Banking System....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinProgressIndicator
            // 
            this.WinProgressIndicator.CircleSize = 5F;
            this.WinProgressIndicator.Location = new System.Drawing.Point(316, 75);
            this.WinProgressIndicator.Name = "WinProgressIndicator";
            this.WinProgressIndicator.ProgressColor = System.Drawing.Color.White;
            this.WinProgressIndicator.Size = new System.Drawing.Size(125, 106);
            this.WinProgressIndicator.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::OnlineBanking_System.Properties.Resources.copyright;
            this.guna2PictureBox1.Location = new System.Drawing.Point(413, 236);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(39, 41);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(460, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copyright @2020 ITIS 241 Group 3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome_label
            // 
            this.Welcome_label.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(31, 235);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(367, 42);
            this.Welcome_label.TabIndex = 5;
            this.Welcome_label.Text = "Welcome";
            this.Welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Loading_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(771, 287);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.WinProgressIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Design_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading....";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm CustomBorder;
        private Guna.UI2.WinForms.Guna2Panel Design_panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator WinProgressIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Welcome_label;
        public System.Windows.Forms.Timer timer;
    }
}