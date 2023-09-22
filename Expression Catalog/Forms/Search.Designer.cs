namespace Cursach
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnSearch_Click = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbSearchSource = new System.Windows.Forms.ComboBox();
            this.cmbSearchAuthor = new System.Windows.Forms.ComboBox();
            this.tbSearchTheme = new System.Windows.Forms.TextBox();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnSearch_Click);
            this.gbMain.Controls.Add(this.checkBox3);
            this.gbMain.Controls.Add(this.checkBox2);
            this.gbMain.Controls.Add(this.checkBox1);
            this.gbMain.Controls.Add(this.cmbSearchSource);
            this.gbMain.Controls.Add(this.cmbSearchAuthor);
            this.gbMain.Controls.Add(this.tbSearchTheme);
            this.gbMain.Location = new System.Drawing.Point(63, 38);
            this.gbMain.Margin = new System.Windows.Forms.Padding(2);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(2);
            this.gbMain.Size = new System.Drawing.Size(168, 205);
            this.gbMain.TabIndex = 8;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Основные данные";
            this.gbMain.Enter += new System.EventHandler(this.gbMain_Enter);
            // 
            // btnSearch_Click
            // 
            this.btnSearch_Click.Location = new System.Drawing.Point(40, 173);
            this.btnSearch_Click.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch_Click.Name = "btnSearch_Click";
            this.btnSearch_Click.Size = new System.Drawing.Size(77, 28);
            this.btnSearch_Click.TabIndex = 13;
            this.btnSearch_Click.Text = "Применить";
            this.btnSearch_Click.UseVisualStyleBackColor = true;
            this.btnSearch_Click.Click += new System.EventHandler(this.btnSearch_Click_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 118);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Тема";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Источник";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Автор";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbSearchSource
            // 
            this.cmbSearchSource.FormattingEnabled = true;
            this.cmbSearchSource.Location = new System.Drawing.Point(28, 95);
            this.cmbSearchSource.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchSource.Name = "cmbSearchSource";
            this.cmbSearchSource.Size = new System.Drawing.Size(102, 21);
            this.cmbSearchSource.TabIndex = 11;
            // 
            // cmbSearchAuthor
            // 
            this.cmbSearchAuthor.FormattingEnabled = true;
            this.cmbSearchAuthor.Location = new System.Drawing.Point(28, 50);
            this.cmbSearchAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchAuthor.Name = "cmbSearchAuthor";
            this.cmbSearchAuthor.Size = new System.Drawing.Size(102, 21);
            this.cmbSearchAuthor.TabIndex = 11;
            // 
            // tbSearchTheme
            // 
            this.tbSearchTheme.Location = new System.Drawing.Point(28, 140);
            this.tbSearchTheme.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchTheme.Name = "tbSearchTheme";
            this.tbSearchTheme.Size = new System.Drawing.Size(102, 20);
            this.tbSearchTheme.TabIndex = 10;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 267);
            this.Controls.Add(this.gbMain);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск по критериям";
            this.Load += new System.EventHandler(this.Search_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        public System.Windows.Forms.ComboBox cmbSearchSource;
        public System.Windows.Forms.ComboBox cmbSearchAuthor;
        public System.Windows.Forms.TextBox tbSearchTheme;
        private System.Windows.Forms.Button btnSearch_Click;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}