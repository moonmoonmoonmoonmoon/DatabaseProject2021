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
            this.inventoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesLoginButton
            // 
            this.salesLoginButton.Location = new System.Drawing.Point(12, 12);
            this.salesLoginButton.Name = "salesLoginButton";
            this.salesLoginButton.Size = new System.Drawing.Size(100, 100);
            this.salesLoginButton.TabIndex = 0;
            this.salesLoginButton.Text = "Sales Person Login";
            this.salesLoginButton.UseVisualStyleBackColor = true;
            this.salesLoginButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.Location = new System.Drawing.Point(118, 12);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(100, 100);
            this.customerLoginButton.TabIndex = 1;
            this.customerLoginButton.Text = "Customer Login";
            this.customerLoginButton.UseVisualStyleBackColor = true;
            this.customerLoginButton.Click += new System.EventHandler(this.ReturningCustomerButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(224, 12);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(100, 100);
            this.inventoryButton.TabIndex = 2;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            // 
            // DealerShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.salesLoginButton);
            this.Name = "DealerShipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Car Dealership Main Form";
            this.Load += new System.EventHandler(this.DealerShipForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salesLoginButton;
        private System.Windows.Forms.Button customerLoginButton;
        private System.Windows.Forms.Button inventoryButton;
    }
}

