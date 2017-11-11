namespace Hotel.ListForm
{
    partial class TrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnLST = new System.Windows.Forms.Panel();
            this.pixb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pixb)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnLST
            // 
            this.pnLST.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLST.Location = new System.Drawing.Point(0, 309);
            this.pnLST.Name = "pnLST";
            this.pnLST.Size = new System.Drawing.Size(1069, 301);
            this.pnLST.TabIndex = 3;
            // 
            // pixb
            // 
            this.pixb.Location = new System.Drawing.Point(27, 16);
            this.pixb.Name = "pixb";
            this.pixb.Size = new System.Drawing.Size(984, 276);
            this.pixb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixb.TabIndex = 2;
            this.pixb.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pixb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 309);
            this.panel2.TabIndex = 4;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnLST);
            this.Name = "TrangChu";
            this.Size = new System.Drawing.Size(1069, 610);
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pixb;
        private System.Windows.Forms.Panel pnLST;
        private System.Windows.Forms.Panel panel2;
    }
}
