
namespace CarRentalApp
{
    partial class ResetPassword
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConfirmedPassword = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadz nowe haslo";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(121, 44);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(175, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potwierdz haslo";
            // 
            // tbConfirmedPassword
            // 
            this.tbConfirmedPassword.Location = new System.Drawing.Point(121, 126);
            this.tbConfirmedPassword.Name = "tbConfirmedPassword";
            this.tbConfirmedPassword.PasswordChar = '*';
            this.tbConfirmedPassword.Size = new System.Drawing.Size(175, 20);
            this.tbConfirmedPassword.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Resetuj Haslo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 235);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbConfirmedPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "Zresetuj hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfirmedPassword;
        private System.Windows.Forms.Button btnReset;
    }
}