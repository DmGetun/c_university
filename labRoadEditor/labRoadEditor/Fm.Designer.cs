namespace labRoadEditor
{
    partial class Fm
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
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewField = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFill = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSM
            // 
            this.TSM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMSave,
            this.TSMDownload,
            this.TSMNewField,
            this.TSMFill,
            this.TSMClear});
            this.TSM.Location = new System.Drawing.Point(0, 0);
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(800, 24);
            this.TSM.TabIndex = 0;
            this.TSM.Text = "menuStrip1";
            // 
            // TSMSave
            // 
            this.TSMSave.Name = "TSMSave";
            this.TSMSave.Size = new System.Drawing.Size(77, 20);
            this.TSMSave.Text = "Сохранить";
            // 
            // TSMDownload
            // 
            this.TSMDownload.Name = "TSMDownload";
            this.TSMDownload.Size = new System.Drawing.Size(73, 20);
            this.TSMDownload.Text = "Загрузить";
            // 
            // TSMNewField
            // 
            this.TSMNewField.Name = "TSMNewField";
            this.TSMNewField.Size = new System.Drawing.Size(84, 20);
            this.TSMNewField.Text = "Новое поле";
            // 
            // TSMFill
            // 
            this.TSMFill.Name = "TSMFill";
            this.TSMFill.Size = new System.Drawing.Size(148, 20);
            this.TSMFill.Text = "Залить поле картинкой";
            // 
            // TSMClear
            // 
            this.TSMClear.Name = "TSMClear";
            this.TSMClear.Size = new System.Drawing.Size(101, 20);
            this.TSMClear.Text = "Очистить поле";
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TSM);
            this.MainMenuStrip = this.TSM;
            this.Name = "Fm";
            this.Text = "labRoadEditor";
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TSM;
        private System.Windows.Forms.ToolStripMenuItem TSMSave;
        private System.Windows.Forms.ToolStripMenuItem TSMDownload;
        private System.Windows.Forms.ToolStripMenuItem TSMNewField;
        private System.Windows.Forms.ToolStripMenuItem TSMFill;
        private System.Windows.Forms.ToolStripMenuItem TSMClear;
    }
}

