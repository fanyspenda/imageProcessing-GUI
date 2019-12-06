namespace imgProc1
{
    partial class FrmGamma
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
            this.hScrlGamma = new System.Windows.Forms.HScrollBar();
            this.frmGammaOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hScrlGamma
            // 
            this.hScrlGamma.LargeChange = 1;
            this.hScrlGamma.Location = new System.Drawing.Point(22, 24);
            this.hScrlGamma.Maximum = 800;
            this.hScrlGamma.Name = "hScrlGamma";
            this.hScrlGamma.Size = new System.Drawing.Size(339, 17);
            this.hScrlGamma.TabIndex = 0;
            // 
            // frmGammaOk
            // 
            this.frmGammaOk.Location = new System.Drawing.Point(143, 69);
            this.frmGammaOk.Name = "frmGammaOk";
            this.frmGammaOk.Size = new System.Drawing.Size(75, 23);
            this.frmGammaOk.TabIndex = 1;
            this.frmGammaOk.Text = "OK";
            this.frmGammaOk.UseVisualStyleBackColor = true;
            this.frmGammaOk.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmGamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 114);
            this.Controls.Add(this.frmGammaOk);
            this.Controls.Add(this.hScrlGamma);
            this.Name = "FrmGamma";
            this.Text = "FrmGamma";
            this.Load += new System.EventHandler(this.FrmGamma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.HScrollBar hScrlGamma;
        private System.Windows.Forms.Button frmGammaOk;
    }
}