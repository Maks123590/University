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
            this.uploadDbButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PaymentsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintOneButton = new System.Windows.Forms.Button();
            this.PrintAllButton = new System.Windows.Forms.Button();
            this.PaymentsListBox = new System.Windows.Forms.ListBox();
            this.deletePaymentButton = new System.Windows.Forms.Button();
            this.editPaymentButton = new System.Windows.Forms.Button();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.OrganizationsPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteOrganizationButton = new System.Windows.Forms.Button();
            this.editOrganizationButton = new System.Windows.Forms.Button();
            this.addOrganizationButton = new System.Windows.Forms.Button();
            this.bankAccInfoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bikLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bankLocationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentAccountlLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.organizationInfoPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bankAccountsListBox = new System.Windows.Forms.ListBox();
            this.cppOrganizationLabel = new System.Windows.Forms.Label();
            this.innOrganizationLabel = new System.Windows.Forms.Label();
            this.organizationNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.organizationMainListBox = new System.Windows.Forms.ListBox();
            this.BanksPage = new System.Windows.Forms.TabPage();
            this.dBVersionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.banksDataGridView = new System.Windows.Forms.DataGridView();
            this.bankInfoApiDBModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PaymentsPage.SuspendLayout();
            this.OrganizationsPage.SuspendLayout();
            this.bankAccInfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.organizationInfoPanel.SuspendLayout();
            this.BanksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoApiDBModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IntoDocumentButton
            // 
            this.IntoDocumentButton.Location = new System.Drawing.Point(17, 643);
            this.IntoDocumentButton.Name = "IntoDocumentButton";
            this.IntoDocumentButton.Size = new System.Drawing.Size(106, 31);
            this.IntoDocumentButton.TabIndex = 1;
            this.IntoDocumentButton.Text = "В документ";
            this.IntoDocumentButton.UseVisualStyleBackColor = true;
            // 
            // uploadDbButton
            // 
            this.uploadDbButton.Location = new System.Drawing.Point(1010, 130);
            this.uploadDbButton.Name = "uploadDbButton";
            this.uploadDbButton.Size = new System.Drawing.Size(145, 28);
            this.uploadDbButton.TabIndex = 2;
            this.uploadDbButton.Text = "Обновить базу";
            this.uploadDbButton.UseVisualStyleBackColor = true;
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
            this.PaymentsPage.Controls.Add(this.panel2);
            this.PaymentsPage.Controls.Add(this.PrintOneButton);
            this.PaymentsPage.Controls.Add(this.PrintAllButton);
            this.PaymentsPage.Controls.Add(this.PaymentsListBox);
            this.PaymentsPage.Controls.Add(this.deletePaymentButton);
            this.PaymentsPage.Controls.Add(this.editPaymentButton);
            this.PaymentsPage.Controls.Add(this.addPaymentButton);
            this.PaymentsPage.Controls.Add(this.IntoDocumentButton);
            this.PaymentsPage.Location = new System.Drawing.Point(4, 25);
            this.PaymentsPage.Name = "PaymentsPage";
            this.PaymentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentsPage.Size = new System.Drawing.Size(1166, 699);
            this.PaymentsPage.TabIndex = 0;
            this.PaymentsPage.Text = "Платежные поручения";
            this.PaymentsPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(450, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 659);
            this.panel2.TabIndex = 10;
            // 
            // PrintOneButton
            // 
            this.PrintOneButton.Location = new System.Drawing.Point(129, 643);
            this.PrintOneButton.Name = "PrintOneButton";
            this.PrintOneButton.Size = new System.Drawing.Size(117, 28);
            this.PrintOneButton.TabIndex = 9;
            this.PrintOneButton.Text = "Печать";
            this.PrintOneButton.UseVisualStyleBackColor = true;
            // 
            // PrintAllButton
            // 
            this.PrintAllButton.Location = new System.Drawing.Point(252, 643);
            this.PrintAllButton.Name = "PrintAllButton";
            this.PrintAllButton.Size = new System.Drawing.Size(105, 28);
            this.PrintAllButton.TabIndex = 8;
            this.PrintAllButton.Text = "Печатать все";
            this.PrintAllButton.UseVisualStyleBackColor = true;
            // 
            // PaymentsListBox
            // 
            this.PaymentsListBox.FormattingEnabled = true;
            this.PaymentsListBox.ItemHeight = 16;
            this.PaymentsListBox.Location = new System.Drawing.Point(15, 15);
            this.PaymentsListBox.Name = "PaymentsListBox";
            this.PaymentsListBox.Size = new System.Drawing.Size(342, 548);
            this.PaymentsListBox.TabIndex = 6;
            // 
            // deletePaymentButton
            // 
            this.deletePaymentButton.Location = new System.Drawing.Point(252, 609);
            this.deletePaymentButton.Name = "deletePaymentButton";
            this.deletePaymentButton.Size = new System.Drawing.Size(105, 28);
            this.deletePaymentButton.TabIndex = 5;
            this.deletePaymentButton.Text = "Удалить";
            this.deletePaymentButton.UseVisualStyleBackColor = true;
            // 
            // editPaymentButton
            // 
            this.editPaymentButton.Location = new System.Drawing.Point(129, 609);
            this.editPaymentButton.Name = "editPaymentButton";
            this.editPaymentButton.Size = new System.Drawing.Size(117, 28);
            this.editPaymentButton.TabIndex = 4;
            this.editPaymentButton.Text = "Редактировать";
            this.editPaymentButton.UseVisualStyleBackColor = true;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Location = new System.Drawing.Point(17, 609);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(106, 28);
            this.addPaymentButton.TabIndex = 3;
            this.addPaymentButton.Text = "Добавить новое";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.AddPaymentButtonClick);
            // 
            // OrganizationsPage
            // 
            this.OrganizationsPage.Controls.Add(this.label6);
            this.OrganizationsPage.Controls.Add(this.label8);
            this.OrganizationsPage.Controls.Add(this.button1);
            this.OrganizationsPage.Controls.Add(this.deleteOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.editOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.addOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.bankAccInfoPanel);
            this.OrganizationsPage.Controls.Add(this.organizationInfoPanel);
            this.OrganizationsPage.Controls.Add(this.organizationMainListBox);
            this.OrganizationsPage.Location = new System.Drawing.Point(4, 25);
            this.OrganizationsPage.Name = "OrganizationsPage";
            this.OrganizationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizationsPage.Size = new System.Drawing.Size(1166, 699);
            this.OrganizationsPage.TabIndex = 1;
            this.OrganizationsPage.Text = "Организации";
            this.OrganizationsPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Обновить базу банков";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deleteOrganizationButton
            // 
            this.deleteOrganizationButton.Location = new System.Drawing.Point(252, 591);
            this.deleteOrganizationButton.Name = "deleteOrganizationButton";
            this.deleteOrganizationButton.Size = new System.Drawing.Size(105, 28);
            this.deleteOrganizationButton.TabIndex = 10;
            this.deleteOrganizationButton.Text = "Удалить";
            this.deleteOrganizationButton.UseVisualStyleBackColor = true;
            this.deleteOrganizationButton.Click += new System.EventHandler(this.DeleteOrganizationButtonClick);
            // 
            // editOrganizationButton
            // 
            this.editOrganizationButton.Location = new System.Drawing.Point(129, 591);
            this.editOrganizationButton.Name = "editOrganizationButton";
            this.editOrganizationButton.Size = new System.Drawing.Size(117, 28);
            this.editOrganizationButton.TabIndex = 9;
            this.editOrganizationButton.Text = "Редактировать";
            this.editOrganizationButton.UseVisualStyleBackColor = true;
            this.editOrganizationButton.Click += new System.EventHandler(this.EditOrganizationButtonClick);
            // 
            // addOrganizationButton
            // 
            this.addOrganizationButton.Location = new System.Drawing.Point(15, 591);
            this.addOrganizationButton.Name = "addOrganizationButton";
            this.addOrganizationButton.Size = new System.Drawing.Size(108, 28);
            this.addOrganizationButton.TabIndex = 8;
            this.addOrganizationButton.Text = "Добавить новое";
            this.addOrganizationButton.UseVisualStyleBackColor = true;
            this.addOrganizationButton.Click += new System.EventHandler(this.AddOrganizationButtonClick);
            // 
            // bankAccInfoPanel
            // 
            this.bankAccInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankAccInfoPanel.Controls.Add(this.panel1);
            this.bankAccInfoPanel.Controls.Add(this.label4);
            this.bankAccInfoPanel.Controls.Add(this.currentAccountlLabel);
            this.bankAccInfoPanel.Controls.Add(this.label11);
            this.bankAccInfoPanel.Location = new System.Drawing.Point(705, 15);
            this.bankAccInfoPanel.Name = "bankAccInfoPanel";
            this.bankAccInfoPanel.Size = new System.Drawing.Size(450, 548);
            this.bankAccInfoPanel.TabIndex = 7;
            this.bankAccInfoPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bankNameLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bikLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bankLocationLabel);
            this.panel1.Location = new System.Drawing.Point(30, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 151);
            this.panel1.TabIndex = 17;
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.Location = new System.Drawing.Point(8, 19);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(376, 46);
            this.bankNameLabel.TabIndex = 12;
            this.bankNameLabel.Text = "label12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Расположение";
            // 
            // bikLabel
            // 
            this.bikLabel.AutoSize = true;
            this.bikLabel.Location = new System.Drawing.Point(148, 116);
            this.bikLabel.Name = "bikLabel";
            this.bikLabel.Size = new System.Drawing.Size(54, 17);
            this.bikLabel.TabIndex = 14;
            this.bikLabel.Text = "label14";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Бик";
            // 
            // bankLocationLabel
            // 
            this.bankLocationLabel.AutoSize = true;
            this.bankLocationLabel.Location = new System.Drawing.Point(148, 69);
            this.bankLocationLabel.Name = "bankLocationLabel";
            this.bankLocationLabel.Size = new System.Drawing.Size(54, 17);
            this.bankLocationLabel.TabIndex = 13;
            this.bankLocationLabel.Text = "label13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сведения о банке";
            // 
            // currentAccountlLabel
            // 
            this.currentAccountlLabel.AutoSize = true;
            this.currentAccountlLabel.Location = new System.Drawing.Point(180, 226);
            this.currentAccountlLabel.Name = "currentAccountlLabel";
            this.currentAccountlLabel.Size = new System.Drawing.Size(54, 17);
            this.currentAccountlLabel.TabIndex = 15;
            this.currentAccountlLabel.Text = "label15";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Текущий счет";
            // 
            // organizationInfoPanel
            // 
            this.organizationInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organizationInfoPanel.Controls.Add(this.label7);
            this.organizationInfoPanel.Controls.Add(this.bankAccountsListBox);
            this.organizationInfoPanel.Controls.Add(this.cppOrganizationLabel);
            this.organizationInfoPanel.Controls.Add(this.innOrganizationLabel);
            this.organizationInfoPanel.Controls.Add(this.organizationNameLabel);
            this.organizationInfoPanel.Controls.Add(this.label3);
            this.organizationInfoPanel.Controls.Add(this.label2);
            this.organizationInfoPanel.Controls.Add(this.label1);
            this.organizationInfoPanel.Location = new System.Drawing.Point(372, 15);
            this.organizationInfoPanel.Name = "organizationInfoPanel";
            this.organizationInfoPanel.Size = new System.Drawing.Size(315, 548);
            this.organizationInfoPanel.TabIndex = 6;
            this.organizationInfoPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Банковские счета";
            // 
            // bankAccountsListBox
            // 
            this.bankAccountsListBox.FormattingEnabled = true;
            this.bankAccountsListBox.ItemHeight = 16;
            this.bankAccountsListBox.Location = new System.Drawing.Point(25, 226);
            this.bankAccountsListBox.Name = "bankAccountsListBox";
            this.bankAccountsListBox.Size = new System.Drawing.Size(259, 292);
            this.bankAccountsListBox.TabIndex = 6;
            this.bankAccountsListBox.SelectedIndexChanged += new System.EventHandler(this.BankAccountsListBoxSelectedIndexChanged);
            // 
            // cppOrganizationLabel
            // 
            this.cppOrganizationLabel.AutoSize = true;
            this.cppOrganizationLabel.Location = new System.Drawing.Point(91, 132);
            this.cppOrganizationLabel.Name = "cppOrganizationLabel";
            this.cppOrganizationLabel.Size = new System.Drawing.Size(46, 17);
            this.cppOrganizationLabel.TabIndex = 5;
            this.cppOrganizationLabel.Text = "label6";
            // 
            // innOrganizationLabel
            // 
            this.innOrganizationLabel.AutoSize = true;
            this.innOrganizationLabel.Location = new System.Drawing.Point(91, 94);
            this.innOrganizationLabel.Name = "innOrganizationLabel";
            this.innOrganizationLabel.Size = new System.Drawing.Size(46, 17);
            this.innOrganizationLabel.TabIndex = 4;
            this.innOrganizationLabel.Text = "label5";
            // 
            // organizationNameLabel
            // 
            this.organizationNameLabel.AutoSize = true;
            this.organizationNameLabel.Location = new System.Drawing.Point(91, 45);
            this.organizationNameLabel.Name = "organizationNameLabel";
            this.organizationNameLabel.Size = new System.Drawing.Size(46, 17);
            this.organizationNameLabel.TabIndex = 3;
            this.organizationNameLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "КПП";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ИНН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // organizationMainListBox
            // 
            this.organizationMainListBox.FormattingEnabled = true;
            this.organizationMainListBox.ItemHeight = 16;
            this.organizationMainListBox.Location = new System.Drawing.Point(15, 15);
            this.organizationMainListBox.Name = "organizationMainListBox";
            this.organizationMainListBox.Size = new System.Drawing.Size(342, 548);
            this.organizationMainListBox.TabIndex = 5;
            this.organizationMainListBox.SelectedIndexChanged += new System.EventHandler(this.OrganizationMainListBoxSelectedIndexChanged);
            // 
            // BanksPage
            // 
            this.BanksPage.Controls.Add(this.dBVersionLabel);
            this.BanksPage.Controls.Add(this.label5);
            this.BanksPage.Controls.Add(this.banksDataGridView);
            this.BanksPage.Controls.Add(this.uploadDbButton);
            this.BanksPage.Location = new System.Drawing.Point(4, 25);
            this.BanksPage.Name = "BanksPage";
            this.BanksPage.Padding = new System.Windows.Forms.Padding(3);
            this.BanksPage.Size = new System.Drawing.Size(1166, 699);
            this.BanksPage.TabIndex = 2;
            this.BanksPage.Text = "Список банков";
            this.BanksPage.UseVisualStyleBackColor = true;
            // 
            // dBVersionLabel
            // 
            this.dBVersionLabel.AutoSize = true;
            this.dBVersionLabel.Location = new System.Drawing.Point(1109, 35);
            this.dBVersionLabel.Name = "dBVersionLabel";
            this.dBVersionLabel.Size = new System.Drawing.Size(46, 17);
            this.dBVersionLabel.TabIndex = 5;
            this.dBVersionLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1010, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Версия базы";
            // 
            // banksDataGridView
            // 
            this.banksDataGridView.AllowUserToAddRows = false;
            this.banksDataGridView.AllowUserToDeleteRows = false;
            this.banksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banksDataGridView.Location = new System.Drawing.Point(8, 8);
            this.banksDataGridView.Name = "banksDataGridView";
            this.banksDataGridView.ReadOnly = true;
            this.banksDataGridView.RowTemplate.Height = 24;
            this.banksDataGridView.Size = new System.Drawing.Size(996, 150);
            this.banksDataGridView.TabIndex = 3;
            // 
            // bankInfoApiDBModelBindingSource
            // 
            this.bankInfoApiDBModelBindingSource.DataSource = typeof(WordInteractionLab8.Models.BankInfoApiDBModel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1067, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Версия базы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1171, 726);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Payment creator";
            this.tabControl1.ResumeLayout(false);
            this.PaymentsPage.ResumeLayout(false);
            this.OrganizationsPage.ResumeLayout(false);
            this.OrganizationsPage.PerformLayout();
            this.bankAccInfoPanel.ResumeLayout(false);
            this.bankAccInfoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.organizationInfoPanel.ResumeLayout(false);
            this.organizationInfoPanel.PerformLayout();
            this.BanksPage.ResumeLayout(false);
            this.BanksPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoApiDBModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button IntoDocumentButton;
        private System.Windows.Forms.Button uploadDbButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PaymentsPage;
        private System.Windows.Forms.TabPage OrganizationsPage;
        private System.Windows.Forms.TabPage BanksPage;
        private System.Windows.Forms.Button deletePaymentButton;
        private System.Windows.Forms.Button editPaymentButton;
        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.DataGridView banksDataGridView;
        private System.Windows.Forms.Panel organizationInfoPanel;
        private System.Windows.Forms.ListBox organizationMainListBox;
        private System.Windows.Forms.ListBox PaymentsListBox;
        private System.Windows.Forms.Panel bankAccInfoPanel;
        private System.Windows.Forms.ListBox bankAccountsListBox;
        private System.Windows.Forms.Label cppOrganizationLabel;
        private System.Windows.Forms.Label innOrganizationLabel;
        private System.Windows.Forms.Label organizationNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentAccountlLabel;
        private System.Windows.Forms.Label bikLabel;
        private System.Windows.Forms.Label bankLocationLabel;
        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bankInfoApiDBModelBindingSource;
        private System.Windows.Forms.Button PrintOneButton;
        private System.Windows.Forms.Button PrintAllButton;
        private System.Windows.Forms.Button deleteOrganizationButton;
        private System.Windows.Forms.Button editOrganizationButton;
        private System.Windows.Forms.Button addOrganizationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dBVersionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

