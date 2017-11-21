namespace WordInterLab2
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
            this.runWordBtn = new System.Windows.Forms.Button();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.wordVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveDocsBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Task1 = new System.Windows.Forms.TabPage();
            this.Task2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.docCountLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Task1.SuspendLayout();
            this.Task2.SuspendLayout();
            this.SuspendLayout();
            // 
            // runWordBtn
            // 
            this.runWordBtn.Location = new System.Drawing.Point(447, 48);
            this.runWordBtn.Name = "runWordBtn";
            this.runWordBtn.Size = new System.Drawing.Size(102, 26);
            this.runWordBtn.TabIndex = 0;
            this.runWordBtn.Text = "Run Word";
            this.runWordBtn.UseVisualStyleBackColor = true;
            this.runWordBtn.Click += new System.EventHandler(this.runWordBtn_Click);
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(28, 30);
            this.FIOTextBox.Multiline = true;
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(157, 211);
            this.FIOTextBox.TabIndex = 1;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(46, 247);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(102, 26);
            this.insertBtn.TabIndex = 2;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // wordVisibleCheckBox
            // 
            this.wordVisibleCheckBox.AutoSize = true;
            this.wordVisibleCheckBox.Location = new System.Drawing.Point(468, 80);
            this.wordVisibleCheckBox.Name = "wordVisibleCheckBox";
            this.wordVisibleCheckBox.Size = new System.Drawing.Size(56, 17);
            this.wordVisibleCheckBox.TabIndex = 3;
            this.wordVisibleCheckBox.Text = "Visible";
            this.wordVisibleCheckBox.UseVisualStyleBackColor = true;
            this.wordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.wordVisibleCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Content for insert";
            // 
            // saveDocsBtn
            // 
            this.saveDocsBtn.Location = new System.Drawing.Point(449, 228);
            this.saveDocsBtn.Name = "saveDocsBtn";
            this.saveDocsBtn.Size = new System.Drawing.Size(100, 26);
            this.saveDocsBtn.TabIndex = 9;
            this.saveDocsBtn.Text = "Save Docs";
            this.saveDocsBtn.UseVisualStyleBackColor = true;
            this.saveDocsBtn.Click += new System.EventHandler(this.saveDocsBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Task1);
            this.tabControl1.Controls.Add(this.Task2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 321);
            this.tabControl1.TabIndex = 10;
            // 
            // Task1
            // 
            this.Task1.Controls.Add(this.label2);
            this.Task1.Controls.Add(this.FIOTextBox);
            this.Task1.Controls.Add(this.insertBtn);
            this.Task1.Location = new System.Drawing.Point(4, 22);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(373, 295);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task1";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.Task2.Controls.Add(this.label4);
            this.Task2.Controls.Add(this.label3);
            this.Task2.Controls.Add(this.replaceTextBox);
            this.Task2.Controls.Add(this.findTextBox);
            this.Task2.Controls.Add(this.replaceBtn);
            this.Task2.Location = new System.Drawing.Point(4, 22);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(373, 295);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "replace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "search String";
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(158, 46);
            this.replaceTextBox.Multiline = true;
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(114, 174);
            this.replaceTextBox.TabIndex = 2;
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(28, 46);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(100, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(181, 242);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(75, 23);
            this.replaceBtn.TabIndex = 0;
            this.replaceBtn.Text = "Replace";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Documents Count";
            // 
            // docCountLabel
            // 
            this.docCountLabel.AutoSize = true;
            this.docCountLabel.Location = new System.Drawing.Point(549, 195);
            this.docCountLabel.Name = "docCountLabel";
            this.docCountLabel.Size = new System.Drawing.Size(0, 13);
            this.docCountLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 356);
            this.Controls.Add(this.docCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveDocsBtn);
            this.Controls.Add(this.wordVisibleCheckBox);
            this.Controls.Add(this.runWordBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.Task1.PerformLayout();
            this.Task2.ResumeLayout(false);
            this.Task2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runWordBtn;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox wordVisibleCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveDocsBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Task1;
        private System.Windows.Forms.TabPage Task2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label docCountLabel;
    }
}

