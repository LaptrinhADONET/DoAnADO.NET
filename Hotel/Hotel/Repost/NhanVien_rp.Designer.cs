namespace Hotel.Repost
{
    partial class NhanVien_rp
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
            this.cryNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Nhan_Vien_RP1 = new Hotel.Repost.Nhan_Vien_RP();
            this.SuspendLayout();
            // 
            // cryNhanVien
            // 
            this.cryNhanVien.ActiveViewIndex = 0;
            this.cryNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryNhanVien.DisplayStatusBar = false;
            this.cryNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryNhanVien.Location = new System.Drawing.Point(0, 0);
            this.cryNhanVien.Name = "cryNhanVien";
            this.cryNhanVien.ReportSource = this.Nhan_Vien_RP1;
            this.cryNhanVien.Size = new System.Drawing.Size(989, 502);
            this.cryNhanVien.TabIndex = 0;
            this.cryNhanVien.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // NhanVien_rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 502);
            this.Controls.Add(this.cryNhanVien);
            this.Name = "NhanVien_rp";
            this.Text = "NhanVien_rp";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryNhanVien;
        private Nhan_Vien_RP Nhan_Vien_RP1;
    }
}