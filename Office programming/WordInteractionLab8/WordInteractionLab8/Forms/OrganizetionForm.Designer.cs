namespace WordInteractionLab8.Forms
{
    partial class OrganizationForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baknInfoListBox = new System.Windows.Forms.ListBox();
            this.NameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.innMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kppMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddBAccountButton = new System.Windows.Forms.Button();
            this.EditBAccountButton = new System.Windows.Forms.Button();
            this.DeleteBAccountButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "КПП";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Банковские счета";
            // 
            // baknInfoListBox
            // 
            this.baknInfoListBox.FormattingEnabled = true;
            this.baknInfoListBox.ItemHeight = 16;
            this.baknInfoListBox.Location = new System.Drawing.Point(28, 238);
            this.baknInfoListBox.Name = "baknInfoListBox";
            this.baknInfoListBox.Size = new System.Drawing.Size(341, 276);
            this.baknInfoListBox.TabIndex = 7;
            // 
            // NameMaskedTextBox
            // 
            this.NameMaskedTextBox.Location = new System.Drawing.Point(114, 38);
            this.NameMaskedTextBox.Name = "NameMaskedTextBox";
            this.NameMaskedTextBox.Size = new System.Drawing.Size(255, 22);
            this.NameMaskedTextBox.TabIndex = 8;
            // 
            // innMaskedTextBox
            // 
            this.innMaskedTextBox.Location = new System.Drawing.Point(114, 98);
            this.innMaskedTextBox.Name = "innMaskedTextBox";
            this.innMaskedTextBox.Size = new System.Drawing.Size(255, 22);
            this.innMaskedTextBox.TabIndex = 9;
            // 
            // kppMaskedTextBox
            // 
            this.kppMaskedTextBox.Location = new System.Drawing.Point(114, 153);
            this.kppMaskedTextBox.Name = "kppMaskedTextBox";
            this.kppMaskedTextBox.Size = new System.Drawing.Size(255, 22);
            this.kppMaskedTextBox.TabIndex = 10;
            // 
            // AddBAccountButton
            // 
            this.AddBAccountButton.Location = new System.Drawing.Point(382, 238);
            this.AddBAccountButton.Name = "AddBAccountButton";
            this.AddBAccountButton.Size = new System.Drawing.Size(128, 28);
            this.AddBAccountButton.TabIndex = 11;
            this.AddBAccountButton.Text = "Добавить";
            this.AddBAccountButton.UseVisualStyleBackColor = true;
            this.AddBAccountButton.Click += new System.EventHandler(this.AddBAccountButtonClick);
            // 
            // EditBAccountButton
            // 
            this.EditBAccountButton.Location = new System.Drawing.Point(382, 287);
            this.EditBAccountButton.Name = "EditBAccountButton";
            this.EditBAccountButton.Size = new System.Drawing.Size(128, 28);
            this.EditBAccountButton.TabIndex = 12;
            this.EditBAccountButton.Text = "Редактировать";
            this.EditBAccountButton.UseVisualStyleBackColor = true;
            this.EditBAccountButton.Click += new System.EventHandler(this.EditBAccountButtonClick);
            // 
            // DeleteBAccountButton
            // 
            this.DeleteBAccountButton.Location = new System.Drawing.Point(382, 344);
            this.DeleteBAccountButton.Name = "DeleteBAccountButton";
            this.DeleteBAccountButton.Size = new System.Drawing.Size(128, 28);
            this.DeleteBAccountButton.TabIndex = 13;
            this.DeleteBAccountButton.Text = "Удалить";
            this.DeleteBAccountButton.UseVisualStyleBackColor = true;
            this.DeleteBAccountButton.Click += new System.EventHandler(this.DeleteBAccountButtonClick);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 573);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(173, 28);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "Применить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(337, 573);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(173, 28);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 613);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.DeleteBAccountButton);
            this.Controls.Add(this.EditBAccountButton);
            this.Controls.Add(this.AddBAccountButton);
            this.Controls.Add(this.kppMaskedTextBox);
            this.Controls.Add(this.innMaskedTextBox);
            this.Controls.Add(this.NameMaskedTextBox);
            this.Controls.Add(this.baknInfoListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrganizationForm";
            this.Text = "AddOrganizetionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox baknInfoListBox;
        private System.Windows.Forms.MaskedTextBox NameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox innMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox kppMaskedTextBox;
        private System.Windows.Forms.Button AddBAccountButton;
        private System.Windows.Forms.Button EditBAccountButton;
        private System.Windows.Forms.Button DeleteBAccountButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}