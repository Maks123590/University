namespace WordInteractionLab8.Forms
{
    partial class BankAccountForm
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
            this.bankInfoPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.locationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.correspAccMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fillByBikButton = new System.Windows.Forms.Button();
            this.bikMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currAccMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bankInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "БИК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Счет";
            // 
            // bankInfoPanel
            // 
            this.bankInfoPanel.Controls.Add(this.label4);
            this.bankInfoPanel.Controls.Add(this.locationMaskedTextBox);
            this.bankInfoPanel.Controls.Add(this.nameMaskedTextBox);
            this.bankInfoPanel.Controls.Add(this.correspAccMaskedTextBox);
            this.bankInfoPanel.Controls.Add(this.fillByBikButton);
            this.bankInfoPanel.Controls.Add(this.bikMaskedTextBox);
            this.bankInfoPanel.Controls.Add(this.label1);
            this.bankInfoPanel.Controls.Add(this.label7);
            this.bankInfoPanel.Controls.Add(this.label5);
            this.bankInfoPanel.Location = new System.Drawing.Point(15, 29);
            this.bankInfoPanel.Name = "bankInfoPanel";
            this.bankInfoPanel.Size = new System.Drawing.Size(465, 200);
            this.bankInfoPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Корреспондентский счет";
            // 
            // locationMaskedTextBox
            // 
            this.locationMaskedTextBox.Enabled = false;
            this.locationMaskedTextBox.Location = new System.Drawing.Point(122, 84);
            this.locationMaskedTextBox.Name = "locationMaskedTextBox";
            this.locationMaskedTextBox.Size = new System.Drawing.Size(333, 22);
            this.locationMaskedTextBox.TabIndex = 12;
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.Enabled = false;
            this.nameMaskedTextBox.Location = new System.Drawing.Point(122, 49);
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.Size = new System.Drawing.Size(333, 22);
            this.nameMaskedTextBox.TabIndex = 11;
            // 
            // correspAccMaskedTextBox
            // 
            this.correspAccMaskedTextBox.Enabled = false;
            this.correspAccMaskedTextBox.Location = new System.Drawing.Point(186, 135);
            this.correspAccMaskedTextBox.Name = "correspAccMaskedTextBox";
            this.correspAccMaskedTextBox.Size = new System.Drawing.Size(269, 22);
            this.correspAccMaskedTextBox.TabIndex = 10;
            // 
            // fillByBikButton
            // 
            this.fillByBikButton.Location = new System.Drawing.Point(354, 8);
            this.fillByBikButton.Name = "fillByBikButton";
            this.fillByBikButton.Size = new System.Drawing.Size(101, 28);
            this.fillByBikButton.TabIndex = 9;
            this.fillByBikButton.Text = "Заполнить";
            this.fillByBikButton.UseVisualStyleBackColor = true;
            this.fillByBikButton.Click += new System.EventHandler(this.FillByBikButtonClick);
            // 
            // bikMaskedTextBox
            // 
            this.bikMaskedTextBox.Location = new System.Drawing.Point(122, 11);
            this.bikMaskedTextBox.Name = "bikMaskedTextBox";
            this.bikMaskedTextBox.Size = new System.Drawing.Size(226, 22);
            this.bikMaskedTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Расположение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Имя";
            // 
            // currAccMaskedTextBox
            // 
            this.currAccMaskedTextBox.Location = new System.Drawing.Point(137, 256);
            this.currAccMaskedTextBox.Name = "currAccMaskedTextBox";
            this.currAccMaskedTextBox.Size = new System.Drawing.Size(265, 22);
            this.currAccMaskedTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Информация о Банке";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 337);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(162, 28);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(318, 337);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(162, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 385);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.currAccMaskedTextBox);
            this.Controls.Add(this.bankInfoPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BankAccountForm";
            this.Text = "EditBankAccountForm";
            this.bankInfoPanel.ResumeLayout(false);
            this.bankInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bankInfoPanel;
        private System.Windows.Forms.MaskedTextBox bikMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox currAccMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fillByBikButton;
        private System.Windows.Forms.MaskedTextBox locationMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox correspAccMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}