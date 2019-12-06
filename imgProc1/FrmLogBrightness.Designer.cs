namespace imgProc1
{
    partial class FrmLogBrightness
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
            this.hScrlBrightness = new System.Windows.Forms.HScrollBar();
            this.tbLgBrightness = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hScrlBrightness
            // 
            this.hScrlBrightness.Location = new System.Drawing.Point(9, 22);
            this.hScrlBrightness.Maximum = 114;
            this.hScrlBrightness.Name = "hScrlBrightness";
            this.hScrlBrightness.Size = new System.Drawing.Size(333, 23);
            this.hScrlBrightness.TabIndex = 0;
            this.hScrlBrightness.ValueChanged += new System.EventHandler(this.HScrlBrightness_ValueChanged);
            // 
            // tbLgBrightness
            // 
            this.tbLgBrightness.Location = new System.Drawing.Point(365, 24);
            this.tbLgBrightness.Name = "tbLgBrightness";
            this.tbLgBrightness.Size = new System.Drawing.Size(51, 20);
            this.tbLgBrightness.TabIndex = 1;
            this.tbLgBrightness.TextChanged += new System.EventHandler(this.TbLgBrightness_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(160, 89);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(104, 28);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmLogBrightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 129);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tbLgBrightness);
            this.Controls.Add(this.hScrlBrightness);
            this.Name = "FrmLogBrightness";
            this.Text = "FrmLogBrightness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.HScrollBar hScrlBrightness;
        public System.Windows.Forms.TextBox tbLgBrightness;
        public System.Windows.Forms.Button buttonOK;
    }
}