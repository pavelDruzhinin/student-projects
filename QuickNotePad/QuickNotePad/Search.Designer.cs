namespace QuickNotePad
{
    partial class Search
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
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.cbMatchWhole = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(12, 16);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(192, 20);
            this.txtfind.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(235, 13);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(12, 50);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(74, 30);
            this.cbMatchCase.TabIndex = 3;
            this.cbMatchCase.Text = "С учетом \r\nрегистра";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cbMatchWhole
            // 
            this.cbMatchWhole.AutoSize = true;
            this.cbMatchWhole.Location = new System.Drawing.Point(101, 53);
            this.cbMatchWhole.Name = "cbMatchWhole";
            this.cbMatchWhole.Size = new System.Drawing.Size(103, 17);
            this.cbMatchWhole.TabIndex = 4;
            this.cbMatchWhole.Text = "Целым словом";
            this.cbMatchWhole.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 88);
            this.Controls.Add(this.cbMatchWhole);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtfind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.CheckBox cbMatchWhole;
    }
}