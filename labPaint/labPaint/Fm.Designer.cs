namespace labPaint
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
            this.paMenu = new System.Windows.Forms.Panel();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pxRect = new System.Windows.Forms.PictureBox();
            this.pxLine = new System.Windows.Forms.PictureBox();
            this.pxColorAdd = new System.Windows.Forms.PictureBox();
            this.buLoad = new System.Windows.Forms.Button();
            this.buSave = new System.Windows.Forms.Button();
            this.pxColorMain = new System.Windows.Forms.PictureBox();
            this.pxImage = new System.Windows.Forms.PictureBox();
            this.buClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laWidth = new System.Windows.Forms.Label();
            this.paMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColorAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColorMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // paMenu
            // 
            this.paMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paMenu.Controls.Add(this.laWidth);
            this.paMenu.Controls.Add(this.label3);
            this.paMenu.Controls.Add(this.label2);
            this.paMenu.Controls.Add(this.label1);
            this.paMenu.Controls.Add(this.buClear);
            this.paMenu.Controls.Add(this.tbWidth);
            this.paMenu.Controls.Add(this.pxColorAdd);
            this.paMenu.Controls.Add(this.buLoad);
            this.paMenu.Controls.Add(this.buSave);
            this.paMenu.Controls.Add(this.pxColorMain);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paMenu.Location = new System.Drawing.Point(0, 60);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(146, 325);
            this.paMenu.TabIndex = 0;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(7, 178);
            this.tbWidth.Minimum = 1;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(127, 45);
            this.tbWidth.TabIndex = 4;
            this.tbWidth.Value = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pxRect);
            this.panel1.Controls.Add(this.pxLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 2;
            // 
            // pxRect
            // 
            this.pxRect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxRect.Location = new System.Drawing.Point(88, 3);
            this.pxRect.Name = "pxRect";
            this.pxRect.Size = new System.Drawing.Size(46, 46);
            this.pxRect.TabIndex = 1;
            this.pxRect.TabStop = false;
            // 
            // pxLine
            // 
            this.pxLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxLine.Location = new System.Drawing.Point(7, 3);
            this.pxLine.Name = "pxLine";
            this.pxLine.Size = new System.Drawing.Size(46, 46);
            this.pxLine.TabIndex = 0;
            this.pxLine.TabStop = false;
            // 
            // pxColorAdd
            // 
            this.pxColorAdd.BackColor = System.Drawing.Color.Red;
            this.pxColorAdd.Location = new System.Drawing.Point(79, 103);
            this.pxColorAdd.Name = "pxColorAdd";
            this.pxColorAdd.Size = new System.Drawing.Size(43, 35);
            this.pxColorAdd.TabIndex = 3;
            this.pxColorAdd.TabStop = false;
            // 
            // buLoad
            // 
            this.buLoad.Location = new System.Drawing.Point(79, 11);
            this.buLoad.Name = "buLoad";
            this.buLoad.Size = new System.Drawing.Size(57, 23);
            this.buLoad.TabIndex = 2;
            this.buLoad.Text = "Load";
            this.buLoad.UseVisualStyleBackColor = true;
            // 
            // buSave
            // 
            this.buSave.Location = new System.Drawing.Point(3, 11);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(60, 23);
            this.buSave.TabIndex = 1;
            this.buSave.Text = "Save";
            this.buSave.UseVisualStyleBackColor = true;
            // 
            // pxColorMain
            // 
            this.pxColorMain.BackColor = System.Drawing.Color.Lime;
            this.pxColorMain.Location = new System.Drawing.Point(11, 103);
            this.pxColorMain.Name = "pxColorMain";
            this.pxColorMain.Size = new System.Drawing.Size(41, 35);
            this.pxColorMain.TabIndex = 0;
            this.pxColorMain.TabStop = false;
            // 
            // pxImage
            // 
            this.pxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxImage.Location = new System.Drawing.Point(146, 60);
            this.pxImage.Name = "pxImage";
            this.pxImage.Size = new System.Drawing.Size(654, 325);
            this.pxImage.TabIndex = 1;
            this.pxImage.TabStop = false;
            // 
            // buClear
            // 
            this.buClear.Location = new System.Drawing.Point(3, 40);
            this.buClear.Name = "buClear";
            this.buClear.Size = new System.Drawing.Size(133, 23);
            this.buClear.TabIndex = 5;
            this.buClear.Text = "Clear";
            this.buClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цвет 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цвет 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ширина линии";
            // 
            // laWidth
            // 
            this.laWidth.AutoSize = true;
            this.laWidth.Location = new System.Drawing.Point(11, 209);
            this.laWidth.Name = "laWidth";
            this.laWidth.Size = new System.Drawing.Size(0, 13);
            this.laWidth.TabIndex = 9;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.pxImage);
            this.Controls.Add(this.paMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Fm";
            this.Text = "labPaint";
            this.paMenu.ResumeLayout(false);
            this.paMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColorAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxColorMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paMenu;
        private System.Windows.Forms.Button buLoad;
        private System.Windows.Forms.Button buSave;
        private System.Windows.Forms.PictureBox pxColorMain;
        private System.Windows.Forms.PictureBox pxImage;
        private System.Windows.Forms.PictureBox pxColorAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pxLine;
        private System.Windows.Forms.PictureBox pxRect;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.Button buClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laWidth;
    }
}

