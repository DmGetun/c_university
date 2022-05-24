namespace labFormDialogs
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
            this.openDialog = new System.Windows.Forms.TextBox();
            this.buOpenDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openDialog
            // 
            this.openDialog.Location = new System.Drawing.Point(33, 12);
            this.openDialog.Name = "openDialog";
            this.openDialog.Size = new System.Drawing.Size(416, 20);
            this.openDialog.TabIndex = 0;
            // 
            // buOpenDialog
            // 
            this.buOpenDialog.Location = new System.Drawing.Point(466, 10);
            this.buOpenDialog.Name = "buOpenDialog";
            this.buOpenDialog.Size = new System.Drawing.Size(185, 23);
            this.buOpenDialog.TabIndex = 1;
            this.buOpenDialog.Text = "openFileDialog";
            this.buOpenDialog.UseVisualStyleBackColor = true;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buOpenDialog);
            this.Controls.Add(this.openDialog);
            this.Name = "Fm";
            this.Text = "labFormDialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox openDialog;
        private System.Windows.Forms.Button buOpenDialog;
    }
}

