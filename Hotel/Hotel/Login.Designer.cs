namespace Hotel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSign = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbClose = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 477);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnSign);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Location = new System.Drawing.Point(474, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 477);
            this.panel2.TabIndex = 1;
            // 
            // btnSign
            // 
            this.btnSign.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSign.BorderRadius = 0;
            this.btnSign.ButtonText = "Sign in";
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.DisabledColor = System.Drawing.Color.Gray;
            this.btnSign.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSign.Iconimage = null;
            this.btnSign.Iconimage_right = null;
            this.btnSign.Iconimage_right_Selected = null;
            this.btnSign.Iconimage_Selected = null;
            this.btnSign.IconMarginLeft = 0;
            this.btnSign.IconMarginRight = 0;
            this.btnSign.IconRightVisible = true;
            this.btnSign.IconRightZoom = 0D;
            this.btnSign.IconVisible = true;
            this.btnSign.IconZoom = 90D;
            this.btnSign.IsTab = false;
            this.btnSign.Location = new System.Drawing.Point(136, 353);
            this.btnSign.Name = "btnSign";
            this.btnSign.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSign.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSign.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSign.selected = false;
            this.btnSign.Size = new System.Drawing.Size(199, 32);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign in";
            this.btnSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSign.Textcolor = System.Drawing.Color.White;
            this.btnSign.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(125, 289);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(220, 32);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(125, 198);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(220, 32);
            this.txtUser.TabIndex = 0;
            // 
            // lbClose
            // 
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Image = ((System.Drawing.Image)(resources.GetObject("lbClose.Image")));
            this.lbClose.Location = new System.Drawing.Point(879, 1);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(46, 28);
            this.lbClose.TabIndex = 2;
            this.lbClose.Click += new System.EventHandler(this.lcClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 509);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSign;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbClose;
    }
}