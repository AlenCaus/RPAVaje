//namespace Vaja3_Seminarska
//{
//    partial class PozdravForm
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            tableLayoutPanel1 = new TableLayoutPanel();
//            labelDobrodosli = new Label();
//            buttonVstopVZbirko = new Button();
//            tableLayoutPanel1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // tableLayoutPanel1
//            // 
//            tableLayoutPanel1.ColumnCount = 1;
//            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
//            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
//            tableLayoutPanel1.Controls.Add(labelDobrodosli, 0, 0);
//            tableLayoutPanel1.Controls.Add(buttonVstopVZbirko, 0, 1);
//            tableLayoutPanel1.Dock = DockStyle.Fill;
//            tableLayoutPanel1.Location = new Point(0, 0);
//            tableLayoutPanel1.Name = "tableLayoutPanel1";
//            tableLayoutPanel1.RowCount = 2;
//            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
//            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
//            tableLayoutPanel1.Size = new Size(800, 450);
//            tableLayoutPanel1.TabIndex = 0;
//            // 
//            // labelDobrodosli
//            // 
//            labelDobrodosli.Anchor = AnchorStyles.None;
//            labelDobrodosli.AutoSize = true;
//            labelDobrodosli.Location = new Point(305, 102);
//            labelDobrodosli.Name = "labelDobrodosli";
//            labelDobrodosli.Size = new Size(190, 20);
//            labelDobrodosli.TabIndex = 0;
//            labelDobrodosli.Text = "Dobrodošli v Zbirko Rastlin";
//            // 
//            // buttonVstopVZbirko
//            // 
//            buttonVstopVZbirko.Anchor = AnchorStyles.None;
//            buttonVstopVZbirko.Location = new Point(323, 323);
//            buttonVstopVZbirko.Name = "buttonVstopVZbirko";
//            buttonVstopVZbirko.Size = new Size(154, 29);
//            buttonVstopVZbirko.TabIndex = 1;
//            buttonVstopVZbirko.Text = "Vstop v Zbirko";
//            buttonVstopVZbirko.UseVisualStyleBackColor = true;
//            buttonVstopVZbirko.Click += buttonVstopVZbirko_Click;
//            // 
//            // PozdravForm
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 450);
//            Controls.Add(tableLayoutPanel1);
//            Name = "PozdravForm";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Form1";
//            Load += Form1_Load;
//            tableLayoutPanel1.ResumeLayout(false);
//            tableLayoutPanel1.PerformLayout();
//            ResumeLayout(false);
//        }

//        #endregion

//        private TableLayoutPanel tableLayoutPanel1;
//        private Label labelDobrodosli;
//        private Button buttonVstopVZbirko;
//    }
//}

namespace Vaja3_Seminarska
{
    partial class PozdravForm
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.labelDobrodosli = new Label();
            this.buttonVstopVZbirko = new Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // PozdravForm (Glavne nastavitve okna)
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dobrodošli v zbirko rastlin";
            this.BackColor = Color.FromArgb(200, 230, 201); // Svetlo zelena
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelDobrodosli, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonVstopVZbirko, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;

            // 
            // labelDobrodosli
            // 
            this.labelDobrodosli.Anchor = AnchorStyles.None;
            this.labelDobrodosli.AutoSize = true;
            this.labelDobrodosli.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelDobrodosli.ForeColor = Color.DarkGreen;
            this.labelDobrodosli.Location = new Point(200, 80);
            this.labelDobrodosli.Name = "labelDobrodosli";
            this.labelDobrodosli.Size = new Size(400, 50);
            this.labelDobrodosli.TabIndex = 0;
            this.labelDobrodosli.Text = "Dobrodošli v Zbirko Rastlin";
            this.labelDobrodosli.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // buttonVstopVZbirko
            // 
            this.buttonVstopVZbirko.Anchor = AnchorStyles.None;
            this.buttonVstopVZbirko.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.buttonVstopVZbirko.ForeColor = Color.White;
            this.buttonVstopVZbirko.BackColor = Color.FromArgb(76, 175, 80); // Zelena
            this.buttonVstopVZbirko.FlatStyle = FlatStyle.Flat;
            this.buttonVstopVZbirko.FlatAppearance.BorderSize = 0;
            this.buttonVstopVZbirko.Location = new Point(300, 250);
            this.buttonVstopVZbirko.Name = "buttonVstopVZbirko";
            this.buttonVstopVZbirko.Size = new Size(200, 50);
            this.buttonVstopVZbirko.TabIndex = 1;
            this.buttonVstopVZbirko.Text = "Vstop v Zbirko";
            this.buttonVstopVZbirko.UseVisualStyleBackColor = false;
            this.buttonVstopVZbirko.Click += new EventHandler(this.buttonVstopVZbirko_Click);

           
            

            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelDobrodosli;
        private Button buttonVstopVZbirko;
    }
}

