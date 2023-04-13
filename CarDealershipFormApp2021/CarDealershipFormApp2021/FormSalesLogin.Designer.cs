namespace CarDealershipFormApp2021
{
    partial class salesLoginForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(28, 364);
            this.submitButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(233, 67);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(177, 167);
            this.emailBox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(403, 35);
            this.emailBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(177, 228);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(403, 35);
            this.passwordBox.TabIndex = 4;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(352, 364);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(233, 67);
            this.addUserButton.TabIndex = 20;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // salesLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 1002);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "salesLoginForm";
            this.Text = "Sales Person Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button addUserButton;
    }
}