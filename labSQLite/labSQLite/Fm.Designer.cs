namespace labSQLite
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
            this.lvLogs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.edSQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buUsersShow = new System.Windows.Forms.Button();
            this.buNotesShow = new System.Windows.Forms.Button();
            this.buRunOne = new System.Windows.Forms.Button();
            this.buRunSQL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buNotesAdd = new System.Windows.Forms.Button();
            this.buUsersAdd = new System.Windows.Forms.Button();
            this.buSearch = new System.Windows.Forms.Button();
            this.buDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(12, 47);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(215, 413);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лог запусков приложения";
            // 
            // edSQL
            // 
            this.edSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSQL.Location = new System.Drawing.Point(233, 47);
            this.edSQL.Multiline = true;
            this.edSQL.Name = "edSQL";
            this.edSQL.Size = new System.Drawing.Size(525, 67);
            this.edSQL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SQL";
            // 
            // buUsersShow
            // 
            this.buUsersShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buUsersShow.Location = new System.Drawing.Point(233, 120);
            this.buUsersShow.Name = "buUsersShow";
            this.buUsersShow.Size = new System.Drawing.Size(99, 23);
            this.buUsersShow.TabIndex = 4;
            this.buUsersShow.Text = "Пользователи";
            this.buUsersShow.UseVisualStyleBackColor = true;
            // 
            // buNotesShow
            // 
            this.buNotesShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buNotesShow.Location = new System.Drawing.Point(338, 120);
            this.buNotesShow.Name = "buNotesShow";
            this.buNotesShow.Size = new System.Drawing.Size(107, 23);
            this.buNotesShow.TabIndex = 5;
            this.buNotesShow.Text = "Заметки";
            this.buNotesShow.UseVisualStyleBackColor = true;
            // 
            // buRunOne
            // 
            this.buRunOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buRunOne.Location = new System.Drawing.Point(540, 120);
            this.buRunOne.Name = "buRunOne";
            this.buRunOne.Size = new System.Drawing.Size(107, 23);
            this.buRunOne.TabIndex = 6;
            this.buRunOne.Text = "Выполнить 1";
            this.buRunOne.UseVisualStyleBackColor = true;
            // 
            // buRunSQL
            // 
            this.buRunSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buRunSQL.Location = new System.Drawing.Point(653, 120);
            this.buRunSQL.Name = "buRunSQL";
            this.buRunSQL.Size = new System.Drawing.Size(107, 23);
            this.buRunSQL.TabIndex = 7;
            this.buRunSQL.Text = "Выполнить SQL";
            this.buRunSQL.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 223);
            this.dataGridView1.TabIndex = 8;
            // 
            // buNotesAdd
            // 
            this.buNotesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buNotesAdd.Location = new System.Drawing.Point(338, 378);
            this.buNotesAdd.Name = "buNotesAdd";
            this.buNotesAdd.Size = new System.Drawing.Size(107, 82);
            this.buNotesAdd.TabIndex = 11;
            this.buNotesAdd.Text = "Добавить заметку";
            this.buNotesAdd.UseVisualStyleBackColor = true;
            // 
            // buUsersAdd
            // 
            this.buUsersAdd.Location = new System.Drawing.Point(233, 378);
            this.buUsersAdd.Name = "buUsersAdd";
            this.buUsersAdd.Size = new System.Drawing.Size(99, 82);
            this.buUsersAdd.TabIndex = 12;
            this.buUsersAdd.Text = "Добавить пользователя";
            this.buUsersAdd.UseVisualStyleBackColor = true;
            // 
            // buSearch
            // 
            this.buSearch.Location = new System.Drawing.Point(540, 378);
            this.buSearch.Name = "buSearch";
            this.buSearch.Size = new System.Drawing.Size(107, 82);
            this.buSearch.TabIndex = 13;
            this.buSearch.Text = "Поиск";
            this.buSearch.UseVisualStyleBackColor = true;
            // 
            // buDelete
            // 
            this.buDelete.Location = new System.Drawing.Point(654, 378);
            this.buDelete.Name = "buDelete";
            this.buDelete.Size = new System.Drawing.Size(104, 82);
            this.buDelete.TabIndex = 14;
            this.buDelete.Text = "Удалить";
            this.buDelete.UseVisualStyleBackColor = true;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 472);
            this.Controls.Add(this.buDelete);
            this.Controls.Add(this.buSearch);
            this.Controls.Add(this.buUsersAdd);
            this.Controls.Add(this.buNotesAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buRunSQL);
            this.Controls.Add(this.buRunOne);
            this.Controls.Add(this.buNotesShow);
            this.Controls.Add(this.buUsersShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edSQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLogs);
            this.Name = "Fm";
            this.Text = "labSQLite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buUsersShow;
        private System.Windows.Forms.Button buNotesShow;
        private System.Windows.Forms.Button buRunOne;
        private System.Windows.Forms.Button buRunSQL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buNotesAdd;
        private System.Windows.Forms.Button buUsersAdd;
        private System.Windows.Forms.Button buSearch;
        private System.Windows.Forms.Button buDelete;
    }
}

