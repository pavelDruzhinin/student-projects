namespace MathSoLution
{
    partial class Korni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korni));
            this.Calc = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.infBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(187, 61);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 4;
            this.Calc.Text = "Вычислить";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(7, 32);
            this.aBox.MaxLength = 3;
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(36, 20);
            this.aBox.TabIndex = 1;
            this.aBox.Text = "0";
            this.aBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.aBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(87, 31);
            this.bBox.MaxLength = 3;
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(36, 20);
            this.bBox.TabIndex = 2;
            this.bBox.Text = "0";
            this.bBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.bBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(165, 31);
            this.cBox.MaxLength = 3;
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(36, 20);
            this.cBox.TabIndex = 3;
            this.cBox.Text = "0";
            this.cBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.cBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // infBox
            // 
            this.infBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infBox.Location = new System.Drawing.Point(6, 90);
            this.infBox.Multiline = true;
            this.infBox.Name = "infBox";
            this.infBox.ReadOnly = true;
            this.infBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infBox.Size = new System.Drawing.Size(256, 143);
            this.infBox.TabIndex = 5;
            this.infBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Решение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(129, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(149, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "b";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "c";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(59, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Calc);
            this.groupBox1.Controls.Add(this.aBox);
            this.groupBox1.Controls.Add(this.infBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 239);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Квадратное уравнение";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 19;
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
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // главнаяToolStripMenuItem1
            // 
            this.главнаяToolStripMenuItem1.Name = "главнаяToolStripMenuItem1";
            this.главнаяToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.главнаяToolStripMenuItem1.Text = "Главная";
            // 
            // разложениеНаМножителиToolStripMenuItem
            // 
            this.разложениеНаМножителиToolStripMenuItem.Name = "разложениеНаМножителиToolStripMenuItem";
            this.разложениеНаМножителиToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.разложениеНаМножителиToolStripMenuItem.Text = "Разложение на множители";
            // 
            // формулыПриведенияToolStripMenuItem
            // 
            this.формулыПриведенияToolStripMenuItem.Name = "формулыПриведенияToolStripMenuItem";
            this.формулыПриведенияToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.формулыПриведенияToolStripMenuItem.Text = "Формулы приведения";
            // 
            // теоремаПифагораToolStripMenuItem
            // 
            this.теоремаПифагораToolStripMenuItem.Name = "теоремаПифагораToolStripMenuItem";
            this.теоремаПифагораToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.теоремаПифагораToolStripMenuItem.Text = "Теорема Пифагора";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // Korni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Korni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathSoLution";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.TextBox infBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem разложениеНаМножителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулыПриведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоремаПифагораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

