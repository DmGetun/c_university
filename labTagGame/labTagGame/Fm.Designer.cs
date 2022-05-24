namespace labTagGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSize = new System.Windows.Forms.ToolStripMenuItem();
            this.легкаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsGameForm = new System.Windows.Forms.ToolStripMenuItem();
            this.циферкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картиночкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsComplexity = new System.Windows.Forms.ToolStripMenuItem();
            this.TlEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.TlMid = new System.Windows.Forms.ToolStripMenuItem();
            this.TlHard = new System.Windows.Forms.ToolStripMenuItem();
            this.TsChangeImage = new System.Windows.Forms.ToolStripMenuItem();
            this.PumaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TigrTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Puma2Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.TsCollectImage = new System.Windows.Forms.ToolStripMenuItem();
            this.grb = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsStart,
            this.TsSize,
            this.TsGameForm,
            this.TsComplexity,
            this.TsChangeImage,
            this.TsCollectImage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsStart
            // 
            this.TsStart.AccessibleName = "GameStart";
            this.TsStart.Name = "TsStart";
            this.TsStart.Size = new System.Drawing.Size(86, 20);
            this.TsStart.Text = "Начать игру";
            this.TsStart.Click += new System.EventHandler(this.start_game);
            // 
            // TsSize
            // 
            this.TsSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкаяToolStripMenuItem,
            this.средняяToolStripMenuItem,
            this.сложнаяToolStripMenuItem});
            this.TsSize.Name = "TsSize";
            this.TsSize.Size = new System.Drawing.Size(89, 20);
            this.TsSize.Text = "Размер поля";
            // 
            // легкаяToolStripMenuItem
            // 
            this.легкаяToolStripMenuItem.Name = "легкаяToolStripMenuItem";
            this.легкаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.легкаяToolStripMenuItem.Text = "3x3";
            this.легкаяToolStripMenuItem.Click += new System.EventHandler(this.tlpEasyEvent);
            // 
            // средняяToolStripMenuItem
            // 
            this.средняяToolStripMenuItem.Name = "средняяToolStripMenuItem";
            this.средняяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.средняяToolStripMenuItem.Text = "4x4";
            this.средняяToolStripMenuItem.Click += new System.EventHandler(this.tlpMidEvent);
            // 
            // сложнаяToolStripMenuItem
            // 
            this.сложнаяToolStripMenuItem.Name = "сложнаяToolStripMenuItem";
            this.сложнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сложнаяToolStripMenuItem.Text = "5x5";
            this.сложнаяToolStripMenuItem.Click += new System.EventHandler(this.tlpHardEvent);
            // 
            // TsGameForm
            // 
            this.TsGameForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.циферкиToolStripMenuItem,
            this.картиночкиToolStripMenuItem});
            this.TsGameForm.Name = "TsGameForm";
            this.TsGameForm.Size = new System.Drawing.Size(70, 20);
            this.TsGameForm.Text = "Вид игры";
            // 
            // циферкиToolStripMenuItem
            // 
            this.циферкиToolStripMenuItem.Name = "циферкиToolStripMenuItem";
            this.циферкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.циферкиToolStripMenuItem.Text = "Циферки";
            this.циферкиToolStripMenuItem.Click += new System.EventHandler(this.game_number);
            // 
            // картиночкиToolStripMenuItem
            // 
            this.картиночкиToolStripMenuItem.Name = "картиночкиToolStripMenuItem";
            this.картиночкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картиночкиToolStripMenuItem.Text = "Картиночки";
            this.картиночкиToolStripMenuItem.Click += new System.EventHandler(this.game_image);
            // 
            // TsComplexity
            // 
            this.TsComplexity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlEasy,
            this.TlMid,
            this.TlHard});
            this.TsComplexity.Name = "TsComplexity";
            this.TsComplexity.Size = new System.Drawing.Size(81, 20);
            this.TsComplexity.Text = "Сложность";
            // 
            // TlEasy
            // 
            this.TlEasy.Name = "TlEasy";
            this.TlEasy.Size = new System.Drawing.Size(180, 22);
            this.TlEasy.Text = "Легкая";
            // 
            // TlMid
            // 
            this.TlMid.Name = "TlMid";
            this.TlMid.Size = new System.Drawing.Size(180, 22);
            this.TlMid.Text = "Средняя";
            // 
            // TlHard
            // 
            this.TlHard.Name = "TlHard";
            this.TlHard.Size = new System.Drawing.Size(180, 22);
            this.TlHard.Text = "Сложная";
            // 
            // TsChangeImage
            // 
            this.TsChangeImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PumaTool,
            this.TigrTool,
            this.Puma2Tool});
            this.TsChangeImage.Name = "TsChangeImage";
            this.TsChangeImage.Size = new System.Drawing.Size(119, 20);
            this.TsChangeImage.Text = "Выбрать картинку";
            // 
            // PumaTool
            // 
            this.PumaTool.Name = "PumaTool";
            this.PumaTool.Size = new System.Drawing.Size(180, 22);
            this.PumaTool.Text = "Пума";
            // 
            // TigrTool
            // 
            this.TigrTool.Name = "TigrTool";
            this.TigrTool.Size = new System.Drawing.Size(180, 22);
            this.TigrTool.Text = "Тигр";
            // 
            // Puma2Tool
            // 
            this.Puma2Tool.Name = "Puma2Tool";
            this.Puma2Tool.Size = new System.Drawing.Size(180, 22);
            this.Puma2Tool.Text = "Пума 2";
            // 
            // TsCollectImage
            // 
            this.TsCollectImage.Name = "TsCollectImage";
            this.TsCollectImage.Size = new System.Drawing.Size(65, 20);
            this.TsCollectImage.Text = "Собрать";
            // 
            // grb
            // 
            this.grb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb.Location = new System.Drawing.Point(0, 27);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(711, 329);
            this.grb.TabIndex = 8;
            this.grb.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 362);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(687, 116);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(727, 519);
            this.Name = "Fm";
            this.Text = "labTagGame";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsSize;
        private System.Windows.Forms.ToolStripMenuItem легкаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsStart;
        private System.Windows.Forms.ToolStripMenuItem TsGameForm;
        private System.Windows.Forms.ToolStripMenuItem циферкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картиночкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsComplexity;
        private System.Windows.Forms.ToolStripMenuItem TlEasy;
        private System.Windows.Forms.ToolStripMenuItem TlMid;
        private System.Windows.Forms.ToolStripMenuItem TlHard;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem TsChangeImage;
        private System.Windows.Forms.ToolStripMenuItem PumaTool;
        private System.Windows.Forms.ToolStripMenuItem TigrTool;
        private System.Windows.Forms.ToolStripMenuItem Puma2Tool;
        private System.Windows.Forms.ToolStripMenuItem TsCollectImage;
    }
}

