namespace CarDealershipFormApp2021
{
    partial class DealerShipForm
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
        private void InitializeComponent() // THIS IS WHERE WE NEED TO PUT THE CONTROLS
        {
            this.salesLoginButton = new System.Windows.Forms.Button();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesLoginButton
            // 
            this.salesLoginButton.Location = new System.Drawing.Point(119, 27);
            this.salesLoginButton.Margin = new System.Windows.Forms.Padding(7);
            this.salesLoginButton.Name = "salesLoginButton";
            this.salesLoginButton.Size = new System.Drawing.Size(233, 223);
            this.salesLoginButton.TabIndex = 0;
            this.salesLoginButton.Text = "Sales Person Login";
            this.salesLoginButton.UseVisualStyleBackColor = true;
            this.salesLoginButton.Click += new System.EventHandler(this.userLogin_Click);
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.Location = new System.Drawing.Point(366, 27);
            this.customerLoginButton.Margin = new System.Windows.Forms.Padding(7);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(233, 223);
            this.customerLoginButton.TabIndex = 1;
            this.customerLoginButton.Text = "*For Testing*";
            this.customerLoginButton.UseVisualStyleBackColor = true;
            this.customerLoginButton.Click += new System.EventHandler(this.addUser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 162);
            this.button2.TabIndex = 3;
            this.button2.Text = "Customer Login";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DealerShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 1004);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.salesLoginButton);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "DealerShipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Car Dealership Main Form";
            this.Load += new System.EventHandler(this.DealerShipForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salesLoginButton;
        private System.Windows.Forms.Button customerLoginButton;
        private System.Windows.Forms.Button button2;
    }
}

