namespace CustomerWindowsApplication
{
    partial class AddCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custNameField = new System.Windows.Forms.TextBox();
            this.custAddressField = new System.Windows.Forms.TextBox();
            this.custZipField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveAndExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zip:";
            // 
            // custNameField
            // 
            this.custNameField.Location = new System.Drawing.Point(81, 59);
            this.custNameField.Name = "custNameField";
            this.custNameField.Size = new System.Drawing.Size(351, 20);
            this.custNameField.TabIndex = 3;
            // 
            // custAddressField
            // 
            this.custAddressField.Location = new System.Drawing.Point(82, 104);
            this.custAddressField.Name = "custAddressField";
            this.custAddressField.Size = new System.Drawing.Size(350, 20);
            this.custAddressField.TabIndex = 4;
            // 
            // custZipField
            // 
            this.custZipField.Location = new System.Drawing.Point(81, 149);
            this.custZipField.Name = "custZipField";
            this.custZipField.Size = new System.Drawing.Size(351, 20);
            this.custZipField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(51, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add Customer Information";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(28, 226);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveAndExitBtn
            // 
            this.saveAndExitBtn.Location = new System.Drawing.Point(356, 226);
            this.saveAndExitBtn.Name = "saveAndExitBtn";
            this.saveAndExitBtn.Size = new System.Drawing.Size(107, 23);
            this.saveAndExitBtn.TabIndex = 8;
            this.saveAndExitBtn.Text = "Save and Exit";
            this.saveAndExitBtn.UseVisualStyleBackColor = true;
            this.saveAndExitBtn.Click += new System.EventHandler(this.saveAndExitBtn_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.saveAndExitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custZipField);
            this.Controls.Add(this.custAddressField);
            this.Controls.Add(this.custNameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "Add A Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custNameField;
        private System.Windows.Forms.TextBox custAddressField;
        private System.Windows.Forms.TextBox custZipField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveAndExitBtn;
    }
}