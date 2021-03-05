
namespace UI
{
    partial class Register
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
            this.textInputName = new System.Windows.Forms.TextBox();
            this.textInputPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInputName
            // 
            this.textInputName.Location = new System.Drawing.Point(93, 241);
            this.textInputName.Name = "textInputName";
            this.textInputName.Size = new System.Drawing.Size(186, 23);
            this.textInputName.TabIndex = 0;
            // 
            // textInputPassword
            // 
            this.textInputPassword.Location = new System.Drawing.Point(93, 315);
            this.textInputPassword.Name = "textInputPassword";
            this.textInputPassword.Size = new System.Drawing.Size(186, 23);
            this.textInputPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(143, 406);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(364, 586);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textInputPassword);
            this.Controls.Add(this.textInputName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInputName;
        private System.Windows.Forms.TextBox textInputPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}