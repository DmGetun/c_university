namespace labZoomImage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCenterImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMZoom = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::labZoomImage.Properties.Resources._305352_alexfas01;
            this.pictureBox1.Location = new System.Drawing.Point(79, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(451, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 98);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM
            // 
            this.TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMNormal,
            this.TSMStretch,
            this.TSMAutoSize,
            this.TSMCenterImage,
            this.TSMZoom});
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(111, 20);
            this.TSM.Text = "Режим картинки";
            // 
            // TSMNormal
            // 
            this.TSMNormal.Name = "TSMNormal";
            this.TSMNormal.Size = new System.Drawing.Size(180, 22);
            this.TSMNormal.Text = "Normal";
            // 
            // TSMStretch
            // 
            this.TSMStretch.Name = "TSMStretch";
            this.TSMStretch.Size = new System.Drawing.Size(180, 22);
            this.TSMStretch.Text = "StretchImage";
            // 
            // TSMAutoSize
            // 
            this.TSMAutoSize.Name = "TSMAutoSize";
            this.TSMAutoSize.Size = new System.Drawing.Size(180, 22);
            this.TSMAutoSize.Text = "AutoSize";
            // 
            // TSMCenterImage
            // 
            this.TSMCenterImage.Name = "TSMCenterImage";
            this.TSMCenterImage.Size = new System.Drawing.Size(180, 22);
            this.TSMCenterImage.Text = "CenterImage";
            // 
            // TSMZoom
            // 
            this.TSMZoom.Name = "TSMZoom";
            this.TSMZoom.Size = new System.Drawing.Size(180, 22);
            this.TSMZoom.Text = "Zoom";
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fm";
            this.Text = "labZoomImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM;
        private System.Windows.Forms.ToolStripMenuItem TSMNormal;
        private System.Windows.Forms.ToolStripMenuItem TSMStretch;
        private System.Windows.Forms.ToolStripMenuItem TSMAutoSize;
        private System.Windows.Forms.ToolStripMenuItem TSMCenterImage;
        private System.Windows.Forms.ToolStripMenuItem TSMZoom;
    }
}

