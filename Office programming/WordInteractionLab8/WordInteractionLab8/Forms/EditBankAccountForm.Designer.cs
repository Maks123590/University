namespace WordInteractionLab8.Forms
{
    partial class EditBankAccountForm
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
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bikMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currAccMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.bankInfoPanel.Controls.Add(this.maskedTextBox3);
            this.bankInfoPanel.Controls.Add(this.maskedTextBox2);
            this.bankInfoPanel.Controls.Add(this.maskedTextBox1);
            this.bankInfoPanel.Controls.Add(this.button1);
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
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(122, 84);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(147, 22);
            this.maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(122, 49);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(147, 22);
            this.maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(186, 135);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(259, 22);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bikMaskedTextBox
            // 
            this.bikMaskedTextBox.Location = new System.Drawing.Point(122, 11);
            this.bikMaskedTextBox.Name = "bikMaskedTextBox";
            this.bikMaskedTextBox.Size = new System.Drawing.Size(226, 22);
            this.bikMaskedTextBox.TabIndex = 0;
            this.bikMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Принять";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EditBankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 385);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.currAccMaskedTextBox);
            this.Controls.Add(this.bankInfoPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditBankAccountForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}