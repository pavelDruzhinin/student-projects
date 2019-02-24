namespace MathSoLution
{
    partial class Cosinus
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cosinus));
            this.comboTrig = new System.Windows.Forms.ComboBox();
            this.angleSub = new System.Windows.Forms.Button();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.infBox = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разложениеНаМножителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулыПриведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоремаПифагораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboTrig
            // 
            this.comboTrig.BackColor = System.Drawing.SystemColors.Window;
            this.comboTrig.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboTrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrig.FormattingEnabled = true;
            this.comboTrig.IntegralHeight = false;
            this.comboTrig.Items.AddRange(new object[] {
            "cos",
            "sin",
            "tg",
            "ctg"});
            this.comboTrig.Location = new System.Drawing.Point(16, 42);
            this.comboTrig.Name = "comboTrig";
            this.comboTrig.Size = new System.Drawing.Size(121, 21);
            this.comboTrig.TabIndex = 1;
            this.comboTrig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.univ_KeyPress);
            // 
            // angleSub
            // 
            this.angleSub.Location = new System.Drawing.Point(185, 69);
            this.angleSub.Name = "angleSub";
            this.angleSub.Size = new System.Drawing.Size(75, 23);
            this.angleSub.TabIndex = 3;
            this.angleSub.Text = "Вычислить";
            this.angleSub.UseVisualStyleBackColor = true;
            this.angleSub.Click += new System.EventHandler(this.angleSub_Click);
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(159, 42);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(100, 20);
            this.angleBox.TabIndex = 2;
            this.angleBox.Text = "0";
            this.angleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // infBox
            // 
            this.infBox.Location = new System.Drawing.Point(16, 98);
            this.infBox.Multiline = true;
            this.infBox.Name = "infBox";
            this.infBox.ReadOnly = true;
            this.infBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infBox.Size = new System.Drawing.Size(243, 125);
            this.infBox.TabIndex = 4;
            this.infBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem1,
            this.разложениеНаМножителиToolStripMenuItem,
            this.формулыПриведенияToolStripMenuItem,
            this.теоремаПифагораToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // главнаяToolStripMenuItem1
            // 
            this.главнаяToolStripMenuItem1.Name = "главнаяToolStripMenuItem1";
            this.главнаяToolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.главнаяToolStripMenuItem1.Text = "Главная";
            // 
            // разложениеНаМножителиToolStripMenuItem
            // 
            this.разложениеНаМножителиToolStripMenuItem.Name = "разложениеНаМножителиToolStripMenuItem";
            this.разложениеНаМножителиToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.разложениеНаМножителиToolStripMenuItem.Text = "Разложение на множители";
            // 
            // формулыПриведенияToolStripMenuItem
            // 
            this.формулыПриведенияToolStripMenuItem.Name = "формулыПриведенияToolStripMenuItem";
            this.формулыПриведенияToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.формулыПриведенияToolStripMenuItem.Text = "Формулы приведения";
            // 
            // теоремаПифагораToolStripMenuItem
            // 
            this.теоремаПифагораToolStripMenuItem.Name = "теоремаПифагораToolStripMenuItem";
            this.теоремаПифагораToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.теоремаПифагораToolStripMenuItem.Text = "Теорема Пифагора";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Выберите функцию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите угол \r\nв градусах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Решение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboTrig);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.angleSub);
            this.groupBox1.Controls.Add(this.angleBox);
            this.groupBox1.Controls.Add(this.infBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 239);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формулы приведения";
            // 
            // Cosinus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cosinus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathSoLution";
            this.Load += new System.EventHandler(this.Cosinus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTrig;
        private System.Windows.Forms.Button angleSub;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.TextBox infBox;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разложениеНаМножителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулыПриведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоремаПифагораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem1;
    }
}

