namespace MyProjectSudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanBig = new System.Windows.Forms.Panel();
            this.buClear = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            this.PanSmall = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMiddle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSWrongLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSillum = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCheckWrong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSHideNumbers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSHighlightNumbers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSRools = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TSLabelComp = new System.Windows.Forms.ToolStripLabel();
            this.TSLabelTime = new System.Windows.Forms.ToolStripLabel();
            this.TSLabelWrong = new System.Windows.Forms.ToolStripLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.PanBig.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBig
            // 
            this.PanBig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanBig.Controls.Add(this.buClear);
            this.PanBig.Controls.Add(this.buCancel);
            this.PanBig.Controls.Add(this.PanSmall);
            this.PanBig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBig.Location = new System.Drawing.Point(0, 379);
            this.PanBig.Name = "PanBig";
            this.PanBig.Size = new System.Drawing.Size(746, 107);
            this.PanBig.TabIndex = 0;
            // 
            // buClear
            // 
            this.buClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buClear.Location = new System.Drawing.Point(394, 8);
            this.buClear.Name = "buClear";
            this.buClear.Size = new System.Drawing.Size(339, 29);
            this.buClear.TabIndex = 2;
            this.buClear.Text = "Режим очищения";
            this.buClear.UseVisualStyleBackColor = true;
            // 
            // buCancel
            // 
            this.buCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buCancel.Location = new System.Drawing.Point(3, 8);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(366, 29);
            this.buCancel.TabIndex = 1;
            this.buCancel.Text = " Отменить ход";
            this.buCancel.UseVisualStyleBackColor = false;
            // 
            // PanSmall
            // 
            this.PanSmall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanSmall.Location = new System.Drawing.Point(0, 45);
            this.PanSmall.Name = "PanSmall";
            this.PanSmall.Size = new System.Drawing.Size(744, 60);
            this.PanSmall.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.TSRools});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMEasy,
            this.TSMMiddle,
            this.TSMHard});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripDropDownButton1.Text = "Начать игру";
            // 
            // TSMEasy
            // 
            this.TSMEasy.Name = "TSMEasy";
            this.TSMEasy.Size = new System.Drawing.Size(124, 22);
            this.TSMEasy.Text = "Легкая";
            // 
            // TSMMiddle
            // 
            this.TSMMiddle.Name = "TSMMiddle";
            this.TSMMiddle.Size = new System.Drawing.Size(124, 22);
            this.TSMMiddle.Text = "Средняя";
            // 
            // TSMHard
            // 
            this.TSMHard.Name = "TSMHard";
            this.TSMHard.Size = new System.Drawing.Size(124, 22);
            this.TSMHard.Text = "Сложная";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSWrongLimit,
            this.TSillum,
            this.TSCheckWrong,
            this.TSHideNumbers,
            this.TSHighlightNumbers});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(80, 22);
            this.toolStripDropDownButton2.Text = "Настройки";
            // 
            // TSWrongLimit
            // 
            this.TSWrongLimit.Name = "TSWrongLimit";
            this.TSWrongLimit.Size = new System.Drawing.Size(348, 22);
            this.TSWrongLimit.Text = "+ Ограничение ошибок(требуется автопроверка)";
            // 
            // TSillum
            // 
            this.TSillum.Name = "TSillum";
            this.TSillum.Size = new System.Drawing.Size(348, 22);
            this.TSillum.Text = "+ Подсветка ячеек";
            // 
            // TSCheckWrong
            // 
            this.TSCheckWrong.Name = "TSCheckWrong";
            this.TSCheckWrong.Size = new System.Drawing.Size(348, 22);
            this.TSCheckWrong.Text = "+ Автопроверка ошибок";
            // 
            // TSHideNumbers
            // 
            this.TSHideNumbers.Name = "TSHideNumbers";
            this.TSHideNumbers.Size = new System.Drawing.Size(348, 22);
            this.TSHideNumbers.Text = "+ Скрыть использованные цифры";
            // 
            // TSHighlightNumbers
            // 
            this.TSHighlightNumbers.Name = "TSHighlightNumbers";
            this.TSHighlightNumbers.Size = new System.Drawing.Size(348, 22);
            this.TSHighlightNumbers.Text = "+ Выделять одинаковые числа";
            // 
            // TSRools
            // 
            this.TSRools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSRools.Image = ((System.Drawing.Image)(resources.GetObject("TSRools.Image")));
            this.TSRools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSRools.Name = "TSRools";
            this.TSRools.Size = new System.Drawing.Size(90, 22);
            this.TSRools.Text = "Правила игры";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLabelComp,
            this.TSLabelTime,
            this.TSLabelWrong});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(746, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TSLabelComp
            // 
            this.TSLabelComp.Name = "TSLabelComp";
            this.TSLabelComp.Size = new System.Drawing.Size(69, 22);
            this.TSLabelComp.Text = "Сложность";
            // 
            // TSLabelTime
            // 
            this.TSLabelTime.Name = "TSLabelTime";
            this.TSLabelTime.Size = new System.Drawing.Size(42, 22);
            this.TSLabelTime.Text = "Время";
            // 
            // TSLabelWrong
            // 
            this.TSLabelWrong.Name = "TSLabelWrong";
            this.TSLabelWrong.Size = new System.Drawing.Size(54, 22);
            this.TSLabelWrong.Text = "Ошибки";
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 50);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(746, 329);
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 486);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PanBig);
            this.MinimumSize = new System.Drawing.Size(605, 429);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.PanBig.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanBig;
        private System.Windows.Forms.Panel PanSmall;
        private System.Windows.Forms.Button buClear;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem TSMEasy;
        private System.Windows.Forms.ToolStripMenuItem TSMMiddle;
        private System.Windows.Forms.ToolStripMenuItem TSMHard;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ToolStripLabel TSLabelComp;
        private System.Windows.Forms.ToolStripLabel TSLabelTime;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem TSWrongLimit;
        private System.Windows.Forms.ToolStripLabel TSLabelWrong;
        private System.Windows.Forms.ToolStripMenuItem TSillum;
        private System.Windows.Forms.ToolStripMenuItem TSCheckWrong;
        private System.Windows.Forms.ToolStripMenuItem TSHideNumbers;
        private System.Windows.Forms.ToolStripMenuItem TSHighlightNumbers;
        private System.Windows.Forms.ToolStripButton TSRools;
    }
}

