namespace Hotel.ListForm2
{
    partial class frmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.pnContentAddLoaiPhong = new System.Windows.Forms.Panel();
            this.lbGHSL = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnContentAddLoaiPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMenu.Controls.Add(this.btnHuy);
            this.pnMenu.Controls.Add(this.btnThem);
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Controls.Add(this.btnThongTin);
            this.pnMenu.Controls.Add(this.pnContentAddLoaiPhong);
            this.pnMenu.Location = new System.Drawing.Point(0, -2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(712, 481);
            this.pnMenu.TabIndex = 4;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(63)))), ((int)(((byte)(58)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(615, 64);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(35, 35);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(120)))), ((int)(((byte)(171)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(656, 64);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(35, 35);
            this.btnThem.TabIndex = 21;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 41);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Chức Vụ";
            // 
            // btnThongTin
            // 
            this.btnThongTin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Location = new System.Drawing.Point(16, 66);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(78, 40);
            this.btnThongTin.TabIndex = 17;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            // 
            // pnContentAddLoaiPhong
            // 
            this.pnContentAddLoaiPhong.BackColor = System.Drawing.Color.Silver;
            this.pnContentAddLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContentAddLoaiPhong.Controls.Add(this.lbGHSL);
            this.pnContentAddLoaiPhong.Controls.Add(this.lbTen);
            this.pnContentAddLoaiPhong.Controls.Add(this.txtHSL);
            this.pnContentAddLoaiPhong.Controls.Add(this.txtTenChucVu);
            this.pnContentAddLoaiPhong.Controls.Add(this.label11);
            this.pnContentAddLoaiPhong.Controls.Add(this.label7);
            this.pnContentAddLoaiPhong.Location = new System.Drawing.Point(16, 105);
            this.pnContentAddLoaiPhong.Name = "pnContentAddLoaiPhong";
            this.pnContentAddLoaiPhong.Size = new System.Drawing.Size(675, 352);
            this.pnContentAddLoaiPhong.TabIndex = 16;
            // 
            // lbGHSL
            // 
            this.lbGHSL.Image = global::Hotel.Properties.Resources.Loi;
            this.lbGHSL.Location = new System.Drawing.Point(456, 232);
            this.lbGHSL.Name = "lbGHSL";
            this.lbGHSL.Size = new System.Drawing.Size(30, 30);
            this.lbGHSL.TabIndex = 30;
            this.lbGHSL.Visible = false;
            // 
            // lbTen
            // 
            this.lbTen.Image = global::Hotel.Properties.Resources.Loi;
            this.lbTen.Location = new System.Drawing.Point(456, 162);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(30, 30);
            this.lbTen.TabIndex = 26;
            this.lbTen.Visible = false;
            // 
            // txtHSL
            // 
            this.txtHSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSL.Location = new System.Drawing.Point(139, 236);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(311, 26);
            this.txtHSL.TabIndex = 17;
            this.txtHSL.Click += new System.EventHandler(this.txtHSL_Click);
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucVu.Location = new System.Drawing.Point(139, 162);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(311, 26);
            this.txtTenChucVu.TabIndex = 13;
            this.txtTenChucVu.Click += new System.EventHandler(this.txtTenChucVu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(136, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(136, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hệ số lương";
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 480);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChucVu_FormClosed);
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnContentAddLoaiPhong.ResumeLayout(false);
            this.pnContentAddLoaiPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Panel pnContentAddLoaiPhong;
        private System.Windows.Forms.Label lbGHSL;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
    }
}