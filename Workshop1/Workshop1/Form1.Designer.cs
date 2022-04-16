namespace Workshop1
{
    partial class Form1
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
            this.SaveCustomerBtn = new System.Windows.Forms.Button();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderlistBox = new System.Windows.Forms.ListBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveCustomerBtn
            // 
            this.SaveCustomerBtn.Location = new System.Drawing.Point(489, 344);
            this.SaveCustomerBtn.Name = "SaveCustomerBtn";
            this.SaveCustomerBtn.Size = new System.Drawing.Size(193, 61);
            this.SaveCustomerBtn.TabIndex = 0;
            this.SaveCustomerBtn.Text = "Save Customer";
            this.SaveCustomerBtn.UseVisualStyleBackColor = true;
            this.SaveCustomerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(489, 108);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(193, 20);
            this.txtCreditCard.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(148, 272);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(193, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(148, 315);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(193, 20);
            this.txtIdNumber.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Credit Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender";
            // 
            // GenderlistBox
            // 
            this.GenderlistBox.FormattingEnabled = true;
            this.GenderlistBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderlistBox.Location = new System.Drawing.Point(489, 174);
            this.GenderlistBox.Name = "GenderlistBox";
            this.GenderlistBox.Size = new System.Drawing.Size(193, 17);
            this.GenderlistBox.TabIndex = 18;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(148, 152);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(193, 20);
            this.txtAge.TabIndex = 19;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(46, 152);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(148, 193);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 20);
            this.txtAddress.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(148, 231);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(193, 20);
            this.txtPhoneNumber.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.GenderlistBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.SaveCustomerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button SaveCustomerBtn;
        public System.Windows.Forms.TextBox txtCreditCard;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox GenderlistBox;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPhoneNumber;
    }
}

