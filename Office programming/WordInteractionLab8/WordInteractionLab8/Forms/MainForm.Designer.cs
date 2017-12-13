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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IntoDocumentButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PaymentsPage = new System.Windows.Forms.TabPage();
            this.previewPaymentPanel = new System.Windows.Forms.Panel();
            this.payAnountWordsLabel = new System.Windows.Forms.Label();
            this.payTypeLabel = new System.Windows.Forms.Label();
            this.payQueueLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.payDescriptionLabel = new System.Windows.Forms.Label();
            this.payeeNameLabel = new System.Windows.Forms.Label();
            this.payeeBankAccLabel = new System.Windows.Forms.Label();
            this.payeeBankBicLabel = new System.Windows.Forms.Label();
            this.payeeKppLabel = new System.Windows.Forms.Label();
            this.payeeInnLabel = new System.Windows.Forms.Label();
            this.payeeBankNameLabel = new System.Windows.Forms.Label();
            this.payerBankAccLabel = new System.Windows.Forms.Label();
            this.payerBankBicLabel = new System.Windows.Forms.Label();
            this.payerCurrAccLabel = new System.Windows.Forms.Label();
            this.payerBankNameLabel = new System.Windows.Forms.Label();
            this.payerNameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.payerKppLabel = new System.Windows.Forms.Label();
            this.payerInnLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.PaymentNumberLabel = new System.Windows.Forms.Label();
            this.PrintOneButton = new System.Windows.Forms.Button();
            this.PrintAllButton = new System.Windows.Forms.Button();
            this.PaymentsListBox = new System.Windows.Forms.ListBox();
            this.deletePaymentButton = new System.Windows.Forms.Button();
            this.editPaymentButton = new System.Windows.Forms.Button();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.OrganizationsPage = new System.Windows.Forms.TabPage();
            this.UploadDbPanel = new System.Windows.Forms.Panel();
            this.GetActualVersionButton = new System.Windows.Forms.Button();
            this.bankDbActualVersionLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bankDbCurrentVersionLabel = new System.Windows.Forms.Label();
            this.UploadBankDbButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dbDownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.dbDownloadStateMessage = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PaymentsPage.SuspendLayout();
            this.previewPaymentPanel.SuspendLayout();
            this.OrganizationsPage.SuspendLayout();
            this.UploadDbPanel.SuspendLayout();
            this.bankAccInfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.organizationInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntoDocumentButton
            // 
            this.IntoDocumentButton.Location = new System.Drawing.Point(17, 643);
            this.IntoDocumentButton.Name = "IntoDocumentButton";
            this.IntoDocumentButton.Size = new System.Drawing.Size(106, 28);
            this.IntoDocumentButton.TabIndex = 1;
            this.IntoDocumentButton.Text = "В документ";
            this.IntoDocumentButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PaymentsPage);
            this.tabControl1.Controls.Add(this.OrganizationsPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 752);
            this.tabControl1.TabIndex = 5;
            // 
            // PaymentsPage
            // 
            this.PaymentsPage.Controls.Add(this.previewPaymentPanel);
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
            this.PaymentsPage.Size = new System.Drawing.Size(1166, 723);
            this.PaymentsPage.TabIndex = 0;
            this.PaymentsPage.Text = "Платежные поручения";
            this.PaymentsPage.UseVisualStyleBackColor = true;
            // 
            // previewPaymentPanel
            // 
            this.previewPaymentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPaymentPanel.BackgroundImage")));
            this.previewPaymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPaymentPanel.Controls.Add(this.payAnountWordsLabel);
            this.previewPaymentPanel.Controls.Add(this.payTypeLabel);
            this.previewPaymentPanel.Controls.Add(this.payQueueLabel);
            this.previewPaymentPanel.Controls.Add(this.label28);
            this.previewPaymentPanel.Controls.Add(this.payDescriptionLabel);
            this.previewPaymentPanel.Controls.Add(this.payeeNameLabel);
            this.previewPaymentPanel.Controls.Add(this.payeeBankAccLabel);
            this.previewPaymentPanel.Controls.Add(this.payeeBankBicLabel);
            this.previewPaymentPanel.Controls.Add(this.payeeKppLabel);
            this.previewPaymentPanel.Controls.Add(this.payeeInnLabel);
            this.previewPaymentPanel.Controls.Add(this.payeeBankNameLabel);
            this.previewPaymentPanel.Controls.Add(this.payerBankAccLabel);
            this.previewPaymentPanel.Controls.Add(this.payerBankBicLabel);
            this.previewPaymentPanel.Controls.Add(this.payerCurrAccLabel);
            this.previewPaymentPanel.Controls.Add(this.payerBankNameLabel);
            this.previewPaymentPanel.Controls.Add(this.payerNameLabel);
            this.previewPaymentPanel.Controls.Add(this.amountLabel);
            this.previewPaymentPanel.Controls.Add(this.payerKppLabel);
            this.previewPaymentPanel.Controls.Add(this.payerInnLabel);
            this.previewPaymentPanel.Controls.Add(this.DataLabel);
            this.previewPaymentPanel.Controls.Add(this.PaymentNumberLabel);
            this.previewPaymentPanel.Location = new System.Drawing.Point(450, 15);
            this.previewPaymentPanel.Name = "previewPaymentPanel";
            this.previewPaymentPanel.Size = new System.Drawing.Size(640, 659);
            this.previewPaymentPanel.TabIndex = 10;
            this.previewPaymentPanel.Visible = false;
            // 
            // payAnountWordsLabel
            // 
            this.payAnountWordsLabel.AutoSize = true;
            this.payAnountWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payAnountWordsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payAnountWordsLabel.Location = new System.Drawing.Point(98, 147);
            this.payAnountWordsLabel.Name = "payAnountWordsLabel";
            this.payAnountWordsLabel.Size = new System.Drawing.Size(55, 15);
            this.payAnountWordsLabel.TabIndex = 31;
            this.payAnountWordsLabel.Text = "label12";
            // 
            // payTypeLabel
            // 
            this.payTypeLabel.AutoSize = true;
            this.payTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payTypeLabel.Location = new System.Drawing.Point(407, 92);
            this.payTypeLabel.Name = "payTypeLabel";
            this.payTypeLabel.Size = new System.Drawing.Size(55, 15);
            this.payTypeLabel.TabIndex = 30;
            this.payTypeLabel.Text = "label12";
            // 
            // payQueueLabel
            // 
            this.payQueueLabel.AutoSize = true;
            this.payQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payQueueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payQueueLabel.Location = new System.Drawing.Point(549, 483);
            this.payQueueLabel.Name = "payQueueLabel";
            this.payQueueLabel.Size = new System.Drawing.Size(55, 15);
            this.payQueueLabel.TabIndex = 29;
            this.payQueueLabel.Text = "label29";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(397, 458);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 15);
            this.label28.TabIndex = 28;
            this.label28.Text = "01";
            // 
            // payDescriptionLabel
            // 
            this.payDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payDescriptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payDescriptionLabel.Location = new System.Drawing.Point(16, 570);
            this.payDescriptionLabel.Name = "payDescriptionLabel";
            this.payDescriptionLabel.Size = new System.Drawing.Size(599, 21);
            this.payDescriptionLabel.TabIndex = 27;
            this.payDescriptionLabel.Text = "label27";
            // 
            // payeeNameLabel
            // 
            this.payeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payeeNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payeeNameLabel.Location = new System.Drawing.Point(16, 447);
            this.payeeNameLabel.Name = "payeeNameLabel";
            this.payeeNameLabel.Size = new System.Drawing.Size(297, 53);
            this.payeeNameLabel.TabIndex = 26;
            this.payeeNameLabel.Text = "label26";
            // 
            // payeeBankAccLabel
            // 
            this.payeeBankAccLabel.AutoSize = true;
            this.payeeBankAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payeeBankAccLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payeeBankAccLabel.Location = new System.Drawing.Point(397, 382);
            this.payeeBankAccLabel.Name = "payeeBankAccLabel";
            this.payeeBankAccLabel.Size = new System.Drawing.Size(55, 15);
            this.payeeBankAccLabel.TabIndex = 25;
            this.payeeBankAccLabel.Text = "label25";
            // 
            // payeeBankBicLabel
            // 
            this.payeeBankBicLabel.AutoSize = true;
            this.payeeBankBicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payeeBankBicLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payeeBankBicLabel.Location = new System.Drawing.Point(397, 344);
            this.payeeBankBicLabel.Name = "payeeBankBicLabel";
            this.payeeBankBicLabel.Size = new System.Drawing.Size(55, 15);
            this.payeeBankBicLabel.TabIndex = 24;
            this.payeeBankBicLabel.Text = "label24";
            // 
            // payeeKppLabel
            // 
            this.payeeKppLabel.AutoSize = true;
            this.payeeKppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payeeKppLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payeeKppLabel.Location = new System.Drawing.Point(190, 413);
            this.payeeKppLabel.Name = "payeeKppLabel";
            this.payeeKppLabel.Size = new System.Drawing.Size(55, 15);
            this.payeeKppLabel.TabIndex = 23;
            this.payeeKppLabel.Text = "label23";
            // 
            // payeeInnLabel
            // 
            this.payeeInnLabel.AutoSize = true;
            this.payeeInnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payeeInnLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payeeInnLabel.Location = new System.Drawing.Point(51, 413);
            this.payeeInnLabel.Name = "payeeInnLabel";
            this.payeeInnLabel.Size = new System.Drawing.Size(55, 15);
            this.payeeInnLabel.TabIndex = 22;
            this.payeeInnLabel.Text = "label22";
            // 
            // payeeBankNameLabel
            // 
            this.payeeBankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payeeBankNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payeeBankNameLabel.Location = new System.Drawing.Point(16, 344);
            this.payeeBankNameLabel.Name = "payeeBankNameLabel";
            this.payeeBankNameLabel.Size = new System.Drawing.Size(297, 41);
            this.payeeBankNameLabel.TabIndex = 21;
            this.payeeBankNameLabel.Text = "label21";
            // 
            // payerBankAccLabel
            // 
            this.payerBankAccLabel.AutoSize = true;
            this.payerBankAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerBankAccLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerBankAccLabel.Location = new System.Drawing.Point(397, 306);
            this.payerBankAccLabel.Name = "payerBankAccLabel";
            this.payerBankAccLabel.Size = new System.Drawing.Size(55, 15);
            this.payerBankAccLabel.TabIndex = 20;
            this.payerBankAccLabel.Text = "label20";
            // 
            // payerBankBicLabel
            // 
            this.payerBankBicLabel.AutoSize = true;
            this.payerBankBicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerBankBicLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerBankBicLabel.Location = new System.Drawing.Point(397, 276);
            this.payerBankBicLabel.Name = "payerBankBicLabel";
            this.payerBankBicLabel.Size = new System.Drawing.Size(55, 15);
            this.payerBankBicLabel.TabIndex = 19;
            this.payerBankBicLabel.Text = "label19";
            // 
            // payerCurrAccLabel
            // 
            this.payerCurrAccLabel.AutoSize = true;
            this.payerCurrAccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerCurrAccLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerCurrAccLabel.Location = new System.Drawing.Point(397, 236);
            this.payerCurrAccLabel.Name = "payerCurrAccLabel";
            this.payerCurrAccLabel.Size = new System.Drawing.Size(55, 15);
            this.payerCurrAccLabel.TabIndex = 18;
            this.payerCurrAccLabel.Text = "label18";
            // 
            // payerBankNameLabel
            // 
            this.payerBankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerBankNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerBankNameLabel.Location = new System.Drawing.Point(16, 276);
            this.payerBankNameLabel.Name = "payerBankNameLabel";
            this.payerBankNameLabel.Size = new System.Drawing.Size(297, 36);
            this.payerBankNameLabel.TabIndex = 17;
            this.payerBankNameLabel.Text = "label17";
            // 
            // payerNameLabel
            // 
            this.payerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerNameLabel.Location = new System.Drawing.Point(16, 219);
            this.payerNameLabel.Name = "payerNameLabel";
            this.payerNameLabel.Size = new System.Drawing.Size(297, 34);
            this.payerNameLabel.TabIndex = 16;
            this.payerNameLabel.Text = "label16";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amountLabel.Location = new System.Drawing.Point(397, 189);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(55, 15);
            this.amountLabel.TabIndex = 15;
            this.amountLabel.Text = "label15";
            // 
            // payerKppLabel
            // 
            this.payerKppLabel.AutoSize = true;
            this.payerKppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerKppLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerKppLabel.Location = new System.Drawing.Point(190, 189);
            this.payerKppLabel.Name = "payerKppLabel";
            this.payerKppLabel.Size = new System.Drawing.Size(55, 15);
            this.payerKppLabel.TabIndex = 14;
            this.payerKppLabel.Text = "label14";
            // 
            // payerInnLabel
            // 
            this.payerInnLabel.AutoSize = true;
            this.payerInnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerInnLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payerInnLabel.Location = new System.Drawing.Point(51, 189);
            this.payerInnLabel.Name = "payerInnLabel";
            this.payerInnLabel.Size = new System.Drawing.Size(55, 15);
            this.payerInnLabel.TabIndex = 13;
            this.payerInnLabel.Text = "label13";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataLabel.Location = new System.Drawing.Point(288, 92);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(55, 15);
            this.DataLabel.TabIndex = 12;
            this.DataLabel.Text = "label12";
            // 
            // PaymentNumberLabel
            // 
            this.PaymentNumberLabel.AutoSize = true;
            this.PaymentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaymentNumberLabel.Location = new System.Drawing.Point(190, 92);
            this.PaymentNumberLabel.Name = "PaymentNumberLabel";
            this.PaymentNumberLabel.Size = new System.Drawing.Size(39, 15);
            this.PaymentNumberLabel.TabIndex = 11;
            this.PaymentNumberLabel.Text = "label";
            // 
            // PrintOneButton
            // 
            this.PrintOneButton.Enabled = false;
            this.PrintOneButton.Location = new System.Drawing.Point(129, 643);
            this.PrintOneButton.Name = "PrintOneButton";
            this.PrintOneButton.Size = new System.Drawing.Size(117, 28);
            this.PrintOneButton.TabIndex = 9;
            this.PrintOneButton.Text = "Печать";
            this.PrintOneButton.UseVisualStyleBackColor = true;
            // 
            // PrintAllButton
            // 
            this.PrintAllButton.Enabled = false;
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
            this.PaymentsListBox.SelectedIndexChanged += new System.EventHandler(this.PaymentsListBoxSelectedIndexChanged);
            // 
            // deletePaymentButton
            // 
            this.deletePaymentButton.Location = new System.Drawing.Point(252, 609);
            this.deletePaymentButton.Name = "deletePaymentButton";
            this.deletePaymentButton.Size = new System.Drawing.Size(105, 28);
            this.deletePaymentButton.TabIndex = 5;
            this.deletePaymentButton.Text = "Удалить";
            this.deletePaymentButton.UseVisualStyleBackColor = true;
            this.deletePaymentButton.Click += new System.EventHandler(this.DeletePaymentButtonClick);
            // 
            // editPaymentButton
            // 
            this.editPaymentButton.Location = new System.Drawing.Point(129, 609);
            this.editPaymentButton.Name = "editPaymentButton";
            this.editPaymentButton.Size = new System.Drawing.Size(117, 28);
            this.editPaymentButton.TabIndex = 4;
            this.editPaymentButton.Text = "Редактировать";
            this.editPaymentButton.UseVisualStyleBackColor = true;
            this.editPaymentButton.Click += new System.EventHandler(this.EditPaymentButtonClick);
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
            this.OrganizationsPage.Controls.Add(this.UploadDbPanel);
            this.OrganizationsPage.Controls.Add(this.deleteOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.editOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.addOrganizationButton);
            this.OrganizationsPage.Controls.Add(this.bankAccInfoPanel);
            this.OrganizationsPage.Controls.Add(this.organizationInfoPanel);
            this.OrganizationsPage.Controls.Add(this.organizationMainListBox);
            this.OrganizationsPage.Location = new System.Drawing.Point(4, 25);
            this.OrganizationsPage.Name = "OrganizationsPage";
            this.OrganizationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrganizationsPage.Size = new System.Drawing.Size(1166, 723);
            this.OrganizationsPage.TabIndex = 1;
            this.OrganizationsPage.Text = "Организации";
            this.OrganizationsPage.UseVisualStyleBackColor = true;
            // 
            // UploadDbPanel
            // 
            this.UploadDbPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploadDbPanel.Controls.Add(this.dbDownloadStateMessage);
            this.UploadDbPanel.Controls.Add(this.dbDownloadProgressBar);
            this.UploadDbPanel.Controls.Add(this.GetActualVersionButton);
            this.UploadDbPanel.Controls.Add(this.bankDbActualVersionLabel);
            this.UploadDbPanel.Controls.Add(this.label12);
            this.UploadDbPanel.Controls.Add(this.bankDbCurrentVersionLabel);
            this.UploadDbPanel.Controls.Add(this.UploadBankDbButton);
            this.UploadDbPanel.Controls.Add(this.label8);
            this.UploadDbPanel.Location = new System.Drawing.Point(705, 582);
            this.UploadDbPanel.Name = "UploadDbPanel";
            this.UploadDbPanel.Size = new System.Drawing.Size(450, 138);
            this.UploadDbPanel.TabIndex = 14;
            // 
            // GetActualVersionButton
            // 
            this.GetActualVersionButton.Location = new System.Drawing.Point(3, 102);
            this.GetActualVersionButton.Name = "GetActualVersionButton";
            this.GetActualVersionButton.Size = new System.Drawing.Size(232, 28);
            this.GetActualVersionButton.TabIndex = 16;
            this.GetActualVersionButton.Text = "Проверить актуальную версию";
            this.GetActualVersionButton.UseVisualStyleBackColor = true;
            this.GetActualVersionButton.Click += new System.EventHandler(this.GetActualVersionButtonClick);
            // 
            // bankDbActualVersionLabel
            // 
            this.bankDbActualVersionLabel.AutoSize = true;
            this.bankDbActualVersionLabel.Location = new System.Drawing.Point(173, 35);
            this.bankDbActualVersionLabel.Name = "bankDbActualVersionLabel";
            this.bankDbActualVersionLabel.Size = new System.Drawing.Size(113, 17);
            this.bankDbActualVersionLabel.TabIndex = 15;
            this.bankDbActualVersionLabel.Text = "не проверялась";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Актуальная версия";
            // 
            // bankDbCurrentVersionLabel
            // 
            this.bankDbCurrentVersionLabel.AutoSize = true;
            this.bankDbCurrentVersionLabel.Location = new System.Drawing.Point(173, 8);
            this.bankDbCurrentVersionLabel.Name = "bankDbCurrentVersionLabel";
            this.bankDbCurrentVersionLabel.Size = new System.Drawing.Size(46, 17);
            this.bankDbCurrentVersionLabel.TabIndex = 13;
            this.bankDbCurrentVersionLabel.Text = "label6";
            // 
            // UploadBankDbButton
            // 
            this.UploadBankDbButton.Location = new System.Drawing.Point(241, 102);
            this.UploadBankDbButton.Name = "UploadBankDbButton";
            this.UploadBankDbButton.Size = new System.Drawing.Size(203, 28);
            this.UploadBankDbButton.TabIndex = 11;
            this.UploadBankDbButton.Text = "Обновить базу банков";
            this.UploadBankDbButton.UseVisualStyleBackColor = true;
            this.UploadBankDbButton.Click += new System.EventHandler(this.UploadBankDbButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Текущая версия базы";
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
            // dbDownloadProgressBar
            // 
            this.dbDownloadProgressBar.Location = new System.Drawing.Point(3, 70);
            this.dbDownloadProgressBar.Name = "dbDownloadProgressBar";
            this.dbDownloadProgressBar.Size = new System.Drawing.Size(283, 10);
            this.dbDownloadProgressBar.TabIndex = 17;
            this.dbDownloadProgressBar.Visible = false;
            // 
            // dbDownloadStateMessage
            // 
            this.dbDownloadStateMessage.Location = new System.Drawing.Point(292, 63);
            this.dbDownloadStateMessage.Name = "dbDownloadStateMessage";
            this.dbDownloadStateMessage.Size = new System.Drawing.Size(152, 36);
            this.dbDownloadStateMessage.TabIndex = 18;
            this.dbDownloadStateMessage.Text = "label5";
            this.dbDownloadStateMessage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1171, 754);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Payment creator";
            this.tabControl1.ResumeLayout(false);
            this.PaymentsPage.ResumeLayout(false);
            this.previewPaymentPanel.ResumeLayout(false);
            this.previewPaymentPanel.PerformLayout();
            this.OrganizationsPage.ResumeLayout(false);
            this.UploadDbPanel.ResumeLayout(false);
            this.UploadDbPanel.PerformLayout();
            this.bankAccInfoPanel.ResumeLayout(false);
            this.bankAccInfoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.organizationInfoPanel.ResumeLayout(false);
            this.organizationInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button IntoDocumentButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PaymentsPage;
        private System.Windows.Forms.TabPage OrganizationsPage;
        private System.Windows.Forms.Button deletePaymentButton;
        private System.Windows.Forms.Button editPaymentButton;
        private System.Windows.Forms.Button addPaymentButton;
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
        private System.Windows.Forms.Button PrintOneButton;
        private System.Windows.Forms.Button PrintAllButton;
        private System.Windows.Forms.Button deleteOrganizationButton;
        private System.Windows.Forms.Button editOrganizationButton;
        private System.Windows.Forms.Button addOrganizationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UploadBankDbButton;
        private System.Windows.Forms.Panel previewPaymentPanel;
        private System.Windows.Forms.Label bankDbCurrentVersionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label payQueueLabel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label payDescriptionLabel;
        private System.Windows.Forms.Label payeeNameLabel;
        private System.Windows.Forms.Label payeeBankAccLabel;
        private System.Windows.Forms.Label payeeBankBicLabel;
        private System.Windows.Forms.Label payeeKppLabel;
        private System.Windows.Forms.Label payeeInnLabel;
        private System.Windows.Forms.Label payeeBankNameLabel;
        private System.Windows.Forms.Label payerBankAccLabel;
        private System.Windows.Forms.Label payerBankBicLabel;
        private System.Windows.Forms.Label payerCurrAccLabel;
        private System.Windows.Forms.Label payerBankNameLabel;
        private System.Windows.Forms.Label payerNameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label payerKppLabel;
        private System.Windows.Forms.Label payerInnLabel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label PaymentNumberLabel;
        private System.Windows.Forms.Label payTypeLabel;
        private System.Windows.Forms.Label payAnountWordsLabel;
        private System.Windows.Forms.Panel UploadDbPanel;
        private System.Windows.Forms.Label bankDbActualVersionLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button GetActualVersionButton;
        private System.Windows.Forms.ProgressBar dbDownloadProgressBar;
        private System.Windows.Forms.Label dbDownloadStateMessage;
    }
}

