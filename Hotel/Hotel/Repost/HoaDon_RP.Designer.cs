namespace Hotel.Repost
{
    partial class HoaDon_RP
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
            this.cryHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.HoaDon_RP_View1 = new Hotel.Repost.HoaDon_RP_View();
            this.SuspendLayout();
            // 
            // cryHoaDon
            // 
            this.cryHoaDon.ActiveViewIndex = 0;
            this.cryHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryHoaDon.DisplayStatusBar = false;
            this.cryHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryHoaDon.Location = new System.Drawing.Point(0, 0);
            this.cryHoaDon.Name = "cryHoaDon";
            this.cryHoaDon.ReportSource = this.HoaDon_RP_View1;
            this.cryHoaDon.Size = new System.Drawing.Size(979, 509);
            this.cryHoaDon.TabIndex = 0;
            this.cryHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // HoaDon_RP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 509);
            this.Controls.Add(this.cryHoaDon);
            this.Name = "HoaDon_RP";
            this.Text = "HoaDon_RP";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryHoaDon;
        private HoaDon_RP_View HoaDon_RP_View1;
    }
}