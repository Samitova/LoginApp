namespace LoginApp
{
    partial class RegisterForm
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
            this.textBoxRegComfPaswd = new System.Windows.Forms.TextBox();
            this.labelRegConfPaswd = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.labelRegPassord = new System.Windows.Forms.Label();
            this.labelRegLogin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRegComfPaswd);
            this.groupBox1.Controls.Add(this.labelRegConfPaswd);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonOk);
            this.groupBox1.Controls.Add(this.textBoxRegPassword);
            this.groupBox1.Controls.Add(this.textBoxRegLogin);
            this.groupBox1.Controls.Add(this.labelRegPassord);
            this.groupBox1.Controls.Add(this.labelRegLogin);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // textBoxRegComfPaswd
            // 
            this.textBoxRegComfPaswd.Location = new System.Drawing.Point(117, 105);
            this.textBoxRegComfPaswd.Name = "textBoxRegComfPaswd";
            this.textBoxRegComfPaswd.Size = new System.Drawing.Size(178, 20);
            this.textBoxRegComfPaswd.TabIndex = 7;
            // 
            // labelRegConfPaswd
            // 
            this.labelRegConfPaswd.AutoSize = true;
            this.labelRegConfPaswd.Location = new System.Drawing.Point(21, 112);
            this.labelRegConfPaswd.Name = "labelRegConfPaswd";
            this.labelRegConfPaswd.Size = new System.Drawing.Size(90, 13);
            this.labelRegConfPaswd.TabIndex = 6;
            this.labelRegConfPaswd.Text = "Confirm password";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(220, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(117, 148);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(117, 72);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(178, 20);
            this.textBoxRegPassword.TabIndex = 3;
            // 
            // textBoxRegLogin
            // 
            this.textBoxRegLogin.Location = new System.Drawing.Point(117, 35);
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(178, 20);
            this.textBoxRegLogin.TabIndex = 2;
            // 
            // labelRegPassord
            // 
            this.labelRegPassord.AutoSize = true;
            this.labelRegPassord.Location = new System.Drawing.Point(21, 79);
            this.labelRegPassord.Name = "labelRegPassord";
            this.labelRegPassord.Size = new System.Drawing.Size(53, 13);
            this.labelRegPassord.TabIndex = 1;
            this.labelRegPassord.Text = "Password";
            // 
            // labelRegLogin
            // 
            this.labelRegLogin.AutoSize = true;
            this.labelRegLogin.Location = new System.Drawing.Point(21, 42);
            this.labelRegLogin.Name = "labelRegLogin";
            this.labelRegLogin.Size = new System.Drawing.Size(33, 13);
            this.labelRegLogin.TabIndex = 0;
            this.labelRegLogin.Text = "Login";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 238);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.TextBox textBoxRegComfPaswd;
        private System.Windows.Forms.Label labelRegConfPaswd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.TextBox textBoxRegPassword;
        protected internal System.Windows.Forms.TextBox textBoxRegLogin;
        private System.Windows.Forms.Label labelRegPassord;
        private System.Windows.Forms.Label labelRegLogin;
    }
}