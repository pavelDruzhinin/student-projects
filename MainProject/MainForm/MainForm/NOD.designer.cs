namespace MathSoLution
{
    partial class Nod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nod));
            this.aBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nodBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разложениеНаМножителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулыПриведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоремаПифагораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(138, 25);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(90, 20);
            this.aBox.TabIndex = 1;
            this.aBox.Text = "0";
            this.aBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.digitBox_MouseClick);
            this.aBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // nodBox
            // 
            this.nodBox.Location = new System.Drawing.Point(174, 77);
            this.nodBox.Name = "nodBox";
            this.nodBox.Size = new System.Drawing.Size(75, 23);
            this.nodBox.TabIndex = 3;
            this.nodBox.Text = "Вычислить";
            this.nodBox.UseVisualStyleBackColor = true;
            this.nodBox.Click += new System.EventHandler(this.mnoz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.infBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.aBox);
            this.groupBox1.Controls.Add(this.nodBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 239);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наибольший общий делитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Введите число";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(138, 51);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(90, 20);
            this.bBox.TabIndex = 2;
            this.bBox.Text = "0";
            this.bBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.digitBox_MouseClick);
            this.bBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Решение";
            // 
            // infBox
            // 
            this.infBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infBox.Location = new System.Drawing.Point(6, 107);
            this.infBox.Multiline = true;
            this.infBox.Name = "infBox";
            this.infBox.ReadOnly = true;
            this.infBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infBox.Size = new System.Drawing.Size(256, 128);
            this.infBox.TabIndex = 21;
            this.infBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите число";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 21;
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
            // NOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathSoLution";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button razMn;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nodBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox infBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem разложениеНаМножителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулыПриведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоремаПифагораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bBox;
    }
}

