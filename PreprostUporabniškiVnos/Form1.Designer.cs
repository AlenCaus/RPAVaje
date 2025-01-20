namespace PreprostUporabniškiVnos
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
            buttonPošljiImeGeslo = new Button();
            labelIme = new Label();
            labelGeslo = new Label();
            txtIme = new TextBox();
            txtGeslo = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonPošljiImeGeslo, 0, 2);
            tableLayoutPanel1.Controls.Add(labelIme, 0, 0);
            tableLayoutPanel1.Controls.Add(labelGeslo, 0, 1);
            tableLayoutPanel1.Controls.Add(txtIme, 1, 0);
            tableLayoutPanel1.Controls.Add(txtGeslo, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(830, 423);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonPošljiImeGeslo
            // 
            buttonPošljiImeGeslo.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(buttonPošljiImeGeslo, 2);
            buttonPošljiImeGeslo.Location = new Point(347, 318);
            buttonPošljiImeGeslo.Name = "buttonPošljiImeGeslo";
            buttonPošljiImeGeslo.Size = new Size(136, 66);
            buttonPošljiImeGeslo.TabIndex = 0;
            buttonPošljiImeGeslo.Text = "Pošlji";
            buttonPošljiImeGeslo.UseVisualStyleBackColor = true;
            buttonPošljiImeGeslo.Click += buttonPošljiImeGeslo_Click;
            // 
            // labelIme
            // 
            labelIme.Anchor = AnchorStyles.Right;
            labelIme.AutoSize = true;
            labelIme.Location = new Point(63, 60);
            labelIme.Name = "labelIme";
            labelIme.Size = new Size(34, 20);
            labelIme.TabIndex = 1;
            labelIme.Text = "Ime";
            // 
            // labelGeslo
            // 
            labelGeslo.Anchor = AnchorStyles.Right;
            labelGeslo.AutoSize = true;
            labelGeslo.Location = new Point(51, 200);
            labelGeslo.Name = "labelGeslo";
            labelGeslo.Size = new Size(46, 20);
            labelGeslo.TabIndex = 2;
            labelGeslo.Text = "Geslo";
            // 
            // txtIme
            // 
            txtIme.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIme.Location = new Point(103, 56);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(724, 27);
            txtIme.TabIndex = 3;
            // 
            // txtGeslo
            // 
            txtGeslo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGeslo.Location = new Point(103, 196);
            txtGeslo.Name = "txtGeslo";
            txtGeslo.PasswordChar = '*';
            txtGeslo.Size = new Size(724, 27);
            txtGeslo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 423);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonPošljiImeGeslo;
        private Label labelIme;
        private Label labelGeslo;
        private TextBox txtIme;
        private TextBox txtGeslo;
    }
}
