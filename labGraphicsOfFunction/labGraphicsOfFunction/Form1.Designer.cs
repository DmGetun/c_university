namespace labGraphicsOfFunction
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
            this.pan = new System.Windows.Forms.Panel();
            this.cbFunctions = new System.Windows.Forms.ComboBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelCoords = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.tbA = new System.Windows.Forms.TrackBar();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan.Controls.Add(this.cbFunctions);
            this.pan.Controls.Add(this.labelC);
            this.pan.Controls.Add(this.labelB);
            this.pan.Controls.Add(this.labelA);
            this.pan.Controls.Add(this.labelCoords);
            this.pan.Controls.Add(this.tbC);
            this.pan.Controls.Add(this.tbB);
            this.pan.Controls.Add(this.tbA);
            this.pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(200, 407);
            this.pan.TabIndex = 1;
            // 
            // cbFunctions
            // 
            this.cbFunctions.FormattingEnabled = true;
            this.cbFunctions.Location = new System.Drawing.Point(14, 27);
            this.cbFunctions.Name = "cbFunctions";
            this.cbFunctions.Size = new System.Drawing.Size(167, 21);
            this.cbFunctions.TabIndex = 7;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(6, 278);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(0, 13);
            this.labelC.TabIndex = 6;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(6, 200);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 13);
            this.labelB.TabIndex = 5;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(3, 121);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(0, 13);
            this.labelA.TabIndex = 4;
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(11, 83);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(0, 13);
            this.labelCoords.TabIndex = 3;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(54, 278);
            this.tbC.Minimum = -10;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(145, 45);
            this.tbC.TabIndex = 2;
            this.tbC.Value = 1;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(54, 200);
            this.tbB.Minimum = -10;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(145, 45);
            this.tbB.TabIndex = 1;
            this.tbB.Value = 1;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(54, 121);
            this.tbA.Minimum = -10;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(145, 45);
            this.tbA.TabIndex = 0;
            this.tbA.Value = 1;
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(200, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(588, 407);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 407);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.pan);
            this.Name = "Form1";
            this.Text = "labGraphicsOfFunction";
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.TrackBar tbC;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.TrackBar tbA;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.ComboBox cbFunctions;
    }
}

