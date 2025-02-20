namespace Vaja4TestBowling
{
    partial class FormUredi
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            buttonPreklici = new Button();
            buttonOK = new Button();
            textIme = new TextBox();
            textTocke = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonPreklici, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonOK, 1, 2);
            tableLayoutPanel1.Controls.Add(textIme, 1, 0);
            tableLayoutPanel1.Controls.Add(textTocke, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(360, 87);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(347, 282);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Točke:";
            // 
            // buttonPreklici
            // 
            buttonPreklici.Anchor = AnchorStyles.Right;
            buttonPreklici.Location = new Point(303, 405);
            buttonPreklici.Name = "buttonPreklici";
            buttonPreklici.Size = new Size(94, 29);
            buttonPreklici.TabIndex = 2;
            buttonPreklici.Text = "Prekliči";
            buttonPreklici.UseVisualStyleBackColor = true;
            buttonPreklici.Click += buttonPreklici_Click;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Left;
            buttonOK.Location = new Point(403, 405);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textIme
            // 
            textIme.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textIme.Location = new Point(403, 84);
            textIme.Name = "textIme";
            textIme.Size = new Size(394, 27);
            textIme.TabIndex = 4;
            // 
            // textTocke
            // 
            textTocke.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textTocke.Location = new Point(403, 279);
            textTocke.Name = "textTocke";
            textTocke.Size = new Size(394, 27);
            textTocke.TabIndex = 5;
            // 
            // FormUredi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormUredi";
            Text = "FormUredi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button buttonPreklici;
        private Button buttonOK;
        public TextBox textIme;
        public TextBox textTocke;
    }
}