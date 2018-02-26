namespace WindowsFormsControlLibrary
{
    using System;
    using System.Windows.Forms;

    partial class MathGraphGrid
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MathGraphGrid
            // 
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.Click += this.ThisClick;
            this.MouseDown += this.ThisMouseDown;
            this.MouseUp += this.ThisMouseUp;
            this.MouseMove += this.ThisMouseMove;
            this.MouseWheel += this.ThisMouseWhell;
            this.SizeChanged += this.OnSizeChanged;
        }

        #endregion
    }
}
