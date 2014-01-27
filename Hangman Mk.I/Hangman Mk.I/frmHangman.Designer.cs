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
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxNewWordSetName = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.richTextBoxNewWordSet = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.btnLanguageGo = new System.Windows.Forms.Button();
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPageLanguage = new System.Windows.Forms.TabPage();
			this.letterComma = new System.Windows.Forms.Button();
			this.letterDecimal = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.letterW = new System.Windows.Forms.Button();
			this.letterX = new System.Windows.Forms.Button();
			this.btnGuess = new System.Windows.Forms.Button();
			this.letterU = new System.Windows.Forms.Button();
			this.textBoxGuess = new System.Windows.Forms.TextBox();
			this.textBoxLives = new System.Windows.Forms.TextBox();
			this.letterS = new System.Windows.Forms.Button();
			this.letterR = new System.Windows.Forms.Button();
			this.letterQ = new System.Windows.Forms.Button();
			this.letterP = new System.Windows.Forms.Button();
			this.letterO = new System.Windows.Forms.Button();
			this.letterN = new System.Windows.Forms.Button();
			this.letterM = new System.Windows.Forms.Button();
			this.letterL = new System.Windows.Forms.Button();
			this.letterK = new System.Windows.Forms.Button();
			this.letterJ = new System.Windows.Forms.Button();
			this.letterI = new System.Windows.Forms.Button();
			this.letterH = new System.Windows.Forms.Button();
			this.letterG = new System.Windows.Forms.Button();
			this.letterF = new System.Windows.Forms.Button();
			this.letterE = new System.Windows.Forms.Button();
			this.letterD = new System.Windows.Forms.Button();
			this.letterB = new System.Windows.Forms.Button();
			this.letterZ = new System.Windows.Forms.Button();
			this.letterY = new System.Windows.Forms.Button();
			this.letterV = new System.Windows.Forms.Button();
			this.letterC = new System.Windows.Forms.Button();
			this.letterT = new System.Windows.Forms.Button();
			this.letterA = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblWord = new System.Windows.Forms.Label();
			this.textBoxGuessedLetters = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.tabControl1.Size = new System.Drawing.Size(311, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageHangman
			// 
			this.tabPageHangman.Controls.Add(this.label8);
			this.tabPageHangman.Controls.Add(this.textBoxNewWordSetName);
			this.tabPageHangman.Controls.Add(this.btnOpen);
			this.tabPageHangman.Controls.Add(this.label7);
			this.tabPageHangman.Controls.Add(this.label6);
			this.tabPageHangman.Controls.Add(this.richTextBoxNewWordSet);
			this.tabPageHangman.Controls.Add(this.label5);
			this.tabPageHangman.Controls.Add(this.btnSave);
			this.tabPageHangman.Controls.Add(this.splitter1);
			this.tabPageHangman.Controls.Add(this.btnLanguageGo);
			this.tabPageHangman.Controls.Add(this.comboBoxLanguage);
			this.tabPageHangman.Controls.Add(this.label2);
			this.tabPageHangman.Location = new System.Drawing.Point(4, 22);
			this.tabPageHangman.Name = "tabPageHangman";
			this.tabPageHangman.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHangman.Size = new System.Drawing.Size(303, 424);
			this.tabPageHangman.TabIndex = 1;
			this.tabPageHangman.Text = "Language";
			this.tabPageHangman.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 156);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Name";
			// 
			// textBoxNewWordSetName
			// 
			this.textBoxNewWordSetName.Location = new System.Drawing.Point(50, 153);
			this.textBoxNewWordSetName.Name = "textBoxNewWordSetName";
			this.textBoxNewWordSetName.Size = new System.Drawing.Size(247, 20);
			this.textBoxNewWordSetName.TabIndex = 10;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(141, 69);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 9;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Write each word on a new line.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(237, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Create new word set by typing new words below.";
			// 
			// richTextBoxNewWordSet
			// 
			this.richTextBoxNewWordSet.Location = new System.Drawing.Point(7, 179);
			this.richTextBoxNewWordSet.Name = "richTextBoxNewWordSet";
			this.richTextBoxNewWordSet.Size = new System.Drawing.Size(290, 210);
			this.richTextBoxNewWordSet.TabIndex = 6;
			this.richTextBoxNewWordSet.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Create New Word Set";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(222, 395);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(3, 98);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(297, 323);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// btnLanguageGo
			// 
			this.btnLanguageGo.Location = new System.Drawing.Point(222, 69);
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
			this.comboBoxLanguage.Size = new System.Drawing.Size(290, 32);
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
			this.tabPageLanguage.Controls.Add(this.letterComma);
			this.tabPageLanguage.Controls.Add(this.letterDecimal);
			this.tabPageLanguage.Controls.Add(this.label4);
			this.tabPageLanguage.Controls.Add(this.letterW);
			this.tabPageLanguage.Controls.Add(this.letterX);
			this.tabPageLanguage.Controls.Add(this.btnGuess);
			this.tabPageLanguage.Controls.Add(this.letterU);
			this.tabPageLanguage.Controls.Add(this.textBoxGuess);
			this.tabPageLanguage.Controls.Add(this.textBoxLives);
			this.tabPageLanguage.Controls.Add(this.letterS);
			this.tabPageLanguage.Controls.Add(this.letterR);
			this.tabPageLanguage.Controls.Add(this.letterQ);
			this.tabPageLanguage.Controls.Add(this.letterP);
			this.tabPageLanguage.Controls.Add(this.letterO);
			this.tabPageLanguage.Controls.Add(this.letterN);
			this.tabPageLanguage.Controls.Add(this.letterM);
			this.tabPageLanguage.Controls.Add(this.letterL);
			this.tabPageLanguage.Controls.Add(this.letterK);
			this.tabPageLanguage.Controls.Add(this.letterJ);
			this.tabPageLanguage.Controls.Add(this.letterI);
			this.tabPageLanguage.Controls.Add(this.letterH);
			this.tabPageLanguage.Controls.Add(this.letterG);
			this.tabPageLanguage.Controls.Add(this.letterF);
			this.tabPageLanguage.Controls.Add(this.letterE);
			this.tabPageLanguage.Controls.Add(this.letterD);
			this.tabPageLanguage.Controls.Add(this.letterB);
			this.tabPageLanguage.Controls.Add(this.letterZ);
			this.tabPageLanguage.Controls.Add(this.letterY);
			this.tabPageLanguage.Controls.Add(this.letterV);
			this.tabPageLanguage.Controls.Add(this.letterC);
			this.tabPageLanguage.Controls.Add(this.letterT);
			this.tabPageLanguage.Controls.Add(this.letterA);
			this.tabPageLanguage.Controls.Add(this.lblResult);
			this.tabPageLanguage.Controls.Add(this.lblWord);
			this.tabPageLanguage.Controls.Add(this.textBoxGuessedLetters);
			this.tabPageLanguage.Controls.Add(this.label3);
			this.tabPageLanguage.Controls.Add(this.pictureBoxHangman);
			this.tabPageLanguage.Location = new System.Drawing.Point(4, 22);
			this.tabPageLanguage.Name = "tabPageLanguage";
			this.tabPageLanguage.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLanguage.Size = new System.Drawing.Size(303, 424);
			this.tabPageLanguage.TabIndex = 0;
			this.tabPageLanguage.Text = "Hangman";
			this.tabPageLanguage.UseVisualStyleBackColor = true;
			// 
			// letterComma
			// 
			this.letterComma.Location = new System.Drawing.Point(234, 396);
			this.letterComma.Name = "letterComma";
			this.letterComma.Size = new System.Drawing.Size(23, 23);
			this.letterComma.TabIndex = 60;
			this.letterComma.TabStop = false;
			this.letterComma.Text = ",";
			this.letterComma.UseVisualStyleBackColor = true;
			this.letterComma.Click += new System.EventHandler(this.letterComma_Click);
			// 
			// letterDecimal
			// 
			this.letterDecimal.Location = new System.Drawing.Point(263, 396);
			this.letterDecimal.Name = "letterDecimal";
			this.letterDecimal.Size = new System.Drawing.Size(23, 23);
			this.letterDecimal.TabIndex = 59;
			this.letterDecimal.TabStop = false;
			this.letterDecimal.Text = ".";
			this.letterDecimal.UseVisualStyleBackColor = true;
			this.letterDecimal.Click += new System.EventHandler(this.letterDecimal_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(141, 286);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 20);
			this.label4.TabIndex = 58;
			this.label4.Text = "Lives";
			// 
			// letterW
			// 
			this.letterW.Location = new System.Drawing.Point(44, 338);
			this.letterW.Name = "letterW";
			this.letterW.Size = new System.Drawing.Size(23, 23);
			this.letterW.TabIndex = 57;
			this.letterW.TabStop = false;
			this.letterW.Text = "W";
			this.letterW.UseVisualStyleBackColor = true;
			this.letterW.Click += new System.EventHandler(this.letterW_Click);
			// 
			// letterX
			// 
			this.letterX.Location = new System.Drawing.Point(60, 396);
			this.letterX.Name = "letterX";
			this.letterX.Size = new System.Drawing.Size(23, 23);
			this.letterX.TabIndex = 56;
			this.letterX.TabStop = false;
			this.letterX.Text = "X";
			this.letterX.UseVisualStyleBackColor = true;
			this.letterX.Click += new System.EventHandler(this.letterX_Click);
			// 
			// btnGuess
			// 
			this.btnGuess.Location = new System.Drawing.Point(44, 289);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(75, 23);
			this.btnGuess.TabIndex = 2;
			this.btnGuess.Text = "Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// letterU
			// 
			this.letterU.Location = new System.Drawing.Point(189, 338);
			this.letterU.Name = "letterU";
			this.letterU.Size = new System.Drawing.Size(23, 23);
			this.letterU.TabIndex = 55;
			this.letterU.TabStop = false;
			this.letterU.Text = "U";
			this.letterU.UseVisualStyleBackColor = true;
			this.letterU.Click += new System.EventHandler(this.letterU_Click);
			// 
			// textBoxGuess
			// 
			this.textBoxGuess.BackColor = System.Drawing.Color.White;
			this.textBoxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxGuess.ForeColor = System.Drawing.Color.Black;
			this.textBoxGuess.Location = new System.Drawing.Point(6, 286);
			this.textBoxGuess.Name = "textBoxGuess";
			this.textBoxGuess.ReadOnly = true;
			this.textBoxGuess.Size = new System.Drawing.Size(32, 26);
			this.textBoxGuess.TabIndex = 5;
			// 
			// textBoxLives
			// 
			this.textBoxLives.BackColor = System.Drawing.Color.White;
			this.textBoxLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLives.ForeColor = System.Drawing.Color.Black;
			this.textBoxLives.Location = new System.Drawing.Point(196, 286);
			this.textBoxLives.Name = "textBoxLives";
			this.textBoxLives.ReadOnly = true;
			this.textBoxLives.Size = new System.Drawing.Size(100, 26);
			this.textBoxLives.TabIndex = 6;
			this.textBoxLives.Text = "10";
			// 
			// letterS
			// 
			this.letterS.Location = new System.Drawing.Point(51, 367);
			this.letterS.Name = "letterS";
			this.letterS.Size = new System.Drawing.Size(23, 23);
			this.letterS.TabIndex = 54;
			this.letterS.TabStop = false;
			this.letterS.Text = "S";
			this.letterS.UseVisualStyleBackColor = true;
			this.letterS.Click += new System.EventHandler(this.letterS_Click);
			// 
			// letterR
			// 
			this.letterR.Location = new System.Drawing.Point(102, 338);
			this.letterR.Name = "letterR";
			this.letterR.Size = new System.Drawing.Size(23, 23);
			this.letterR.TabIndex = 53;
			this.letterR.TabStop = false;
			this.letterR.Text = "R";
			this.letterR.UseVisualStyleBackColor = true;
			this.letterR.Click += new System.EventHandler(this.letterR_Click);
			// 
			// letterQ
			// 
			this.letterQ.Location = new System.Drawing.Point(15, 338);
			this.letterQ.Name = "letterQ";
			this.letterQ.Size = new System.Drawing.Size(23, 23);
			this.letterQ.TabIndex = 52;
			this.letterQ.TabStop = false;
			this.letterQ.Text = "Q";
			this.letterQ.UseVisualStyleBackColor = true;
			this.letterQ.Click += new System.EventHandler(this.letterQ_Click);
			// 
			// letterP
			// 
			this.letterP.Location = new System.Drawing.Point(277, 338);
			this.letterP.Name = "letterP";
			this.letterP.Size = new System.Drawing.Size(23, 23);
			this.letterP.TabIndex = 51;
			this.letterP.TabStop = false;
			this.letterP.Text = "P";
			this.letterP.UseVisualStyleBackColor = true;
			this.letterP.Click += new System.EventHandler(this.letterP_Click);
			// 
			// letterO
			// 
			this.letterO.Location = new System.Drawing.Point(248, 338);
			this.letterO.Name = "letterO";
			this.letterO.Size = new System.Drawing.Size(23, 23);
			this.letterO.TabIndex = 50;
			this.letterO.TabStop = false;
			this.letterO.Text = "O";
			this.letterO.UseVisualStyleBackColor = true;
			this.letterO.Click += new System.EventHandler(this.letterO_Click);
			// 
			// letterN
			// 
			this.letterN.Location = new System.Drawing.Point(176, 396);
			this.letterN.Name = "letterN";
			this.letterN.Size = new System.Drawing.Size(23, 23);
			this.letterN.TabIndex = 49;
			this.letterN.TabStop = false;
			this.letterN.Text = "N";
			this.letterN.UseVisualStyleBackColor = true;
			this.letterN.Click += new System.EventHandler(this.letterN_Click);
			// 
			// letterM
			// 
			this.letterM.Location = new System.Drawing.Point(205, 396);
			this.letterM.Name = "letterM";
			this.letterM.Size = new System.Drawing.Size(23, 23);
			this.letterM.TabIndex = 48;
			this.letterM.TabStop = false;
			this.letterM.Text = "M";
			this.letterM.UseVisualStyleBackColor = true;
			this.letterM.Click += new System.EventHandler(this.letterM_Click);
			// 
			// letterL
			// 
			this.letterL.Location = new System.Drawing.Point(254, 367);
			this.letterL.Name = "letterL";
			this.letterL.Size = new System.Drawing.Size(23, 23);
			this.letterL.TabIndex = 47;
			this.letterL.TabStop = false;
			this.letterL.Text = "L";
			this.letterL.UseVisualStyleBackColor = true;
			this.letterL.Click += new System.EventHandler(this.letterL_Click);
			// 
			// letterK
			// 
			this.letterK.Location = new System.Drawing.Point(225, 367);
			this.letterK.Name = "letterK";
			this.letterK.Size = new System.Drawing.Size(23, 23);
			this.letterK.TabIndex = 46;
			this.letterK.TabStop = false;
			this.letterK.Text = "K";
			this.letterK.UseVisualStyleBackColor = true;
			this.letterK.Click += new System.EventHandler(this.letterK_Click);
			// 
			// letterJ
			// 
			this.letterJ.Location = new System.Drawing.Point(196, 367);
			this.letterJ.Name = "letterJ";
			this.letterJ.Size = new System.Drawing.Size(23, 23);
			this.letterJ.TabIndex = 45;
			this.letterJ.TabStop = false;
			this.letterJ.Text = "J";
			this.letterJ.UseVisualStyleBackColor = true;
			this.letterJ.Click += new System.EventHandler(this.letterJ_Click);
			// 
			// letterI
			// 
			this.letterI.Location = new System.Drawing.Point(219, 338);
			this.letterI.Name = "letterI";
			this.letterI.Size = new System.Drawing.Size(23, 23);
			this.letterI.TabIndex = 44;
			this.letterI.TabStop = false;
			this.letterI.Text = "I";
			this.letterI.UseVisualStyleBackColor = true;
			this.letterI.Click += new System.EventHandler(this.letterI_Click);
			// 
			// letterH
			// 
			this.letterH.Location = new System.Drawing.Point(167, 367);
			this.letterH.Name = "letterH";
			this.letterH.Size = new System.Drawing.Size(23, 23);
			this.letterH.TabIndex = 43;
			this.letterH.TabStop = false;
			this.letterH.Text = "H";
			this.letterH.UseVisualStyleBackColor = true;
			this.letterH.Click += new System.EventHandler(this.letterH_Click);
			// 
			// letterG
			// 
			this.letterG.Location = new System.Drawing.Point(138, 367);
			this.letterG.Name = "letterG";
			this.letterG.Size = new System.Drawing.Size(23, 23);
			this.letterG.TabIndex = 42;
			this.letterG.TabStop = false;
			this.letterG.Text = "G";
			this.letterG.UseVisualStyleBackColor = true;
			this.letterG.Click += new System.EventHandler(this.letterG_Click);
			// 
			// letterF
			// 
			this.letterF.Location = new System.Drawing.Point(109, 367);
			this.letterF.Name = "letterF";
			this.letterF.Size = new System.Drawing.Size(23, 23);
			this.letterF.TabIndex = 41;
			this.letterF.TabStop = false;
			this.letterF.Text = "F";
			this.letterF.UseVisualStyleBackColor = true;
			this.letterF.Click += new System.EventHandler(this.letterF_Click);
			// 
			// letterE
			// 
			this.letterE.Location = new System.Drawing.Point(73, 338);
			this.letterE.Name = "letterE";
			this.letterE.Size = new System.Drawing.Size(23, 23);
			this.letterE.TabIndex = 40;
			this.letterE.TabStop = false;
			this.letterE.Text = "E";
			this.letterE.UseVisualStyleBackColor = true;
			this.letterE.Click += new System.EventHandler(this.letterE_Click);
			// 
			// letterD
			// 
			this.letterD.Location = new System.Drawing.Point(80, 367);
			this.letterD.Name = "letterD";
			this.letterD.Size = new System.Drawing.Size(23, 23);
			this.letterD.TabIndex = 39;
			this.letterD.TabStop = false;
			this.letterD.Text = "D";
			this.letterD.UseVisualStyleBackColor = true;
			this.letterD.Click += new System.EventHandler(this.letterD_Click);
			// 
			// letterB
			// 
			this.letterB.Location = new System.Drawing.Point(147, 396);
			this.letterB.Name = "letterB";
			this.letterB.Size = new System.Drawing.Size(23, 23);
			this.letterB.TabIndex = 38;
			this.letterB.TabStop = false;
			this.letterB.Text = "B";
			this.letterB.UseVisualStyleBackColor = true;
			this.letterB.Click += new System.EventHandler(this.letterB_Click);
			// 
			// letterZ
			// 
			this.letterZ.Location = new System.Drawing.Point(31, 396);
			this.letterZ.Name = "letterZ";
			this.letterZ.Size = new System.Drawing.Size(23, 23);
			this.letterZ.TabIndex = 37;
			this.letterZ.TabStop = false;
			this.letterZ.Text = "Z";
			this.letterZ.UseVisualStyleBackColor = true;
			this.letterZ.Click += new System.EventHandler(this.letterZ_Click);
			// 
			// letterY
			// 
			this.letterY.Location = new System.Drawing.Point(160, 338);
			this.letterY.Name = "letterY";
			this.letterY.Size = new System.Drawing.Size(23, 23);
			this.letterY.TabIndex = 36;
			this.letterY.TabStop = false;
			this.letterY.Text = "Y";
			this.letterY.UseVisualStyleBackColor = true;
			this.letterY.Click += new System.EventHandler(this.letterY_Click);
			// 
			// letterV
			// 
			this.letterV.Location = new System.Drawing.Point(118, 396);
			this.letterV.Name = "letterV";
			this.letterV.Size = new System.Drawing.Size(23, 23);
			this.letterV.TabIndex = 35;
			this.letterV.TabStop = false;
			this.letterV.Text = "V";
			this.letterV.UseVisualStyleBackColor = true;
			this.letterV.Click += new System.EventHandler(this.letterV_Click);
			// 
			// letterC
			// 
			this.letterC.Location = new System.Drawing.Point(89, 396);
			this.letterC.Name = "letterC";
			this.letterC.Size = new System.Drawing.Size(23, 23);
			this.letterC.TabIndex = 34;
			this.letterC.TabStop = false;
			this.letterC.Text = "C";
			this.letterC.UseVisualStyleBackColor = true;
			this.letterC.Click += new System.EventHandler(this.letterC_Click);
			// 
			// letterT
			// 
			this.letterT.Location = new System.Drawing.Point(131, 338);
			this.letterT.Name = "letterT";
			this.letterT.Size = new System.Drawing.Size(23, 23);
			this.letterT.TabIndex = 33;
			this.letterT.TabStop = false;
			this.letterT.Text = "T";
			this.letterT.UseVisualStyleBackColor = true;
			this.letterT.Click += new System.EventHandler(this.letterT_Click);
			// 
			// letterA
			// 
			this.letterA.Location = new System.Drawing.Point(22, 367);
			this.letterA.Name = "letterA";
			this.letterA.Size = new System.Drawing.Size(23, 23);
			this.letterA.TabIndex = 32;
			this.letterA.TabStop = false;
			this.letterA.Text = "A";
			this.letterA.UseVisualStyleBackColor = true;
			this.letterA.Click += new System.EventHandler(this.letterA_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(6, 315);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(92, 20);
			this.lblResult.TabIndex = 9;
			this.lblResult.Text = "Placeholder";
			// 
			// lblWord
			// 
			this.lblWord.AutoSize = true;
			this.lblWord.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWord.Location = new System.Drawing.Point(11, 3);
			this.lblWord.Name = "lblWord";
			this.lblWord.Size = new System.Drawing.Size(189, 30);
			this.lblWord.TabIndex = 8;
			this.lblWord.Text = "Placeholder";
			// 
			// textBoxGuessedLetters
			// 
			this.textBoxGuessedLetters.BackColor = System.Drawing.Color.White;
			this.textBoxGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxGuessedLetters.ForeColor = System.Drawing.Color.Black;
			this.textBoxGuessedLetters.Location = new System.Drawing.Point(145, 244);
			this.textBoxGuessedLetters.Name = "textBoxGuessedLetters";
			this.textBoxGuessedLetters.ReadOnly = true;
			this.textBoxGuessedLetters.Size = new System.Drawing.Size(151, 26);
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
			// pictureBoxHangman
			// 
			this.pictureBoxHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxHangman.Image = global::Hangman_Mk.I.Properties.Resources.hang0;
			this.pictureBoxHangman.Location = new System.Drawing.Point(7, 45);
			this.pictureBoxHangman.Name = "pictureBoxHangman";
			this.pictureBoxHangman.Size = new System.Drawing.Size(289, 193);
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
			// frmHangman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 505);
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
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button letterW;
		private System.Windows.Forms.Button letterX;
		private System.Windows.Forms.Button letterU;
		private System.Windows.Forms.Button letterS;
		private System.Windows.Forms.Button letterR;
		private System.Windows.Forms.Button letterQ;
		private System.Windows.Forms.Button letterP;
		private System.Windows.Forms.Button letterO;
		private System.Windows.Forms.Button letterN;
		private System.Windows.Forms.Button letterM;
		private System.Windows.Forms.Button letterL;
		private System.Windows.Forms.Button letterK;
		private System.Windows.Forms.Button letterJ;
		private System.Windows.Forms.Button letterI;
		private System.Windows.Forms.Button letterH;
		private System.Windows.Forms.Button letterG;
		private System.Windows.Forms.Button letterF;
		private System.Windows.Forms.Button letterE;
		private System.Windows.Forms.Button letterD;
		private System.Windows.Forms.Button letterB;
		private System.Windows.Forms.Button letterZ;
		private System.Windows.Forms.Button letterY;
		private System.Windows.Forms.Button letterV;
		private System.Windows.Forms.Button letterC;
		private System.Windows.Forms.Button letterT;
		private System.Windows.Forms.Button letterA;
		private System.Windows.Forms.Button letterComma;
		private System.Windows.Forms.Button letterDecimal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBoxNewWordSet;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxNewWordSetName;

    }
}

