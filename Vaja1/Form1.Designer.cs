namespace Vaja1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelPrejemnik = new Label();
            labelKopijacc = new Label();
            labelSkritaKopijaBcc = new Label();
            labelZadeva = new Label();
            labelSMTPStreznik = new Label();
            labelUporabniskoIme = new Label();
            labelFormat = new Label();
            labelPrioriteta = new Label();
            labelGeslo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            radioButtonText = new RadioButton();
            radioButtonHTML = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioButtonObicajna = new RadioButton();
            radioButtonSrednja = new RadioButton();
            radioButtonVisoka = new RadioButton();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textZadeva = new TextBox();
            textPrejemnik = new TextBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textSporocilo = new TextBox();
            buttonPoslji = new Button();
            checkBoxZapomni = new CheckBox();
            menuStrip1 = new MenuStrip();
            seznamPrejemnikovToolStripMenuItem = new ToolStripMenuItem();
            seznamPoslanihSporočilToolStripMenuItem = new ToolStripMenuItem();
            novoSporočiloToolStripMenuItem = new ToolStripMenuItem();
            textBox2 = new TextBox();
            label2 = new Label();
            textPosiljatelj = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Khaki;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(labelPrejemnik, 0, 2);
            tableLayoutPanel1.Controls.Add(labelKopijacc, 0, 3);
            tableLayoutPanel1.Controls.Add(labelSkritaKopijaBcc, 0, 4);
            tableLayoutPanel1.Controls.Add(labelZadeva, 0, 5);
            tableLayoutPanel1.Controls.Add(labelSMTPStreznik, 0, 6);
            tableLayoutPanel1.Controls.Add(labelUporabniskoIme, 0, 8);
            tableLayoutPanel1.Controls.Add(labelFormat, 0, 7);
            tableLayoutPanel1.Controls.Add(labelPrioriteta, 2, 7);
            tableLayoutPanel1.Controls.Add(labelGeslo, 2, 8);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 9);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(textZadeva, 1, 5);
            tableLayoutPanel1.Controls.Add(textPrejemnik, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 8);
            tableLayoutPanel1.Controls.Add(textBox5, 3, 8);
            tableLayoutPanel1.Controls.Add(textSporocilo, 1, 9);
            tableLayoutPanel1.Controls.Add(buttonPoslji, 3, 10);
            tableLayoutPanel1.Controls.Add(checkBoxZapomni, 0, 10);
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textPosiljatelj, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(902, 487);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // labelPrejemnik
            // 
            labelPrejemnik.Anchor = AnchorStyles.Right;
            labelPrejemnik.AutoSize = true;
            labelPrejemnik.Location = new Point(63, 80);
            labelPrejemnik.Name = "labelPrejemnik";
            labelPrejemnik.Size = new Size(74, 20);
            labelPrejemnik.TabIndex = 1;
            labelPrejemnik.Text = "Prejemnik";
            // 
            // labelKopijacc
            // 
            labelKopijacc.Anchor = AnchorStyles.Right;
            labelKopijacc.AutoSize = true;
            labelKopijacc.Location = new Point(57, 116);
            labelKopijacc.Name = "labelKopijacc";
            labelKopijacc.Size = new Size(80, 20);
            labelKopijacc.TabIndex = 2;
            labelKopijacc.Text = "Kopija (cc)";
            // 
            // labelSkritaKopijaBcc
            // 
            labelSkritaKopijaBcc.Anchor = AnchorStyles.Right;
            labelSkritaKopijaBcc.AutoSize = true;
            labelSkritaKopijaBcc.Location = new Point(9, 152);
            labelSkritaKopijaBcc.Name = "labelSkritaKopijaBcc";
            labelSkritaKopijaBcc.Size = new Size(128, 20);
            labelSkritaKopijaBcc.TabIndex = 3;
            labelSkritaKopijaBcc.Text = "Skrita kopija (Bcc)";
            // 
            // labelZadeva
            // 
            labelZadeva.Anchor = AnchorStyles.Right;
            labelZadeva.AutoSize = true;
            labelZadeva.Location = new Point(79, 188);
            labelZadeva.Name = "labelZadeva";
            labelZadeva.Size = new Size(58, 20);
            labelZadeva.TabIndex = 4;
            labelZadeva.Text = "Zadeva";
            // 
            // labelSMTPStreznik
            // 
            labelSMTPStreznik.Anchor = AnchorStyles.Right;
            labelSMTPStreznik.AutoSize = true;
            labelSMTPStreznik.Location = new Point(35, 224);
            labelSMTPStreznik.Name = "labelSMTPStreznik";
            labelSMTPStreznik.Size = new Size(102, 20);
            labelSMTPStreznik.TabIndex = 5;
            labelSMTPStreznik.Text = "SMTP Strežnik";
            // 
            // labelUporabniskoIme
            // 
            labelUporabniskoIme.Anchor = AnchorStyles.Right;
            labelUporabniskoIme.AutoSize = true;
            labelUporabniskoIme.Location = new Point(15, 296);
            labelUporabniskoIme.Name = "labelUporabniskoIme";
            labelUporabniskoIme.Size = new Size(122, 20);
            labelUporabniskoIme.TabIndex = 7;
            labelUporabniskoIme.Text = "Uporabniško ime";
            // 
            // labelFormat
            // 
            labelFormat.Anchor = AnchorStyles.Right;
            labelFormat.AutoSize = true;
            labelFormat.Location = new Point(81, 260);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(56, 20);
            labelFormat.TabIndex = 6;
            labelFormat.Text = "Format";
            // 
            // labelPrioriteta
            // 
            labelPrioriteta.Anchor = AnchorStyles.Right;
            labelPrioriteta.AutoSize = true;
            labelPrioriteta.Location = new Point(431, 260);
            labelPrioriteta.Name = "labelPrioriteta";
            labelPrioriteta.Size = new Size(70, 20);
            labelPrioriteta.TabIndex = 13;
            labelPrioriteta.Text = "Prioriteta";
            // 
            // labelGeslo
            // 
            labelGeslo.Anchor = AnchorStyles.Right;
            labelGeslo.AutoSize = true;
            labelGeslo.Location = new Point(455, 296);
            labelGeslo.Name = "labelGeslo";
            labelGeslo.Size = new Size(46, 20);
            labelGeslo.TabIndex = 14;
            labelGeslo.Text = "Geslo";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(radioButtonText, 0, 0);
            tableLayoutPanel2.Controls.Add(radioButtonHTML, 1, 0);
            tableLayoutPanel2.Location = new Point(146, 255);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(251, 30);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // radioButtonText
            // 
            radioButtonText.Anchor = AnchorStyles.Left;
            radioButtonText.AutoSize = true;
            radioButtonText.Location = new Point(3, 3);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(57, 24);
            radioButtonText.TabIndex = 0;
            radioButtonText.TabStop = true;
            radioButtonText.Text = "Text";
            radioButtonText.UseVisualStyleBackColor = true;
            // 
            // radioButtonHTML
            // 
            radioButtonHTML.Anchor = AnchorStyles.None;
            radioButtonHTML.AutoSize = true;
            radioButtonHTML.Location = new Point(153, 3);
            radioButtonHTML.Name = "radioButtonHTML";
            radioButtonHTML.Size = new Size(69, 24);
            radioButtonHTML.TabIndex = 1;
            radioButtonHTML.TabStop = true;
            radioButtonHTML.Text = "HTML";
            radioButtonHTML.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(radioButtonObicajna, 0, 0);
            tableLayoutPanel3.Controls.Add(radioButtonSrednja, 1, 0);
            tableLayoutPanel3.Controls.Add(radioButtonVisoka, 2, 0);
            tableLayoutPanel3.Location = new Point(507, 255);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(392, 30);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // radioButtonObicajna
            // 
            radioButtonObicajna.Anchor = AnchorStyles.None;
            radioButtonObicajna.AutoSize = true;
            radioButtonObicajna.Location = new Point(20, 3);
            radioButtonObicajna.Name = "radioButtonObicajna";
            radioButtonObicajna.Size = new Size(89, 24);
            radioButtonObicajna.TabIndex = 0;
            radioButtonObicajna.TabStop = true;
            radioButtonObicajna.Text = "Običajna";
            radioButtonObicajna.UseVisualStyleBackColor = true;
            // 
            // radioButtonSrednja
            // 
            radioButtonSrednja.Anchor = AnchorStyles.None;
            radioButtonSrednja.AutoSize = true;
            radioButtonSrednja.Location = new Point(155, 3);
            radioButtonSrednja.Name = "radioButtonSrednja";
            radioButtonSrednja.Size = new Size(80, 24);
            radioButtonSrednja.TabIndex = 1;
            radioButtonSrednja.TabStop = true;
            radioButtonSrednja.Text = "Srednja";
            radioButtonSrednja.UseVisualStyleBackColor = true;
            // 
            // radioButtonVisoka
            // 
            radioButtonVisoka.Anchor = AnchorStyles.None;
            radioButtonVisoka.AutoSize = true;
            radioButtonVisoka.Location = new Point(289, 3);
            radioButtonVisoka.Name = "radioButtonVisoka";
            radioButtonVisoka.Size = new Size(73, 24);
            radioButtonVisoka.TabIndex = 2;
            radioButtonVisoka.TabStop = true;
            radioButtonVisoka.Text = "Visoka";
            radioButtonVisoka.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(64, 324);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 17;
            label1.Text = "Sporočilo";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(comboBox1, 3);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(756, 28);
            comboBox1.TabIndex = 18;
            // 
            // textZadeva
            // 
            textZadeva.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textZadeva, 3);
            textZadeva.Location = new Point(143, 184);
            textZadeva.Name = "textZadeva";
            textZadeva.Size = new Size(756, 27);
            textZadeva.TabIndex = 19;
            // 
            // textPrejemnik
            // 
            textPrejemnik.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textPrejemnik, 3);
            textPrejemnik.Location = new Point(143, 76);
            textPrejemnik.Name = "textPrejemnik";
            textPrejemnik.Size = new Size(756, 27);
            textPrejemnik.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 220);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(258, 28);
            comboBox2.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(143, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 27);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(507, 292);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(392, 27);
            textBox5.TabIndex = 24;
            // 
            // textSporocilo
            // 
            tableLayoutPanel1.SetColumnSpan(textSporocilo, 3);
            textSporocilo.Dock = DockStyle.Fill;
            textSporocilo.Location = new Point(143, 327);
            textSporocilo.Multiline = true;
            textSporocilo.Name = "textSporocilo";
            textSporocilo.Size = new Size(756, 121);
            textSporocilo.TabIndex = 25;
            // 
            // buttonPoslji
            // 
            buttonPoslji.Anchor = AnchorStyles.Right;
            buttonPoslji.Location = new Point(805, 454);
            buttonPoslji.Name = "buttonPoslji";
            buttonPoslji.Size = new Size(94, 29);
            buttonPoslji.TabIndex = 26;
            buttonPoslji.Text = "Pošlji";
            buttonPoslji.UseVisualStyleBackColor = true;
            buttonPoslji.Click += buttonPoslji_Click;
            // 
            // checkBoxZapomni
            // 
            checkBoxZapomni.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(checkBoxZapomni, 3);
            checkBoxZapomni.Dock = DockStyle.Fill;
            checkBoxZapomni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxZapomni.Location = new Point(3, 454);
            checkBoxZapomni.Name = "checkBoxZapomni";
            checkBoxZapomni.Size = new Size(498, 30);
            checkBoxZapomni.TabIndex = 27;
            checkBoxZapomni.Text = "Zapomni si pošiljatelja in SMTP Strežnik";
            checkBoxZapomni.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            tableLayoutPanel1.SetColumnSpan(menuStrip1, 4);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { seznamPrejemnikovToolStripMenuItem, seznamPoslanihSporočilToolStripMenuItem, novoSporočiloToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(902, 36);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // seznamPrejemnikovToolStripMenuItem
            // 
            seznamPrejemnikovToolStripMenuItem.Name = "seznamPrejemnikovToolStripMenuItem";
            seznamPrejemnikovToolStripMenuItem.Size = new Size(161, 32);
            seznamPrejemnikovToolStripMenuItem.Text = "Seznam prejemnikov";
            // 
            // seznamPoslanihSporočilToolStripMenuItem
            // 
            seznamPoslanihSporočilToolStripMenuItem.Name = "seznamPoslanihSporočilToolStripMenuItem";
            seznamPoslanihSporočilToolStripMenuItem.Size = new Size(192, 32);
            seznamPoslanihSporočilToolStripMenuItem.Text = "Seznam poslanih sporočil";
            seznamPoslanihSporočilToolStripMenuItem.Click += seznamPoslanihSporocilToolStripMenuItem_Click;
            // 
            // novoSporočiloToolStripMenuItem
            // 
            novoSporočiloToolStripMenuItem.Name = "novoSporočiloToolStripMenuItem";
            novoSporočiloToolStripMenuItem.Size = new Size(125, 32);
            novoSporočiloToolStripMenuItem.Text = "Novo sporočilo";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBox2, 3);
            textBox2.Location = new Point(143, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(756, 27);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(65, 44);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 29;
            label2.Text = "Pošiljatelj";
            // 
            // textPosiljatelj
            // 
            textPosiljatelj.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textPosiljatelj, 3);
            textPosiljatelj.Location = new Point(143, 40);
            textPosiljatelj.Name = "textPosiljatelj";
            textPosiljatelj.Size = new Size(756, 27);
            textPosiljatelj.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 487);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelPrejemnik;
        private Label labelKopijacc;
        private Label labelSkritaKopijaBcc;
        private Label labelZadeva;
        private Label labelSMTPStreznik;
        private Label labelFormat;
        private Label labelUporabniskoIme;
        private Panel panel2;
        private Label labelPrioriteta;
        private Label labelGeslo;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton radioButton2;
        private RadioButton radioButtonText;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioButtonObicajna;
        private RadioButton radioButtonSrednja;
        private RadioButton radioButtonVisoka;
        private RadioButton radioButtonHTML;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textZadeva;
        private TextBox textBox2;
        private TextBox textPrejemnik;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textSporocilo;
        private Button buttonPoslji;
        private CheckBox checkBoxZapomni;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem seznamPrejemnikovToolStripMenuItem;
        private ToolStripMenuItem seznamPoslanihSporočilToolStripMenuItem;
        private ToolStripMenuItem novoSporočiloToolStripMenuItem;
        private Label label2;
        private TextBox textPosiljatelj;
    }
}
