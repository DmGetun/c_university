namespace labDirToTags
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
            this.edDir = new System.Windows.Forms.TextBox();
            this.buSelDir = new System.Windows.Forms.Button();
            this.edTags = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.Order = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edDir
            // 
            this.edDir.Location = new System.Drawing.Point(58, 44);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(523, 20);
            this.edDir.TabIndex = 0;
            // 
            // buSelDir
            // 
            this.buSelDir.Location = new System.Drawing.Point(609, 44);
            this.buSelDir.Name = "buSelDir";
            this.buSelDir.Size = new System.Drawing.Size(75, 23);
            this.buSelDir.TabIndex = 1;
            this.buSelDir.Text = " ";
            this.buSelDir.UseVisualStyleBackColor = true;
            // 
            // edTags
            // 
            this.edTags.Location = new System.Drawing.Point(58, 110);
            this.edTags.Multiline = true;
            this.edTags.Name = "edTags";
            this.edTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edTags.Size = new System.Drawing.Size(654, 242);
            this.edTags.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMOrder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMOrder
            // 
            this.TSMOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderDesc,
            this.Order});
            this.TSMOrder.Name = "TSMOrder";
            this.TSMOrder.Size = new System.Drawing.Size(85, 20);
            this.TSMOrder.Text = "Сортировка";
            // 
            // OrderDesc
            // 
            this.OrderDesc.Name = "OrderDesc";
            this.OrderDesc.Size = new System.Drawing.Size(147, 22);
            this.OrderDesc.Text = "Убыванию";
            // 
            // Order
            // 
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(147, 22);
            this.Order.Text = "Возрастанию";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по имени:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(164, 79);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(262, 20);
            this.tbSearch.TabIndex = 5;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edTags);
            this.Controls.Add(this.buSelDir);
            this.Controls.Add(this.edDir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fm";
            this.Text = "labDirToTags";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edDir;
        private System.Windows.Forms.Button buSelDir;
        private System.Windows.Forms.TextBox edTags;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMOrder;
        private System.Windows.Forms.ToolStripMenuItem OrderDesc;
        private System.Windows.Forms.ToolStripMenuItem Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

