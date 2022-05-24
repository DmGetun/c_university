namespace labSQLite
{
    partial class FmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dmTable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edAgePriority = new System.Windows.Forms.NumericUpDown();
            this.laAgePriority = new System.Windows.Forms.Label();
            this.edFIOCaption = new System.Windows.Forms.TextBox();
            this.laFIOCaption = new System.Windows.Forms.Label();
            this.nuID = new System.Windows.Forms.NumericUpDown();
            this.laID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edAgePriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица";
            // 
            // dmTable
            // 
            this.dmTable.FormattingEnabled = true;
            this.dmTable.Items.AddRange(new object[] {
            "Users",
            "Notes"});
            this.dmTable.Location = new System.Drawing.Point(68, 6);
            this.dmTable.Name = "dmTable";
            this.dmTable.Size = new System.Drawing.Size(121, 21);
            this.dmTable.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // edAgePriority
            // 
            this.edAgePriority.Location = new System.Drawing.Point(99, 150);
            this.edAgePriority.Name = "edAgePriority";
            this.edAgePriority.Size = new System.Drawing.Size(156, 20);
            this.edAgePriority.TabIndex = 14;
            // 
            // laAgePriority
            // 
            this.laAgePriority.AutoSize = true;
            this.laAgePriority.Location = new System.Drawing.Point(22, 150);
            this.laAgePriority.Name = "laAgePriority";
            this.laAgePriority.Size = new System.Drawing.Size(70, 13);
            this.laAgePriority.TabIndex = 13;
            this.laAgePriority.Text = "laAge/Priority";
            // 
            // edFIOCaption
            // 
            this.edFIOCaption.Location = new System.Drawing.Point(99, 67);
            this.edFIOCaption.Multiline = true;
            this.edFIOCaption.Name = "edFIOCaption";
            this.edFIOCaption.Size = new System.Drawing.Size(197, 59);
            this.edFIOCaption.TabIndex = 12;
            // 
            // laFIOCaption
            // 
            this.laFIOCaption.AutoSize = true;
            this.laFIOCaption.Location = new System.Drawing.Point(19, 67);
            this.laFIOCaption.Name = "laFIOCaption";
            this.laFIOCaption.Size = new System.Drawing.Size(73, 13);
            this.laFIOCaption.TabIndex = 11;
            this.laFIOCaption.Text = "laFIO/Caption";
            // 
            // nuID
            // 
            this.nuID.Location = new System.Drawing.Point(43, 33);
            this.nuID.Name = "nuID";
            this.nuID.Size = new System.Drawing.Size(150, 20);
            this.nuID.TabIndex = 10;
            // 
            // laID
            // 
            this.laID.AutoSize = true;
            this.laID.Location = new System.Drawing.Point(19, 33);
            this.laID.Name = "laID";
            this.laID.Size = new System.Drawing.Size(18, 13);
            this.laID.TabIndex = 9;
            this.laID.Text = "ID";
            // 
            // FmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edAgePriority);
            this.Controls.Add(this.laAgePriority);
            this.Controls.Add(this.edFIOCaption);
            this.Controls.Add(this.laFIOCaption);
            this.Controls.Add(this.nuID);
            this.Controls.Add(this.laID);
            this.Controls.Add(this.dmTable);
            this.Controls.Add(this.label1);
            this.Name = "FmSearch";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.edAgePriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox dmTable;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown edAgePriority;
        public System.Windows.Forms.Label laAgePriority;
        public System.Windows.Forms.TextBox edFIOCaption;
        public System.Windows.Forms.Label laFIOCaption;
        public System.Windows.Forms.NumericUpDown nuID;
        private System.Windows.Forms.Label laID;
    }
}