namespace Hangman_Mk.I
{
    partial class frmHangman
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLanguage = new System.Windows.Forms.TabPage();
            this.tabPageHangman = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.btnLanguageGo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageLanguage.SuspendLayout();
            this.tabPageHangman.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHangman);
            this.tabControl1.Controls.Add(this.tabPageLanguage);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLanguage
            // 
            this.tabPageLanguage.Controls.Add(this.textBox1);
            this.tabPageLanguage.Location = new System.Drawing.Point(4, 22);
            this.tabPageLanguage.Name = "tabPageLanguage";
            this.tabPageLanguage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageLanguage.Size = new System.Drawing.Size(351, 431);
            this.tabPageLanguage.TabIndex = 0;
            this.tabPageLanguage.Text = "Hangman";
            this.tabPageLanguage.UseVisualStyleBackColor = true;
            // 
            // tabPageHangman
            // 
            this.tabPageHangman.Controls.Add(this.btnLanguageGo);
            this.tabPageHangman.Controls.Add(this.comboBoxLanguage);
            this.tabPageHangman.Controls.Add(this.label2);
            this.tabPageHangman.Location = new System.Drawing.Point(4, 22);
            this.tabPageHangman.Name = "tabPageHangman";
            this.tabPageHangman.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageHangman.Size = new System.Drawing.Size(351, 431);
            this.tabPageHangman.TabIndex = 1;
            this.tabPageHangman.Text = "Language";
            this.tabPageHangman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangman";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Afrikaans",
            "Belarusian",
            "Bulgarian",
            "Catalan",
            "Croatian",
            "Czech",
            "Danish",
            "Debug",
            "English",
            "English (US)",
            "French",
            "German",
            "Greek",
            "Hungarian",
            "Italian",
            "Latin",
            "Mongolian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swedish",
            "Ukrainian"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(7, 31);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(338, 32);
            this.comboBoxLanguage.TabIndex = 1;
            // 
            // btnLanguageGo
            // 
            this.btnLanguageGo.Location = new System.Drawing.Point(270, 70);
            this.btnLanguageGo.Name = "btnLanguageGo";
            this.btnLanguageGo.Size = new System.Drawing.Size(75, 23);
            this.btnLanguageGo.TabIndex = 2;
            this.btnLanguageGo.Text = "Go";
            this.btnLanguageGo.UseVisualStyleBackColor = true;
            this.btnLanguageGo.Click += new System.EventHandler(this.btnLanguageGo_Click);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLanguage.ResumeLayout(false);
            this.tabPageLanguage.PerformLayout();
            this.tabPageHangman.ResumeLayout(false);
            this.tabPageHangman.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHangman;
        private System.Windows.Forms.Button btnLanguageGo;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageLanguage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

    }
}

