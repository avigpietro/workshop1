namespace Workshop1
{
    partial class PrintPopUp
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
            this.lblPrintText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrintText
            // 
            this.lblPrintText.AutoSize = true;
            this.lblPrintText.Location = new System.Drawing.Point(24, 36);
            this.lblPrintText.Name = "lblPrintText";
            this.lblPrintText.Size = new System.Drawing.Size(35, 13);
            this.lblPrintText.TabIndex = 0;
            this.lblPrintText.Text = "label1";
            // 
            // PrintPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 128);
            this.Controls.Add(this.lblPrintText);
            this.Name = "PrintPopUp";
            this.Text = "Virtual Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPrintText;
    }
}