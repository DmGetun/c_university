namespace labCards
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMVeer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNewCards = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCount = new System.Windows.Forms.TrackBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 24);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(800, 426);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMVeer,
            this.TSMRandom,
            this.TSMNewCards});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMVeer
            // 
            this.TSMVeer.Name = "TSMVeer";
            this.TSMVeer.Size = new System.Drawing.Size(109, 20);
            this.TSMVeer.Text = "Собрать веером";
            // 
            // TSMRandom
            // 
            this.TSMRandom.Name = "TSMRandom";
            this.TSMRandom.Size = new System.Drawing.Size(79, 20);
            this.TSMRandom.Text = "Рандомить";
            // 
            // TSMNewCards
            // 
            this.TSMNewCards.Name = "TSMNewCards";
            this.TSMNewCards.Size = new System.Drawing.Size(92, 20);
            this.TSMNewCards.Text = "Новые карты";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(12, 51);
            this.tbCount.Maximum = 20;
            this.tbCount.Minimum = 4;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(104, 45);
            this.tbCount.TabIndex = 0;
            this.tbCount.Value = 4;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(107, 35);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 13);
            this.labelCount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество карт:";
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fm";
            this.Text = "labCards";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMVeer;
        private System.Windows.Forms.ToolStripMenuItem TSMRandom;
        private System.Windows.Forms.ToolStripMenuItem TSMNewCards;
        private System.Windows.Forms.TrackBar tbCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label2;
    }
}

