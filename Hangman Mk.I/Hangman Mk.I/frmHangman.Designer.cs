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
			this.tabPageHangman = new System.Windows.Forms.TabPage();
			this.btnLanguageGo = new System.Windows.Forms.Button();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPageLanguage = new System.Windows.Forms.TabPage();
			this.lblWord = new System.Windows.Forms.Label();
			this.lblDashes = new System.Windows.Forms.Label();
			this.textBoxLives = new System.Windows.Forms.TextBox();
			this.textBoxGuess = new System.Windows.Forms.TextBox();
			this.textBoxGuessedLetters = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuess = new System.Windows.Forms.Button();
			this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageHangman.SuspendLayout();
			this.tabPageLanguage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
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
			// tabPageHangman
			// 
			this.tabPageHangman.Controls.Add(this.btnLanguageGo);
			this.tabPageHangman.Controls.Add(this.comboBoxLanguage);
			this.tabPageHangman.Controls.Add(this.label2);
			this.tabPageHangman.Location = new System.Drawing.Point(4, 22);
			this.tabPageHangman.Name = "tabPageHangman";
			this.tabPageHangman.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHangman.Size = new System.Drawing.Size(351, 431);
			this.tabPageHangman.TabIndex = 1;
			this.tabPageHangman.Text = "Language";
			this.tabPageHangman.UseVisualStyleBackColor = true;
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
			// tabPageLanguage
			// 
			this.tabPageLanguage.Controls.Add(this.lblResult);
			this.tabPageLanguage.Controls.Add(this.lblWord);
			this.tabPageLanguage.Controls.Add(this.lblDashes);
			this.tabPageLanguage.Controls.Add(this.textBoxLives);
			this.tabPageLanguage.Controls.Add(this.textBoxGuess);
			this.tabPageLanguage.Controls.Add(this.textBoxGuessedLetters);
			this.tabPageLanguage.Controls.Add(this.label3);
			this.tabPageLanguage.Controls.Add(this.btnGuess);
			this.tabPageLanguage.Controls.Add(this.pictureBoxHangman);
			this.tabPageLanguage.Location = new System.Drawing.Point(4, 22);
			this.tabPageLanguage.Name = "tabPageLanguage";
			this.tabPageLanguage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLanguage.Size = new System.Drawing.Size(351, 431);
			this.tabPageLanguage.TabIndex = 0;
			this.tabPageLanguage.Text = "Hangman";
			this.tabPageLanguage.UseVisualStyleBackColor = true;
			// 
			// lblWord
			// 
			this.lblWord.AutoSize = true;
			this.lblWord.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWord.Location = new System.Drawing.Point(6, 3);
			this.lblWord.Name = "lblWord";
			this.lblWord.Size = new System.Drawing.Size(0, 23);
			this.lblWord.TabIndex = 8;
			// 
			// lblDashes
			// 
			this.lblDashes.AutoSize = true;
			this.lblDashes.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDashes.Location = new System.Drawing.Point(6, 6);
			this.lblDashes.Name = "lblDashes";
			this.lblDashes.Size = new System.Drawing.Size(0, 23);
			this.lblDashes.TabIndex = 7;
			// 
			// textBoxLives
			// 
			this.textBoxLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLives.Location = new System.Drawing.Point(171, 288);
			this.textBoxLives.Name = "textBoxLives";
			this.textBoxLives.Size = new System.Drawing.Size(100, 26);
			this.textBoxLives.TabIndex = 6;
			this.textBoxLives.Text = "10";
			// 
			// textBoxGuess
			// 
			this.textBoxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxGuess.Location = new System.Drawing.Point(11, 288);
			this.textBoxGuess.Name = "textBoxGuess";
			this.textBoxGuess.Size = new System.Drawing.Size(32, 26);
			this.textBoxGuess.TabIndex = 5;
			// 
			// textBoxGuessedLetters
			// 
			this.textBoxGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxGuessedLetters.Location = new System.Drawing.Point(145, 244);
			this.textBoxGuessedLetters.Name = "textBoxGuessedLetters";
			this.textBoxGuessedLetters.Size = new System.Drawing.Size(199, 26);
			this.textBoxGuessedLetters.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 250);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Guessed Letters:";
			// 
			// btnGuess
			// 
			this.btnGuess.Location = new System.Drawing.Point(63, 288);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(75, 23);
			this.btnGuess.TabIndex = 2;
			this.btnGuess.Text = "Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// pictureBoxHangman
			// 
			this.pictureBoxHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxHangman.Image = global::Hangman_Mk.I.Properties.Resources.hang0;
			this.pictureBoxHangman.Location = new System.Drawing.Point(7, 45);
			this.pictureBoxHangman.Name = "pictureBoxHangman";
			this.pictureBoxHangman.Size = new System.Drawing.Size(337, 193);
			this.pictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxHangman.TabIndex = 1;
			this.pictureBoxHangman.TabStop = false;
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
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(11, 321);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 20);
			this.lblResult.TabIndex = 9;
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
			this.tabPageHangman.ResumeLayout(false);
			this.tabPageHangman.PerformLayout();
			this.tabPageLanguage.ResumeLayout(false);
			this.tabPageLanguage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.TextBox textBoxGuessedLetters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.TextBox textBoxLives;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblDashes;
		private System.Windows.Forms.Label lblResult;

    }
}

