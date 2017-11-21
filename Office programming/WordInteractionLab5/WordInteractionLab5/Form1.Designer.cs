namespace WordInteractionLab5
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.runWordBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.newDocBtn = new System.Windows.Forms.Button();
            this.toDocBtn = new System.Windows.Forms.Button();
            this.visibleWordCheckBox = new System.Windows.Forms.CheckBox();
            this.generateDataBtn = new System.Windows.Forms.Button();
            this.simpleRadioButton = new System.Windows.Forms.RadioButton();
            this.tableRadioButton = new System.Windows.Forms.RadioButton();
            this.templateRadioButton = new System.Windows.Forms.RadioButton();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runWordBtn
            // 
            this.runWordBtn.Location = new System.Drawing.Point(492, 22);
            this.runWordBtn.Name = "runWordBtn";
            this.runWordBtn.Size = new System.Drawing.Size(75, 23);
            this.runWordBtn.TabIndex = 0;
            this.runWordBtn.Text = "Run Word";
            this.runWordBtn.UseVisualStyleBackColor = true;
            this.runWordBtn.Click += new System.EventHandler(this.runWordBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.userBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(443, 204);
            this.dataGridView.TabIndex = 5;
            // 
            // newDocBtn
            // 
            this.newDocBtn.Location = new System.Drawing.Point(342, 251);
            this.newDocBtn.Name = "newDocBtn";
            this.newDocBtn.Size = new System.Drawing.Size(105, 23);
            this.newDocBtn.TabIndex = 3;
            this.newDocBtn.Text = "new Document";
            this.newDocBtn.UseVisualStyleBackColor = true;
            this.newDocBtn.Click += new System.EventHandler(this.newDocBtn_Click);
            // 
            // toDocBtn
            // 
            this.toDocBtn.Location = new System.Drawing.Point(342, 291);
            this.toDocBtn.Name = "toDocBtn";
            this.toDocBtn.Size = new System.Drawing.Size(105, 23);
            this.toDocBtn.TabIndex = 4;
            this.toDocBtn.Text = "to Document";
            this.toDocBtn.UseVisualStyleBackColor = true;
            this.toDocBtn.Click += new System.EventHandler(this.toDocBtn_Click);
            // 
            // visibleWordCheckBox
            // 
            this.visibleWordCheckBox.AutoSize = true;
            this.visibleWordCheckBox.Location = new System.Drawing.Point(492, 73);
            this.visibleWordCheckBox.Name = "visibleWordCheckBox";
            this.visibleWordCheckBox.Size = new System.Drawing.Size(55, 17);
            this.visibleWordCheckBox.TabIndex = 2;
            this.visibleWordCheckBox.Text = "visible";
            this.visibleWordCheckBox.UseVisualStyleBackColor = true;
            this.visibleWordCheckBox.CheckedChanged += new System.EventHandler(this.visibleWordCheckBox_CheckedChanged);
            // 
            // generateDataBtn
            // 
            this.generateDataBtn.Location = new System.Drawing.Point(492, 156);
            this.generateDataBtn.Name = "generateDataBtn";
            this.generateDataBtn.Size = new System.Drawing.Size(87, 27);
            this.generateDataBtn.TabIndex = 3;
            this.generateDataBtn.Text = "Generate Data";
            this.generateDataBtn.UseVisualStyleBackColor = true;
            this.generateDataBtn.Click += new System.EventHandler(this.generateDataBtn_Click);
            // 
            // simpleRadioButton
            // 
            this.simpleRadioButton.AutoSize = true;
            this.simpleRadioButton.Location = new System.Drawing.Point(73, 251);
            this.simpleRadioButton.Name = "simpleRadioButton";
            this.simpleRadioButton.Size = new System.Drawing.Size(56, 17);
            this.simpleRadioButton.TabIndex = 6;
            this.simpleRadioButton.TabStop = true;
            this.simpleRadioButton.Text = "Simple";
            this.simpleRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableRadioButton
            // 
            this.tableRadioButton.AutoSize = true;
            this.tableRadioButton.Location = new System.Drawing.Point(73, 274);
            this.tableRadioButton.Name = "tableRadioButton";
            this.tableRadioButton.Size = new System.Drawing.Size(78, 17);
            this.tableRadioButton.TabIndex = 7;
            this.tableRadioButton.TabStop = true;
            this.tableRadioButton.Text = "Table Form";
            this.tableRadioButton.UseVisualStyleBackColor = true;
            // 
            // templateRadioButton
            // 
            this.templateRadioButton.AutoSize = true;
            this.templateRadioButton.Location = new System.Drawing.Point(73, 297);
            this.templateRadioButton.Name = "templateRadioButton";
            this.templateRadioButton.Size = new System.Drawing.Size(69, 17);
            this.templateRadioButton.TabIndex = 8;
            this.templateRadioButton.TabStop = true;
            this.templateRadioButton.Text = "Template";
            this.templateRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(WordInteractionLab5.User);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 375);
            this.Controls.Add(this.templateRadioButton);
            this.Controls.Add(this.tableRadioButton);
            this.Controls.Add(this.simpleRadioButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.newDocBtn);
            this.Controls.Add(this.generateDataBtn);
            this.Controls.Add(this.toDocBtn);
            this.Controls.Add(this.visibleWordCheckBox);
            this.Controls.Add(this.runWordBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runWordBtn;
        private System.Windows.Forms.Button newDocBtn;
        private System.Windows.Forms.Button toDocBtn;
        private System.Windows.Forms.CheckBox visibleWordCheckBox;
        private System.Windows.Forms.Button generateDataBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.RadioButton simpleRadioButton;
        private System.Windows.Forms.RadioButton tableRadioButton;
        private System.Windows.Forms.RadioButton templateRadioButton;
    }
}

