namespace MathSoLution
{
    partial class Pifagor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pifagor));
            this.Addit = new System.Windows.Forms.Button();
            this.aText = new System.Windows.Forms.TextBox();
            this.bText = new System.Windows.Forms.TextBox();
            this.cText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.korText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.korText2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bText2 = new System.Windows.Forms.TextBox();
            this.aText2 = new System.Windows.Forms.TextBox();
            this.cText2 = new System.Windows.Forms.TextBox();
            this.Subtr = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разложениеНаМножителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулыПриведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоремаПифагораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Addit
            // 
            this.Addit.Location = new System.Drawing.Point(178, 87);
            this.Addit.Name = "Addit";
            this.Addit.Size = new System.Drawing.Size(75, 23);
            this.Addit.TabIndex = 3;
            this.Addit.Text = "Вычислить";
            this.Addit.UseVisualStyleBackColor = true;
            this.Addit.Click += new System.EventHandler(this.Addit_Click);
            // 
            // aText
            // 
            this.aText.Location = new System.Drawing.Point(3, 34);
            this.aText.MaxLength = 5;
            this.aText.Name = "aText";
            this.aText.Size = new System.Drawing.Size(64, 20);
            this.aText.TabIndex = 1;
            this.aText.Text = "0";
            this.aText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.aText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // bText
            // 
            this.bText.Location = new System.Drawing.Point(92, 34);
            this.bText.MaxLength = 5;
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(64, 20);
            this.bText.TabIndex = 2;
            this.bText.Text = "0";
            this.bText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.bText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // cText
            // 
            this.cText.Location = new System.Drawing.Point(182, 34);
            this.cText.Name = "cText";
            this.cText.ReadOnly = true;
            this.cText.Size = new System.Drawing.Size(71, 20);
            this.cText.TabIndex = 11;
            this.cText.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Катет a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Катет b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Гипотенуза c";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Число под корнем";
            // 
            // korText
            // 
            this.korText.Location = new System.Drawing.Point(182, 61);
            this.korText.Name = "korText";
            this.korText.ReadOnly = true;
            this.korText.Size = new System.Drawing.Size(71, 20);
            this.korText.TabIndex = 10;
            this.korText.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "=";
            // 
            // korText2
            // 
            this.korText2.Location = new System.Drawing.Point(182, 59);
            this.korText2.Name = "korText2";
            this.korText2.ReadOnly = true;
            this.korText2.Size = new System.Drawing.Size(71, 20);
            this.korText2.TabIndex = 18;
            this.korText2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Число под корнем";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "=";
            // 
            // bText2
            // 
            this.bText2.Location = new System.Drawing.Point(182, 32);
            this.bText2.Name = "bText2";
            this.bText2.ReadOnly = true;
            this.bText2.Size = new System.Drawing.Size(71, 20);
            this.bText2.TabIndex = 14;
            this.bText2.TabStop = false;
            // 
            // aText2
            // 
            this.aText2.Location = new System.Drawing.Point(92, 32);
            this.aText2.MaxLength = 5;
            this.aText2.Name = "aText2";
            this.aText2.Size = new System.Drawing.Size(64, 20);
            this.aText2.TabIndex = 5;
            this.aText2.Text = "0";
            this.aText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aText2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.aText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // cText2
            // 
            this.cText2.Location = new System.Drawing.Point(3, 32);
            this.cText2.MaxLength = 5;
            this.cText2.Name = "cText2";
            this.cText2.Size = new System.Drawing.Size(64, 20);
            this.cText2.TabIndex = 4;
            this.cText2.Text = "0";
            this.cText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cText2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Univ_MouseClick);
            this.cText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Univ_Press);
            // 
            // Subtr
            // 
            this.Subtr.Location = new System.Drawing.Point(178, 85);
            this.Subtr.Name = "Subtr";
            this.Subtr.Size = new System.Drawing.Size(75, 23);
            this.Subtr.TabIndex = 6;
            this.Subtr.Text = "Вычислить";
            this.Subtr.UseVisualStyleBackColor = true;
            this.Subtr.Click += new System.EventHandler(this.Substr_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Гипотенуза c";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Катет a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(194, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Катет b";
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(4, 85);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 7;
            this.Quit.Text = "Закрыть";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aText);
            this.groupBox1.Controls.Add(this.Addit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bText);
            this.groupBox1.Controls.Add(this.korText);
            this.groupBox1.Controls.Add(this.cText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 114);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вычиcлить гипотенузу";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cText2);
            this.groupBox2.Controls.Add(this.korText2);
            this.groupBox2.Controls.Add(this.Quit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.aText2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Subtr);
            this.groupBox2.Controls.Add(this.bText2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 119);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вычислить катет";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 28;
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
            // Pifagor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pifagor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathSoLution";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pifagor_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addit;
        private System.Windows.Forms.TextBox aText;
        private System.Windows.Forms.TextBox bText;
        private System.Windows.Forms.TextBox cText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox korText2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bText2;
        private System.Windows.Forms.TextBox aText2;
        private System.Windows.Forms.TextBox cText2;
        private System.Windows.Forms.Button Subtr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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

