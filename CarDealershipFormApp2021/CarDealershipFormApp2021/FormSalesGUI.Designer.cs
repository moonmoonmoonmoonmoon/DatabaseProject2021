namespace CarDealershipFormApp2021
{
    partial class salesGUI
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
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.yearcomboBox = new System.Windows.Forms.ComboBox();
            this.colorcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.refeshInventory = new System.Windows.Forms.Button();
            this.vinNumtextBox = new System.Windows.Forms.TextBox();
            this.vinNum = new System.Windows.Forms.Label();
            this.lotID = new System.Windows.Forms.Label();
            this.lotNametextBox = new System.Windows.Forms.TextBox();
            this.lotAddresstextBox = new System.Windows.Forms.TextBox();
            this.addLotIDtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lotNumtextBox = new System.Windows.Forms.TextBox();
            this.addLotButton = new System.Windows.Forms.Button();
            this.lotcomboBox = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.addColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // makeComboBox
            // 
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(52, 6);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(121, 21);
            this.makeComboBox.TabIndex = 0;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(52, 41);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelComboBox.TabIndex = 1;
            // 
            // yearcomboBox
            // 
            this.yearcomboBox.FormattingEnabled = true;
            this.yearcomboBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.yearcomboBox.Location = new System.Drawing.Point(52, 76);
            this.yearcomboBox.Name = "yearcomboBox";
            this.yearcomboBox.Size = new System.Drawing.Size(121, 21);
            this.yearcomboBox.TabIndex = 2;
            // 
            // colorcomboBox
            // 
            this.colorcomboBox.FormattingEnabled = true;
            this.colorcomboBox.Location = new System.Drawing.Point(52, 145);
            this.colorcomboBox.Name = "colorcomboBox";
            this.colorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.colorcomboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color";
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addVehicleButton.Location = new System.Drawing.Point(312, 179);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(75, 23);
            this.addVehicleButton.TabIndex = 7;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // refeshInventory
            // 
            this.refeshInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refeshInventory.Location = new System.Drawing.Point(52, 295);
            this.refeshInventory.Name = "refeshInventory";
            this.refeshInventory.Size = new System.Drawing.Size(100, 50);
            this.refeshInventory.TabIndex = 14;
            this.refeshInventory.Text = "Refresh Inventory";
            this.refeshInventory.UseVisualStyleBackColor = false;
            this.refeshInventory.Click += new System.EventHandler(this.refeshInventory_Click);
            // 
            // vinNumtextBox
            // 
            this.vinNumtextBox.Location = new System.Drawing.Point(52, 179);
            this.vinNumtextBox.Name = "vinNumtextBox";
            this.vinNumtextBox.Size = new System.Drawing.Size(254, 20);
            this.vinNumtextBox.TabIndex = 6;
            // 
            // vinNum
            // 
            this.vinNum.AutoSize = true;
            this.vinNum.Location = new System.Drawing.Point(11, 184);
            this.vinNum.Name = "vinNum";
            this.vinNum.Size = new System.Drawing.Size(35, 13);
            this.vinNum.TabIndex = 13;
            this.vinNum.Text = "VIN #";
            // 
            // lotID
            // 
            this.lotID.AutoSize = true;
            this.lotID.Location = new System.Drawing.Point(12, 113);
            this.lotID.Name = "lotID";
            this.lotID.Size = new System.Drawing.Size(22, 13);
            this.lotID.TabIndex = 14;
            this.lotID.Text = "Lot";
            // 
            // lotNametextBox
            // 
            this.lotNametextBox.Location = new System.Drawing.Point(461, 37);
            this.lotNametextBox.Name = "lotNametextBox";
            this.lotNametextBox.Size = new System.Drawing.Size(121, 20);
            this.lotNametextBox.TabIndex = 9;
            // 
            // lotAddresstextBox
            // 
            this.lotAddresstextBox.Location = new System.Drawing.Point(461, 72);
            this.lotAddresstextBox.Name = "lotAddresstextBox";
            this.lotAddresstextBox.Size = new System.Drawing.Size(290, 20);
            this.lotAddresstextBox.TabIndex = 11;
            // 
            // addLotIDtextBox
            // 
            this.addLotIDtextBox.Location = new System.Drawing.Point(461, 6);
            this.addLotIDtextBox.Name = "addLotIDtextBox";
            this.addLotIDtextBox.Size = new System.Drawing.Size(121, 20);
            this.addLotIDtextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lot ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lot Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lot Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lot #";
            // 
            // lotNumtextBox
            // 
            this.lotNumtextBox.Location = new System.Drawing.Point(630, 37);
            this.lotNumtextBox.Name = "lotNumtextBox";
            this.lotNumtextBox.Size = new System.Drawing.Size(121, 20);
            this.lotNumtextBox.TabIndex = 10;
            // 
            // addLotButton
            // 
            this.addLotButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addLotButton.Location = new System.Drawing.Point(461, 103);
            this.addLotButton.Name = "addLotButton";
            this.addLotButton.Size = new System.Drawing.Size(75, 23);
            this.addLotButton.TabIndex = 12;
            this.addLotButton.Text = "Add Lot";
            this.addLotButton.UseVisualStyleBackColor = false;
            this.addLotButton.Click += new System.EventHandler(this.addLotButton_Click);
            // 
            // lotcomboBox
            // 
            this.lotcomboBox.FormattingEnabled = true;
            this.lotcomboBox.Location = new System.Drawing.Point(52, 110);
            this.lotcomboBox.Name = "lotcomboBox";
            this.lotcomboBox.Size = new System.Drawing.Size(121, 21);
            this.lotcomboBox.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(215, 222);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(536, 216);
            this.dataGrid.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "FOR TESTING ONLY";
            // 
            // addColorButton
            // 
            this.addColorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addColorButton.Location = new System.Drawing.Point(179, 145);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.Size = new System.Drawing.Size(75, 23);
            this.addColorButton.TabIndex = 5;
            this.addColorButton.Text = "Add Color";
            this.addColorButton.UseVisualStyleBackColor = false;
            this.addColorButton.Click += new System.EventHandler(this.addColorButton_Click);
            // 
            // salesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addColorButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lotcomboBox);
            this.Controls.Add(this.addLotButton);
            this.Controls.Add(this.lotNumtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addLotIDtextBox);
            this.Controls.Add(this.lotAddresstextBox);
            this.Controls.Add(this.lotNametextBox);
            this.Controls.Add(this.lotID);
            this.Controls.Add(this.vinNum);
            this.Controls.Add(this.vinNumtextBox);
            this.Controls.Add(this.refeshInventory);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorcomboBox);
            this.Controls.Add(this.yearcomboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.makeComboBox);
            this.Name = "salesGUI";
            this.Text = "Inventory Check (Sales GUI)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox yearcomboBox;
        private System.Windows.Forms.ComboBox colorcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button refeshInventory;
        private System.Windows.Forms.TextBox vinNumtextBox;
        private System.Windows.Forms.Label vinNum;
        private System.Windows.Forms.Label lotID;
        private System.Windows.Forms.TextBox lotNametextBox;
        private System.Windows.Forms.TextBox lotAddresstextBox;
        private System.Windows.Forms.TextBox addLotIDtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lotNumtextBox;
        private System.Windows.Forms.Button addLotButton;
        private System.Windows.Forms.ComboBox lotcomboBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addColorButton;
    }
}