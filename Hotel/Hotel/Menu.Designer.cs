using System.Windows.Forms;

namespace Hotel
{
    partial class MenuHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHotel));
            this.label = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.PnMenu = new System.Windows.Forms.Panel();
            this.lbNutchay = new System.Windows.Forms.Panel();
            this.btnHome3 = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnInfomation = new System.Windows.Forms.Panel();
            this.lbImageStatus = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.label.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.PnMenu.SuspendLayout();
            this.pnInfomation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.Logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Controls.Add(this.panel2);
            this.label.Controls.Add(this.panel1);
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnContent);
            this.panel2.Controls.Add(this.MenuBar);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pnContent, "pnContent");
            this.pnContent.Name = "pnContent";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(124)))), ((int)(((byte)(131)))));
            this.MenuBar.Controls.Add(this.PnMenu);
            this.MenuBar.Controls.Add(this.pnInfomation);
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // PnMenu
            // 
            this.PnMenu.Controls.Add(this.lbNutchay);
            this.PnMenu.Controls.Add(this.btnHome3);
            this.PnMenu.Controls.Add(this.btnHome2);
            this.PnMenu.Controls.Add(this.btnHome1);
            this.PnMenu.Controls.Add(this.btnHome);
            resources.ApplyResources(this.PnMenu, "PnMenu");
            this.PnMenu.Name = "PnMenu";
            // 
            // lbNutchay
            // 
            this.lbNutchay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            resources.ApplyResources(this.lbNutchay, "lbNutchay");
            this.lbNutchay.Name = "lbNutchay";
            // 
            // btnHome3
            // 
            this.btnHome3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome3, "btnHome3");
            this.btnHome3.Name = "btnHome3";
            this.btnHome3.UseVisualStyleBackColor = true;
            this.btnHome3.Click += new System.EventHandler(this.btnHome3_Click);
            // 
            // btnHome2
            // 
            this.btnHome2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome2, "btnHome2");
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.UseVisualStyleBackColor = true;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // btnHome1
            // 
            this.btnHome1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome1, "btnHome1");
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnInfomation
            // 
            this.pnInfomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfomation.Controls.Add(this.lbImageStatus);
            this.pnInfomation.Controls.Add(this.lbStatus);
            this.pnInfomation.Controls.Add(this.label1);
            this.pnInfomation.Controls.Add(this.lbImage);
            resources.ApplyResources(this.pnInfomation, "pnInfomation");
            this.pnInfomation.Name = "pnInfomation";
            // 
            // lbImageStatus
            // 
            resources.ApplyResources(this.lbImageStatus, "lbImageStatus");
            this.lbImageStatus.ForeColor = System.Drawing.Color.Black;
            this.lbImageStatus.Name = "lbImageStatus";
            // 
            // lbStatus
            // 
            resources.ApplyResources(this.lbStatus, "lbStatus");
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Name = "lbStatus";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // lbImage
            // 
            this.lbImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lbImage, "lbImage");
            this.lbImage.Name = "lbImage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.Logo);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(190)))));
            this.Header.Controls.Add(this.btnExit);
            this.Header.Controls.Add(this.button6);
            this.Header.Controls.Add(this.btnMini);
            this.Header.Controls.Add(this.button4);
            resources.ApplyResources(this.Header, "Header");
            this.Header.Name = "Header";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnMini
            // 
            this.btnMini.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMini, "btnMini");
            this.btnMini.Name = "btnMini";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(194)))));
            this.Logo.Controls.Add(this.lbLogo);
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            // 
            // lbLogo
            // 
            this.lbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(196)))));
            this.lbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.lbLogo, "lbLogo");
            this.lbLogo.Name = "lbLogo";
            // 
            // MenuHotel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuHotel";
            this.label.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.PnMenu.ResumeLayout(false);
            this.pnInfomation.ResumeLayout(false);
            this.pnInfomation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Logo;
        private Label lbLogo;
        private Button button6;
        private Button btnMini;
        private Button button4;
        private Button btnExit;
        private Panel pnContent;
        private Panel PnMenu;
        private Panel lbNutchay;
        private Button btnHome3;
        private Button btnHome2;
        private Button btnHome1;
        private Button btnHome;
        private Panel pnInfomation;
        private Label lbImageStatus;
        private Label lbStatus;
        private Label label1;
        private Label lbImage;
    }
}

