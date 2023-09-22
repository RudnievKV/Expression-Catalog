namespace Cursach
{
    partial class AddorChange
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.btnAddChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Источник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тема";
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(145, 12);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(126, 20);
            this.txtExp.TabIndex = 5;
            this.txtExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExp_KeyPress);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(145, 51);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(126, 20);
            this.txtType.TabIndex = 6;
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(145, 91);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(126, 20);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_KeyPress);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(145, 133);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(126, 20);
            this.txtSource.TabIndex = 8;
            this.txtSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSource_KeyPress);
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(145, 170);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(126, 20);
            this.txtTheme.TabIndex = 9;
            this.txtTheme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTheme_KeyPress);
            // 
            // btnAddChange
            // 
            this.btnAddChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddChange.Location = new System.Drawing.Point(74, 210);
            this.btnAddChange.Name = "btnAddChange";
            this.btnAddChange.Size = new System.Drawing.Size(125, 28);
            this.btnAddChange.TabIndex = 10;
            this.btnAddChange.Text = "Добавить";
            this.btnAddChange.UseVisualStyleBackColor = true;
            this.btnAddChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddorChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 250);
            this.Controls.Add(this.btnAddChange);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddorChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Button btnAddChange;
    }
}