namespace WordInteractionLab8.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.IntoDocumentButton = new System.Windows.Forms.Button();
            this.UploadDbButton = new System.Windows.Forms.Button();
            this.AddOrganizationButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PaymentsPage = new System.Windows.Forms.TabPage();
            this.OrganizationsPage = new System.Windows.Forms.TabPage();
            this.BanksPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.OrganizationsPage.SuspendLayout();
            this.BanksPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntoDocumentButton
            // 
            this.IntoDocumentButton.Location = new System.Drawing.Point(1048, 584);
            this.IntoDocumentButton.Name = "IntoDocumentButton";
            this.IntoDocumentButton.Size = new System.Drawing.Size(145, 28);
            this.IntoDocumentButton.TabIndex = 1;
            this.IntoDocumentButton.Text = "Into Document";
            this.IntoDocumentButton.UseVisualStyleBackColor = true;
            this.IntoDocumentButton.Click += new System.EventHandler(this.IntoDocumentButtonClick);
            // 
            // UploadDbButton
            // 
            this.UploadDbButton.Location = new System.Drawing.Point(701, 81);
            this.UploadDbButton.Name = "UploadDbButton";
            this.UploadDbButton.Size = new System.Drawing.Size(145, 28);
            this.UploadDbButton.TabIndex = 2;
            this.UploadDbButton.Text = "Upload DB";
            this.UploadDbButton.UseVisualStyleBackColor = true;
            // 
            // AddOrganizationButton
            // 
            this.AddOrganizationButton.Location = new System.Drawing.Point(522, 399);
            this.AddOrganizationButton.Name = "AddOrganizationButton";
            this.AddOrganizationButton.Size = new System.Drawing.Size(145, 28);
            this.AddOrganizationButton.TabIndex = 3;
            this.AddOrganizationButton.Text = "Add Organization";
            this.AddOrganizationButton.UseVisualStyleBackColor = true;
            this.AddOrganizationButton.Click += new System.EventHandler(this.AddOrganizationButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(749, 390);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(145, 28);
            this.AddAccountButton.TabIndex = 4;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PaymentsPage);
            this.tabControl1.Controls.Add(this.OrganizationsPage);
            this.tabControl1.Controls.Add(this.BanksPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 728);
            this.tabControl1.TabIndex = 5;
            // 
            // PaymentsPage
            // 
            this.PaymentsPage.Location = new System.Drawing.Point(4, 25);
            this.PaymentsPage.Name = "PaymentsPage";
            this.PaymentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentsPage.Size = new System.Drawing.Size(1014, 699);
            this.PaymentsPage.TabIndex = 0;
            this.PaymentsPage.Text = "Payments";
            this.PaymentsPage.UseVisualStyleBackColor = true;
            // 
            // OrganizationsPage
            // 
            this.OrganizationsPage.Controls.Add(this.AddOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.AddAccountButton);
            this.OrganizationsPage.Location = new System.Drawing.Point(4, 25);
            this.OrganizationsPage.Name = "OrganizationsPage";
            this.OrganizationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizationsPage.Size = new System.Drawing.Size(1014, 699);
            this.OrganizationsPage.TabIndex = 1;
            this.OrganizationsPage.Text = "Organizations";
            this.OrganizationsPage.UseVisualStyleBackColor = true;
            // 
            // BanksPage
            // 
            this.BanksPage.Controls.Add(this.UploadDbButton);
            this.BanksPage.Location = new System.Drawing.Point(4, 25);
            this.BanksPage.Name = "BanksPage";
            this.BanksPage.Padding = new System.Windows.Forms.Padding(3);
            this.BanksPage.Size = new System.Drawing.Size(1014, 699);
            this.BanksPage.TabIndex = 2;
            this.BanksPage.Text = "Banks";
            this.BanksPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1205, 904);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.IntoDocumentButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.OrganizationsPage.ResumeLayout(false);
            this.BanksPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button IntoDocumentButton;
        private System.Windows.Forms.Button UploadDbButton;
        private System.Windows.Forms.Button AddOrganizationButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PaymentsPage;
        private System.Windows.Forms.TabPage OrganizationsPage;
        private System.Windows.Forms.TabPage BanksPage;
    }
}

