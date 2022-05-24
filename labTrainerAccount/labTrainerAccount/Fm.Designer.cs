namespace labTrainerAccount
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.laWrong = new System.Windows.Forms.Label();
            this.laCorrect = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buNo = new System.Windows.Forms.Button();
            this.buYes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.laCode = new System.Windows.Forms.Label();
            this.rBut1 = new System.Windows.Forms.RadioButton();
            this.rBut2 = new System.Windows.Forms.RadioButton();
            this.rBut3 = new System.Windows.Forms.RadioButton();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.butRes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47735F));
            this.tableLayoutPanel1.Controls.Add(this.laWrong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.laCorrect, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // laWrong
            // 
            this.laWrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laWrong.BackColor = System.Drawing.Color.Red;
            this.laWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laWrong.Location = new System.Drawing.Point(136, 0);
            this.laWrong.Name = "laWrong";
            this.laWrong.Size = new System.Drawing.Size(126, 62);
            this.laWrong.TabIndex = 1;
            this.laWrong.Text = "Неверно = 0";
            this.laWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            this.laCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.laCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCorrect.Location = new System.Drawing.Point(3, 0);
            this.laCorrect.Name = "laCorrect";
            this.laCorrect.Size = new System.Drawing.Size(127, 62);
            this.laCorrect.TabIndex = 0;
            this.laCorrect.Text = "Верно = 0";
            this.laCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buNo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buYes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 286);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 69);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buNo
            // 
            this.buNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buNo.Location = new System.Drawing.Point(135, 3);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(127, 63);
            this.buNo.TabIndex = 1;
            this.buNo.Text = "Нет";
            this.buNo.UseVisualStyleBackColor = true;
            // 
            // buYes
            // 
            this.buYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buYes.ForeColor = System.Drawing.Color.Lime;
            this.buYes.Location = new System.Drawing.Point(3, 3);
            this.buYes.Name = "buYes";
            this.buYes.Size = new System.Drawing.Size(126, 63);
            this.buYes.TabIndex = 0;
            this.buYes.Text = "Да";
            this.buYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Верно?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCode
            // 
            this.laCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCode.Location = new System.Drawing.Point(20, 137);
            this.laCode.Name = "laCode";
            this.laCode.Size = new System.Drawing.Size(262, 118);
            this.laCode.TabIndex = 3;
            this.laCode.Text = "10+11=21";
            this.laCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBut1
            // 
            this.rBut1.AutoSize = true;
            this.rBut1.Checked = true;
            this.rBut1.Location = new System.Drawing.Point(6, 19);
            this.rBut1.Name = "rBut1";
            this.rBut1.Size = new System.Drawing.Size(62, 17);
            this.rBut1.TabIndex = 5;
            this.rBut1.TabStop = true;
            this.rBut1.Text = "Легкий";
            this.rBut1.UseVisualStyleBackColor = true;
            // 
            // rBut2
            // 
            this.rBut2.AutoSize = true;
            this.rBut2.Location = new System.Drawing.Point(79, 19);
            this.rBut2.Name = "rBut2";
            this.rBut2.Size = new System.Drawing.Size(68, 17);
            this.rBut2.TabIndex = 6;
            this.rBut2.Text = "Средний";
            this.rBut2.UseVisualStyleBackColor = true;
            // 
            // rBut3
            // 
            this.rBut3.AutoSize = true;
            this.rBut3.Location = new System.Drawing.Point(153, 19);
            this.rBut3.Name = "rBut3";
            this.rBut3.Size = new System.Drawing.Size(72, 17);
            this.rBut3.TabIndex = 7;
            this.rBut3.Text = "Сложный";
            this.rBut3.UseVisualStyleBackColor = true;
            // 
            // grBox
            // 
            this.grBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBox.AutoSize = true;
            this.grBox.Controls.Add(this.rBut1);
            this.grBox.Controls.Add(this.rBut3);
            this.grBox.Controls.Add(this.rBut2);
            this.grBox.Location = new System.Drawing.Point(12, 12);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(231, 57);
            this.grBox.TabIndex = 8;
            this.grBox.TabStop = false;
            this.grBox.Text = "Уровень сложности";
            // 
            // butRes
            // 
            this.butRes.Location = new System.Drawing.Point(243, 22);
            this.butRes.Name = "butRes";
            this.butRes.Size = new System.Drawing.Size(75, 41);
            this.butRes.TabIndex = 9;
            this.butRes.Text = "Сбросить";
            this.butRes.UseVisualStyleBackColor = true;
            this.butRes.Click += new System.EventHandler(this.butRes_Click);
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 367);
            this.Controls.Add(this.butRes);
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.laCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Fm";
            this.Text = "labTrainerAccount";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label laCorrect;
        private System.Windows.Forms.Label laWrong;
        private System.Windows.Forms.Button buNo;
        private System.Windows.Forms.Button buYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laCode;
        private System.Windows.Forms.RadioButton rBut1;
        private System.Windows.Forms.RadioButton rBut2;
        private System.Windows.Forms.RadioButton rBut3;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Button butRes;
    }
}

