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
            this.runExelBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newBookBtn = new System.Windows.Forms.Button();
            this.toBookBtn = new System.Windows.Forms.Button();
            this.visibleWordCheckBox = new System.Windows.Forms.CheckBox();
            this.generateDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runExelBtn
            // 
            this.runExelBtn.Location = new System.Drawing.Point(656, 27);
            this.runExelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.runExelBtn.Name = "runExelBtn";
            this.runExelBtn.Size = new System.Drawing.Size(100, 28);
            this.runExelBtn.TabIndex = 0;
            this.runExelBtn.Text = "Run Exel";
            this.runExelBtn.UseVisualStyleBackColor = true;
            this.runExelBtn.Click += new System.EventHandler(this.RunExelBtnClick);
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
            this.dataGridView.Location = new System.Drawing.Point(16, 15);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(443, 251);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
            // newBookBtn
            // 
            this.newBookBtn.Location = new System.Drawing.Point(456, 309);
            this.newBookBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newBookBtn.Name = "newBookBtn";
            this.newBookBtn.Size = new System.Drawing.Size(140, 28);
            this.newBookBtn.TabIndex = 3;
            this.newBookBtn.Text = "new Book";
            this.newBookBtn.UseVisualStyleBackColor = true;
            this.newBookBtn.Click += new System.EventHandler(this.NewBookBtnClick);
            // 
            // toBookBtn
            // 
            this.toBookBtn.Location = new System.Drawing.Point(456, 358);
            this.toBookBtn.Margin = new System.Windows.Forms.Padding(4);
            this.toBookBtn.Name = "toBookBtn";
            this.toBookBtn.Size = new System.Drawing.Size(140, 28);
            this.toBookBtn.TabIndex = 4;
            this.toBookBtn.Text = "to Book";
            this.toBookBtn.UseVisualStyleBackColor = true;
            this.toBookBtn.Click += new System.EventHandler(this.ToBookBtnClick);
            // 
            // visibleWordCheckBox
            // 
            this.visibleWordCheckBox.AutoSize = true;
            this.visibleWordCheckBox.Location = new System.Drawing.Point(656, 90);
            this.visibleWordCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.visibleWordCheckBox.Name = "visibleWordCheckBox";
            this.visibleWordCheckBox.Size = new System.Drawing.Size(69, 21);
            this.visibleWordCheckBox.TabIndex = 2;
            this.visibleWordCheckBox.Text = "visible";
            this.visibleWordCheckBox.UseVisualStyleBackColor = true;
            this.visibleWordCheckBox.CheckedChanged += new System.EventHandler(this.VisibleWordCheckBoxCheckedChanged);
            // 
            // generateDataBtn
            // 
            this.generateDataBtn.Location = new System.Drawing.Point(656, 192);
            this.generateDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.generateDataBtn.Name = "generateDataBtn";
            this.generateDataBtn.Size = new System.Drawing.Size(116, 33);
            this.generateDataBtn.TabIndex = 3;
            this.generateDataBtn.Text = "Generate Data";
            this.generateDataBtn.UseVisualStyleBackColor = true;
            this.generateDataBtn.Click += new System.EventHandler(this.GenerateDataBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 462);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.newBookBtn);
            this.Controls.Add(this.generateDataBtn);
            this.Controls.Add(this.toBookBtn);
            this.Controls.Add(this.visibleWordCheckBox);
            this.Controls.Add(this.runExelBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runExelBtn;
        private System.Windows.Forms.Button newBookBtn;
        private System.Windows.Forms.Button toBookBtn;
        private System.Windows.Forms.CheckBox visibleWordCheckBox;
        private System.Windows.Forms.Button generateDataBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

