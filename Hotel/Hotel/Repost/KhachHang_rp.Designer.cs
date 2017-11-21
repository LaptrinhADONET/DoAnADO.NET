namespace Hotel.Repost
{
    partial class KhachHang_rp
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
            this.rpKhachHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rp_KhachHang1 = new Hotel.Repost.Rp_KhachHang();
            this.SuspendLayout();
            // 
            // rpKhachHang
            // 
            this.rpKhachHang.ActiveViewIndex = 0;
            this.rpKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpKhachHang.DisplayStatusBar = false;
            this.rpKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpKhachHang.Location = new System.Drawing.Point(0, 0);
            this.rpKhachHang.Name = "rpKhachHang";
            this.rpKhachHang.ReportSource = this.Rp_KhachHang1;
            this.rpKhachHang.Size = new System.Drawing.Size(998, 504);
            this.rpKhachHang.TabIndex = 0;
            this.rpKhachHang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // KhachHang_rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 504);
            this.Controls.Add(this.rpKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KhachHang_rp";
            this.Text = "Word";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpKhachHang;
        private Rp_KhachHang Rp_KhachHang1;
    }
}