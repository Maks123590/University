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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IntoDocumentButton = new System.Windows.Forms.Button();
            this.UploadDbButton = new System.Windows.Forms.Button();
            this.AddOrganizationButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PaymentsPage = new System.Windows.Forms.TabPage();
            this.previewPaymentComponent1 = new WordInteractionLab8.Components.PreviewPaymentComponent();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.deletePaymentButton = new System.Windows.Forms.Button();
            this.editPaymentButton = new System.Windows.Forms.Button();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.OrganizationsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BanksPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bankInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correspondentAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.PaymentsPage.SuspendLayout();
            this.OrganizationsPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BanksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // IntoDocumentButton
            // 
            this.IntoDocumentButton.Location = new System.Drawing.Point(17, 643);
            this.IntoDocumentButton.Name = "IntoDocumentButton";
            this.IntoDocumentButton.Size = new System.Drawing.Size(121, 28);
            this.IntoDocumentButton.TabIndex = 1;
            this.IntoDocumentButton.Text = "Into Document";
            this.IntoDocumentButton.UseVisualStyleBackColor = true;
            this.IntoDocumentButton.Click += new System.EventHandler(this.IntoDocumentButtonClick);
            // 
            // UploadDbButton
            // 
            this.UploadDbButton.Location = new System.Drawing.Point(989, 130);
            this.UploadDbButton.Name = "UploadDbButton";
            this.UploadDbButton.Size = new System.Drawing.Size(145, 28);
            this.UploadDbButton.TabIndex = 2;
            this.UploadDbButton.Text = "Upload DB";
            this.UploadDbButton.UseVisualStyleBackColor = true;
            // 
            // AddOrganizationButton
            // 
            this.AddOrganizationButton.Location = new System.Drawing.Point(20, 634);
            this.AddOrganizationButton.Name = "AddOrganizationButton";
            this.AddOrganizationButton.Size = new System.Drawing.Size(145, 28);
            this.AddOrganizationButton.TabIndex = 3;
            this.AddOrganizationButton.Text = "Add Organization";
            this.AddOrganizationButton.UseVisualStyleBackColor = true;
            this.AddOrganizationButton.Click += new System.EventHandler(this.AddOrganizationButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(172, 634);
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
            this.tabControl1.Size = new System.Drawing.Size(1174, 728);
            this.tabControl1.TabIndex = 5;
            // 
            // PaymentsPage
            // 
            this.PaymentsPage.Controls.Add(this.previewPaymentComponent1);
            this.PaymentsPage.Controls.Add(this.listBox2);
            this.PaymentsPage.Controls.Add(this.deletePaymentButton);
            this.PaymentsPage.Controls.Add(this.editPaymentButton);
            this.PaymentsPage.Controls.Add(this.addPaymentButton);
            this.PaymentsPage.Controls.Add(this.IntoDocumentButton);
            this.PaymentsPage.Location = new System.Drawing.Point(4, 25);
            this.PaymentsPage.Name = "PaymentsPage";
            this.PaymentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentsPage.Size = new System.Drawing.Size(1166, 699);
            this.PaymentsPage.TabIndex = 0;
            this.PaymentsPage.Text = "Payments";
            this.PaymentsPage.UseVisualStyleBackColor = true;
            // 
            // previewPaymentComponent1
            // 
            this.previewPaymentComponent1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPaymentComponent1.BackgroundImage")));
            this.previewPaymentComponent1.Location = new System.Drawing.Point(354, 15);
            this.previewPaymentComponent1.Name = "previewPaymentComponent1";
            this.previewPaymentComponent1.Size = new System.Drawing.Size(623, 656);
            this.previewPaymentComponent1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(15, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(300, 548);
            this.listBox2.TabIndex = 6;
            // 
            // deletePaymentButton
            // 
            this.deletePaymentButton.Location = new System.Drawing.Point(218, 609);
            this.deletePaymentButton.Name = "deletePaymentButton";
            this.deletePaymentButton.Size = new System.Drawing.Size(105, 28);
            this.deletePaymentButton.TabIndex = 5;
            this.deletePaymentButton.Text = "Delete";
            this.deletePaymentButton.UseVisualStyleBackColor = true;
            // 
            // editPaymentButton
            // 
            this.editPaymentButton.Location = new System.Drawing.Point(129, 609);
            this.editPaymentButton.Name = "editPaymentButton";
            this.editPaymentButton.Size = new System.Drawing.Size(83, 28);
            this.editPaymentButton.TabIndex = 4;
            this.editPaymentButton.Text = "Edit";
            this.editPaymentButton.UseVisualStyleBackColor = true;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Location = new System.Drawing.Point(17, 609);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(106, 28);
            this.addPaymentButton.TabIndex = 3;
            this.addPaymentButton.Text = "Add new";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            // 
            // OrganizationsPage
            // 
            this.OrganizationsPage.Controls.Add(this.panel2);
            this.OrganizationsPage.Controls.Add(this.panel1);
            this.OrganizationsPage.Controls.Add(this.listBox1);
            this.OrganizationsPage.Controls.Add(this.AddOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.AddAccountButton);
            this.OrganizationsPage.Location = new System.Drawing.Point(4, 25);
            this.OrganizationsPage.Name = "OrganizationsPage";
            this.OrganizationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizationsPage.Size = new System.Drawing.Size(1166, 699);
            this.OrganizationsPage.TabIndex = 1;
            this.OrganizationsPage.Text = "Organizations";
            this.OrganizationsPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(791, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 548);
            this.panel2.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Current Account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "BIK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bank Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bank Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(335, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 548);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bank Accounts";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(34, 228);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(366, 292);
            this.listBox3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "INN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 548);
            this.listBox1.TabIndex = 5;
            // 
            // BanksPage
            // 
            this.BanksPage.Controls.Add(this.dataGridView2);
            this.BanksPage.Controls.Add(this.UploadDbButton);
            this.BanksPage.Location = new System.Drawing.Point(4, 25);
            this.BanksPage.Name = "BanksPage";
            this.BanksPage.Padding = new System.Windows.Forms.Padding(3);
            this.BanksPage.Size = new System.Drawing.Size(1166, 699);
            this.BanksPage.TabIndex = 2;
            this.BanksPage.Text = "Banks";
            this.BanksPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bikDataGridViewTextBoxColumn,
            this.correspondentAccountDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.localityDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bankInfoBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(8, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(943, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // bankInfoBindingSource1
            // 
            this.bankInfoBindingSource1.DataSource = typeof(WordInteractionLab8.Models.BankInfo);
            // 
            // bikDataGridViewTextBoxColumn
            // 
            this.bikDataGridViewTextBoxColumn.DataPropertyName = "Bik";
            this.bikDataGridViewTextBoxColumn.HeaderText = "Bik";
            this.bikDataGridViewTextBoxColumn.Name = "bikDataGridViewTextBoxColumn";
            this.bikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correspondentAccountDataGridViewTextBoxColumn
            // 
            this.correspondentAccountDataGridViewTextBoxColumn.DataPropertyName = "CorrespondentAccount";
            this.correspondentAccountDataGridViewTextBoxColumn.HeaderText = "CorrespondentAccount";
            this.correspondentAccountDataGridViewTextBoxColumn.Name = "correspondentAccountDataGridViewTextBoxColumn";
            this.correspondentAccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            this.shortNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localityDataGridViewTextBoxColumn
            // 
            this.localityDataGridViewTextBoxColumn.DataPropertyName = "Locality";
            this.localityDataGridViewTextBoxColumn.HeaderText = "Locality";
            this.localityDataGridViewTextBoxColumn.Name = "localityDataGridViewTextBoxColumn";
            this.localityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1171, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.PaymentsPage.ResumeLayout(false);
            this.OrganizationsPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BanksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button deletePaymentButton;
        private System.Windows.Forms.Button editPaymentButton;
        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bankInfoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private Components.PreviewPaymentComponent previewPaymentComponent1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correspondentAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bankInfoBindingSource1;
    }
}

