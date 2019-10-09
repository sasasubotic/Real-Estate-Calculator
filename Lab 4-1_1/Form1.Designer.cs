namespace Lab_4_1_1
{
    partial class Lab_4_1
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
            this.slesDateLabel = new System.Windows.Forms.Label();
            this.saleDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.propertyGroupbox = new System.Windows.Forms.GroupBox();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.countyGroupbox = new System.Windows.Forms.GroupBox();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsboroughRadioButton = new System.Windows.Forms.RadioButton();
            this.propertyPriceLabel = new System.Windows.Forms.Label();
            this.propertyPriceTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.stateSalesTaxAmntLabel = new System.Windows.Forms.Label();
            this.countySalesTaxAmntLabel = new System.Windows.Forms.Label();
            this.commissionAmntLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.propertyGroupbox.SuspendLayout();
            this.countyGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // slesDateLabel
            // 
            this.slesDateLabel.AutoSize = true;
            this.slesDateLabel.Location = new System.Drawing.Point(229, 46);
            this.slesDateLabel.Name = "slesDateLabel";
            this.slesDateLabel.Size = new System.Drawing.Size(62, 13);
            this.slesDateLabel.TabIndex = 0;
            this.slesDateLabel.Text = "Sales Date:";
            this.slesDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // saleDateMaskedTextBox
            // 
            this.saleDateMaskedTextBox.Location = new System.Drawing.Point(325, 43);
            this.saleDateMaskedTextBox.Mask = "00/00/0000";
            this.saleDateMaskedTextBox.Name = "saleDateMaskedTextBox";
            this.saleDateMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.saleDateMaskedTextBox.TabIndex = 1;
            this.saleDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.saleDateMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.salesDateMaskedTextBox_MaskInputRejected);
            // 
            // propertyGroupbox
            // 
            this.propertyGroupbox.Controls.Add(this.commercialRadioButton);
            this.propertyGroupbox.Controls.Add(this.residentialRadioButton);
            this.propertyGroupbox.Location = new System.Drawing.Point(232, 95);
            this.propertyGroupbox.Name = "propertyGroupbox";
            this.propertyGroupbox.Size = new System.Drawing.Size(200, 100);
            this.propertyGroupbox.TabIndex = 2;
            this.propertyGroupbox.TabStop = false;
            this.propertyGroupbox.Text = "Property Type";
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(46, 55);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(79, 17);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.TabStop = true;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(46, 32);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(77, 17);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // countyGroupbox
            // 
            this.countyGroupbox.Controls.Add(this.polkRadioButton);
            this.countyGroupbox.Controls.Add(this.pascoRadioButton);
            this.countyGroupbox.Controls.Add(this.hillsboroughRadioButton);
            this.countyGroupbox.Location = new System.Drawing.Point(232, 221);
            this.countyGroupbox.Name = "countyGroupbox";
            this.countyGroupbox.Size = new System.Drawing.Size(200, 100);
            this.countyGroupbox.TabIndex = 3;
            this.countyGroupbox.TabStop = false;
            this.countyGroupbox.Text = "County";
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.AutoSize = true;
            this.polkRadioButton.Location = new System.Drawing.Point(46, 65);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(46, 17);
            this.polkRadioButton.TabIndex = 3;
            this.polkRadioButton.TabStop = true;
            this.polkRadioButton.Text = "Polk";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            this.polkRadioButton.CheckedChanged += new System.EventHandler(this.polkRadioButton_CheckedChanged);
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(48, 42);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(55, 17);
            this.pascoRadioButton.TabIndex = 2;
            this.pascoRadioButton.TabStop = true;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            this.pascoRadioButton.CheckedChanged += new System.EventHandler(this.pascoRadioButton_CheckedChanged);
            // 
            // hillsboroughRadioButton
            // 
            this.hillsboroughRadioButton.AutoSize = true;
            this.hillsboroughRadioButton.Checked = true;
            this.hillsboroughRadioButton.Location = new System.Drawing.Point(48, 19);
            this.hillsboroughRadioButton.Name = "hillsboroughRadioButton";
            this.hillsboroughRadioButton.Size = new System.Drawing.Size(83, 17);
            this.hillsboroughRadioButton.TabIndex = 1;
            this.hillsboroughRadioButton.TabStop = true;
            this.hillsboroughRadioButton.Text = "Hillsborough";
            this.hillsboroughRadioButton.UseVisualStyleBackColor = true;
            this.hillsboroughRadioButton.CheckedChanged += new System.EventHandler(this.hillsboroughRadioButton_CheckedChanged);
            // 
            // propertyPriceLabel
            // 
            this.propertyPriceLabel.AutoSize = true;
            this.propertyPriceLabel.Location = new System.Drawing.Point(229, 347);
            this.propertyPriceLabel.Name = "propertyPriceLabel";
            this.propertyPriceLabel.Size = new System.Drawing.Size(76, 13);
            this.propertyPriceLabel.TabIndex = 4;
            this.propertyPriceLabel.Text = "Property Price:";
            // 
            // propertyPriceTextBox
            // 
            this.propertyPriceTextBox.Location = new System.Drawing.Point(325, 340);
            this.propertyPriceTextBox.Name = "propertyPriceTextBox";
            this.propertyPriceTextBox.Size = new System.Drawing.Size(78, 20);
            this.propertyPriceTextBox.TabIndex = 5;
            this.propertyPriceTextBox.TextChanged += new System.EventHandler(this.propertyPriceTextBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(263, 395);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(140, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "&Update Property Price";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.AutoSize = true;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(229, 467);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(85, 13);
            this.stateSalesTaxLabel.TabIndex = 7;
            this.stateSalesTaxLabel.Text = "State Sales Tax:";
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.AutoSize = true;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(229, 508);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(93, 13);
            this.countySalesTaxLabel.TabIndex = 8;
            this.countySalesTaxLabel.Text = "County Sales Tax:";
            // 
            // commissionLabel
            // 
            this.commissionLabel.AutoSize = true;
            this.commissionLabel.Location = new System.Drawing.Point(229, 551);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(65, 13);
            this.commissionLabel.TabIndex = 9;
            this.commissionLabel.Text = "Commission:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(229, 603);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 10;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // stateSalesTaxAmntLabel
            // 
            this.stateSalesTaxAmntLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxAmntLabel.Location = new System.Drawing.Point(347, 455);
            this.stateSalesTaxAmntLabel.Name = "stateSalesTaxAmntLabel";
            this.stateSalesTaxAmntLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stateSalesTaxAmntLabel.Size = new System.Drawing.Size(85, 25);
            this.stateSalesTaxAmntLabel.TabIndex = 11;
            this.stateSalesTaxAmntLabel.Text = "$0.00";
            this.stateSalesTaxAmntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countySalesTaxAmntLabel
            // 
            this.countySalesTaxAmntLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxAmntLabel.Location = new System.Drawing.Point(347, 496);
            this.countySalesTaxAmntLabel.Name = "countySalesTaxAmntLabel";
            this.countySalesTaxAmntLabel.Size = new System.Drawing.Size(85, 25);
            this.countySalesTaxAmntLabel.TabIndex = 12;
            this.countySalesTaxAmntLabel.Text = "$0.00";
            this.countySalesTaxAmntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countySalesTaxAmntLabel.Click += new System.EventHandler(this.countySalesTaxAmntLabel_Click);
            // 
            // commissionAmntLabel
            // 
            this.commissionAmntLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionAmntLabel.Location = new System.Drawing.Point(347, 539);
            this.commissionAmntLabel.Name = "commissionAmntLabel";
            this.commissionAmntLabel.Size = new System.Drawing.Size(85, 25);
            this.commissionAmntLabel.TabIndex = 13;
            this.commissionAmntLabel.Text = "$0.00";
            this.commissionAmntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(347, 591);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(85, 25);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "$0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(392, 655);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(278, 655);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(145, 655);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Lab_4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 711);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.commissionAmntLabel);
            this.Controls.Add(this.countySalesTaxAmntLabel);
            this.Controls.Add(this.stateSalesTaxAmntLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.propertyPriceTextBox);
            this.Controls.Add(this.propertyPriceLabel);
            this.Controls.Add(this.countyGroupbox);
            this.Controls.Add(this.propertyGroupbox);
            this.Controls.Add(this.saleDateMaskedTextBox);
            this.Controls.Add(this.slesDateLabel);
            this.Name = "Lab_4_1";
            this.Text = "Real Estate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.propertyGroupbox.ResumeLayout(false);
            this.propertyGroupbox.PerformLayout();
            this.countyGroupbox.ResumeLayout(false);
            this.countyGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slesDateLabel;
        private System.Windows.Forms.MaskedTextBox saleDateMaskedTextBox;
        private System.Windows.Forms.GroupBox propertyGroupbox;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.GroupBox countyGroupbox;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton hillsboroughRadioButton;
        private System.Windows.Forms.Label propertyPriceLabel;
        private System.Windows.Forms.TextBox propertyPriceTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label stateSalesTaxAmntLabel;
        private System.Windows.Forms.Label countySalesTaxAmntLabel;
        private System.Windows.Forms.Label commissionAmntLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
    }
}

