namespace SmtpTester
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.checkSsl = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUsernameAsAddress = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUsernameAsAddress);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(423, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(423, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(423, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "SMTP server";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(12, 23);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(309, 22);
            this.txtSmtp.TabIndex = 4;
            // 
            // checkSsl
            // 
            this.checkSsl.AutoSize = true;
            this.checkSsl.Location = new System.Drawing.Point(430, 25);
            this.checkSsl.Name = "checkSsl";
            this.checkSsl.Size = new System.Drawing.Size(49, 18);
            this.checkSsl.TabIndex = 6;
            this.checkSsl.Text = "SSL";
            this.checkSsl.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 291);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(155, 33);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Go!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(327, 23);
            this.txtPort.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 22);
            this.txtPort.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Receiver";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(13, 253);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(428, 22);
            this.txtReceiver.TabIndex = 9;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(13, 351);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(467, 227);
            this.txtOutput.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output";
            // 
            // chkUsernameAsAddress
            // 
            this.chkUsernameAsAddress.AutoSize = true;
            this.chkUsernameAsAddress.Font = new System.Drawing.Font("Verdana", 8F);
            this.chkUsernameAsAddress.Location = new System.Drawing.Point(311, 121);
            this.chkUsernameAsAddress.Name = "chkUsernameAsAddress";
            this.chkUsernameAsAddress.Size = new System.Drawing.Size(118, 17);
            this.chkUsernameAsAddress.TabIndex = 13;
            this.chkUsernameAsAddress.Text = "Idem Username";
            this.chkUsernameAsAddress.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.checkSsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSmtp);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmtpTester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.CheckBox checkSsl;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.NumericUpDown txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox chkUsernameAsAddress;
    }
}

