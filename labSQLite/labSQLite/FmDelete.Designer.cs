namespace labSQLite
{
    partial class FmDelete
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
            this.laID = new System.Windows.Forms.Label();
            this.nuID = new System.Windows.Forms.NumericUpDown();
            this.laFIOCaption = new System.Windows.Forms.Label();
            this.edFIOCaption = new System.Windows.Forms.TextBox();
            this.laAgePriority = new System.Windows.Forms.Label();
            this.edAgePriority = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAgePriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица";
            // 
            // dmTable
            // 
            this.dmTable.FormattingEnabled = true;
            this.dmTable.Items.AddRange(new object[] {
            "Users",
            "Notes"});
            this.dmTable.Location = new System.Drawing.Point(69, 10);
            this.dmTable.Name = "dmTable";
            this.dmTable.Size = new System.Drawing.Size(121, 21);
            this.dmTable.TabIndex = 1;
            // 
            // laID
            // 
            this.laID.AutoSize = true;
            this.laID.Location = new System.Drawing.Point(16, 51);
            this.laID.Name = "laID";
            this.laID.Size = new System.Drawing.Size(18, 13);
            this.laID.TabIndex = 2;
            this.laID.Text = "ID";
            // 
            // nuID
            // 
            this.nuID.Location = new System.Drawing.Point(40, 51);
            this.nuID.Name = "nuID";
            this.nuID.Size = new System.Drawing.Size(150, 20);
            this.nuID.TabIndex = 3;
            // 
            // laFIOCaption
            // 
            this.laFIOCaption.AutoSize = true;
            this.laFIOCaption.Location = new System.Drawing.Point(16, 85);
            this.laFIOCaption.Name = "laFIOCaption";
            this.laFIOCaption.Size = new System.Drawing.Size(73, 13);
            this.laFIOCaption.TabIndex = 4;
            this.laFIOCaption.Text = "laFIO/Caption";
            // 
            // edFIOCaption
            // 
            this.edFIOCaption.Location = new System.Drawing.Point(96, 85);
            this.edFIOCaption.Multiline = true;
            this.edFIOCaption.Name = "edFIOCaption";
            this.edFIOCaption.Size = new System.Drawing.Size(197, 59);
            this.edFIOCaption.TabIndex = 5;
            // 
            // laAgePriority
            // 
            this.laAgePriority.AutoSize = true;
            this.laAgePriority.Location = new System.Drawing.Point(19, 168);
            this.laAgePriority.Name = "laAgePriority";
            this.laAgePriority.Size = new System.Drawing.Size(70, 13);
            this.laAgePriority.TabIndex = 6;
            this.laAgePriority.Text = "laAge/Priority";
            // 
            // edAgePriority
            // 
            this.edAgePriority.Location = new System.Drawing.Point(96, 168);
            this.edAgePriority.Name = "edAgePriority";
            this.edAgePriority.Size = new System.Drawing.Size(156, 20);
            this.edAgePriority.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edAgePriority);
            this.Controls.Add(this.laAgePriority);
            this.Controls.Add(this.edFIOCaption);
            this.Controls.Add(this.laFIOCaption);
            this.Controls.Add(this.nuID);
            this.Controls.Add(this.laID);
            this.Controls.Add(this.dmTable);
            this.Controls.Add(this.label1);
            this.Name = "FmDelete";
            this.Text = "Удаление";
            ((System.ComponentModel.ISupportInitialize)(this.nuID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAgePriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laID;
        public System.Windows.Forms.NumericUpDown nuID;
        public System.Windows.Forms.TextBox edFIOCaption;
        public System.Windows.Forms.NumericUpDown edAgePriority;
        public System.Windows.Forms.ComboBox dmTable;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label laFIOCaption;
        public System.Windows.Forms.Label laAgePriority;
    }
}