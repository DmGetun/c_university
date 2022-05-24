namespace labFileExplorerOnWB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buBack = new System.Windows.Forms.Button();
            this.buForward = new System.Windows.Forms.Button();
            this.buUp = new System.Windows.Forms.Button();
            this.edDir = new System.Windows.Forms.TextBox();
            this.buDirSelect = new System.Windows.Forms.Button();
            this.WB = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buDirSelect);
            this.panel1.Controls.Add(this.edDir);
            this.panel1.Controls.Add(this.buUp);
            this.panel1.Controls.Add(this.buForward);
            this.panel1.Controls.Add(this.buBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.buBack.Location = new System.Drawing.Point(12, 30);
            this.buBack.Name = "button1";
            this.buBack.Size = new System.Drawing.Size(75, 23);
            this.buBack.TabIndex = 0;
            this.buBack.Text = "◀";
            this.buBack.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buForward.Location = new System.Drawing.Point(93, 30);
            this.buForward.Name = "button2";
            this.buForward.Size = new System.Drawing.Size(75, 23);
            this.buForward.TabIndex = 1;
            this.buForward.Text = "▶";
            this.buForward.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.buUp.Location = new System.Drawing.Point(174, 30);
            this.buUp.Name = "button3";
            this.buUp.Size = new System.Drawing.Size(75, 23);
            this.buUp.TabIndex = 2;
            this.buUp.Text = "button3";
            this.buUp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.edDir.Location = new System.Drawing.Point(268, 32);
            this.edDir.Name = "textBox1";
            this.edDir.Size = new System.Drawing.Size(378, 20);
            this.edDir.TabIndex = 3;
            // 
            // button4
            // 
            this.buDirSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buDirSelect.Location = new System.Drawing.Point(652, 30);
            this.buDirSelect.Name = "button4";
            this.buDirSelect.Size = new System.Drawing.Size(75, 23);
            this.buDirSelect.TabIndex = 4;
            this.buDirSelect.Text = "button4";
            this.buDirSelect.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB.Location = new System.Drawing.Point(0, 88);
            this.WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB.Name = "webBrowser1";
            this.WB.Size = new System.Drawing.Size(800, 362);
            this.WB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WB);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "labFileExplorerOnWB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buDirSelect;
        private System.Windows.Forms.TextBox edDir;
        private System.Windows.Forms.Button buUp;
        private System.Windows.Forms.Button buForward;
        private System.Windows.Forms.Button buBack;
        private System.Windows.Forms.WebBrowser WB;
    }
}

