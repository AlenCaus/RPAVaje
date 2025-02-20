//namespace Vaja3_Seminarska
//{
//    partial class GlavniMeniForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
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
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            tableLayoutPanel1 = new TableLayoutPanel();
//            label1 = new Label();
//            buttonGrmicevje = new Button();
//            buttonIglavci = new Button();
//            buttonListavci = new Button();
//            label2 = new Label();
//            label3 = new Label();
//            label4 = new Label();
//            tableLayoutPanel1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // tableLayoutPanel1
//            // 
//            tableLayoutPanel1.ColumnCount = 3;
//            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
//            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
//            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
//            tableLayoutPanel1.Controls.Add(label1, 0, 0);
//            tableLayoutPanel1.Controls.Add(buttonGrmicevje, 0, 1);
//            tableLayoutPanel1.Controls.Add(buttonIglavci, 1, 1);
//            tableLayoutPanel1.Controls.Add(buttonListavci, 2, 1);
//            tableLayoutPanel1.Controls.Add(label2, 0, 2);
//            tableLayoutPanel1.Controls.Add(label3, 1, 2);
//            tableLayoutPanel1.Controls.Add(label4, 2, 2);
//            tableLayoutPanel1.Dock = DockStyle.Fill;
//            tableLayoutPanel1.Location = new Point(0, 0);
//            tableLayoutPanel1.Name = "tableLayoutPanel1";
//            tableLayoutPanel1.RowCount = 3;
//            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.8695641F));
//            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.13043F));
//            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
//            tableLayoutPanel1.Size = new Size(817, 437);
//            tableLayoutPanel1.TabIndex = 0;
//            // 
//            // label1
//            // 
//            label1.Anchor = AnchorStyles.None;
//            label1.AutoSize = true;
//            tableLayoutPanel1.SetColumnSpan(label1, 3);
//            label1.Location = new Point(27, 53);
//            label1.Name = "label1";
//            label1.Size = new Size(763, 20);
//            label1.TabIndex = 0;
//            label1.Text = "Tukaj lahko raziščete podatke o različnih rastlinah. S klikom na posamezen gumb si lahko ogledate podrobnosti o:";
//            // 
//            // buttonGrmicevje
//            // 
//            buttonGrmicevje.Anchor = AnchorStyles.Left | AnchorStyles.Right;
//            buttonGrmicevje.Location = new Point(3, 226);
//            buttonGrmicevje.Name = "buttonGrmicevje";
//            buttonGrmicevje.Size = new Size(266, 29);
//            buttonGrmicevje.TabIndex = 1;
//            buttonGrmicevje.Text = "Zbirka Grmičevja";
//            buttonGrmicevje.UseVisualStyleBackColor = true;
//            buttonGrmicevje.Click += buttonGrmicevje_Click;
//            // 
//            // buttonIglavci
//            // 
//            buttonIglavci.Anchor = AnchorStyles.Left | AnchorStyles.Right;
//            buttonIglavci.Location = new Point(275, 226);
//            buttonIglavci.Name = "buttonIglavci";
//            buttonIglavci.Size = new Size(266, 29);
//            buttonIglavci.TabIndex = 2;
//            buttonIglavci.Text = "Zbirka Iglavcev";
//            buttonIglavci.UseVisualStyleBackColor = true;
//            buttonIglavci.Click += buttonIglavci_Click;
//            // 
//            // buttonListavci
//            // 
//            buttonListavci.Anchor = AnchorStyles.Left | AnchorStyles.Right;
//            buttonListavci.Location = new Point(547, 226);
//            buttonListavci.Name = "buttonListavci";
//            buttonListavci.Size = new Size(267, 29);
//            buttonListavci.TabIndex = 3;
//            buttonListavci.Text = "Zbirka Listavcev";
//            buttonListavci.UseVisualStyleBackColor = true;
//            buttonListavci.Click += buttonListavci_Click;
//            // 
//            // label2
//            // 
//            label2.Anchor = AnchorStyles.None;
//            label2.AutoSize = true;
//            label2.Location = new Point(10, 376);
//            label2.Name = "label2";
//            label2.Size = new Size(252, 40);
//            label2.TabIndex = 4;
//            label2.Text = "raziskujte nizke okrasne in uporabne grmovnice.";
//            // 
//            // label3
//            // 
//            label3.Anchor = AnchorStyles.None;
//            label3.AutoSize = true;
//            label3.Location = new Point(298, 376);
//            label3.Name = "label3";
//            label3.Size = new Size(219, 40);
//            label3.TabIndex = 5;
//            label3.Text = "spoznajte zimzelena drevesa in njihove posebnosti.";
//            // 
//            // label4
//            // 
//            label4.Anchor = AnchorStyles.None;
//            label4.AutoSize = true;
//            label4.Location = new Point(554, 376);
//            label4.Name = "label4";
//            label4.Size = new Size(253, 40);
//            label4.TabIndex = 6;
//            label4.Text = "preučite drevesa z raznolikimi listi in cvetovi.";
//            // 
//            // GlavniMeniForm
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(817, 437);
//            Controls.Add(tableLayoutPanel1);
//            Name = "GlavniMeniForm";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "GlavniMeniForm";
//            Load += GlavniMeniForm_Load;
//            tableLayoutPanel1.ResumeLayout(false);
//            tableLayoutPanel1.PerformLayout();
//            ResumeLayout(false);
//        }

//        #endregion

//        private TableLayoutPanel tableLayoutPanel1;
//        private Label label1;
//        private Button buttonGrmicevje;
//        private Button buttonIglavci;
//        private Button buttonListavci;
//        private Label label2;
//        private Label label3;
//        private Label label4;
//    }
//}

namespace Vaja3_Seminarska
{
    partial class GlavniMeniForm
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
            buttonGrmicevje = new Button();
            buttonIglavci = new Button();
            buttonListavci = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonGrmicevje, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonIglavci, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonListavci, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(853, 434);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(788, 41);
            label1.TabIndex = 0;
            label1.Text = "Raziščite podatke o rastlinah. Izberite eno izmed zbirk:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonGrmicevje
            // 
            buttonGrmicevje.Anchor = AnchorStyles.None;
            buttonGrmicevje.BackColor = Color.FromArgb(76, 175, 80);
            buttonGrmicevje.FlatAppearance.BorderSize = 0;
            buttonGrmicevje.FlatStyle = FlatStyle.Flat;
            buttonGrmicevje.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonGrmicevje.ForeColor = Color.White;
            buttonGrmicevje.Location = new Point(32, 202);
            buttonGrmicevje.Name = "buttonGrmicevje";
            buttonGrmicevje.Size = new Size(220, 50);
            buttonGrmicevje.TabIndex = 1;
            buttonGrmicevje.Text = "Zbirka Grmičevja";
            buttonGrmicevje.UseVisualStyleBackColor = false;
            buttonGrmicevje.Click += buttonGrmicevje_Click;
            // 
            // buttonIglavci
            // 
            buttonIglavci.Anchor = AnchorStyles.None;
            buttonIglavci.BackColor = Color.FromArgb(76, 175, 80);
            buttonIglavci.FlatAppearance.BorderSize = 0;
            buttonIglavci.FlatStyle = FlatStyle.Flat;
            buttonIglavci.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonIglavci.ForeColor = Color.White;
            buttonIglavci.Location = new Point(316, 202);
            buttonIglavci.Name = "buttonIglavci";
            buttonIglavci.Size = new Size(220, 50);
            buttonIglavci.TabIndex = 2;
            buttonIglavci.Text = "Zbirka Iglavcev";
            buttonIglavci.UseVisualStyleBackColor = false;
            buttonIglavci.Click += buttonIglavci_Click;
            // 
            // buttonListavci
            // 
            buttonListavci.Anchor = AnchorStyles.None;
            buttonListavci.BackColor = Color.FromArgb(76, 175, 80);
            buttonListavci.FlatAppearance.BorderSize = 0;
            buttonListavci.FlatStyle = FlatStyle.Flat;
            buttonListavci.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonListavci.ForeColor = Color.White;
            buttonListavci.Location = new Point(600, 202);
            buttonListavci.Name = "buttonListavci";
            buttonListavci.Size = new Size(220, 50);
            buttonListavci.TabIndex = 3;
            buttonListavci.Text = "Zbirka Listavcev";
            buttonListavci.UseVisualStyleBackColor = false;
            buttonListavci.Click += buttonListavci_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(20, 325);
            label2.Name = "label2";
            label2.Size = new Size(243, 56);
            label2.TabIndex = 4;
            label2.Text = "Raziskujte nizke okrasne in uporabne grmovnice.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(295, 325);
            label3.Name = "label3";
            label3.Size = new Size(262, 56);
            label3.TabIndex = 5;
            label3.Text = "Spoznajte zimzelena drevesa in njihove posebnosti.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(576, 325);
            label4.Name = "label4";
            label4.Size = new Size(269, 56);
            label4.TabIndex = 6;
            label4.Text = "Preučite drevesa z raznolikimi listi in cvetovi.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GlavniMeniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(853, 434);
            Controls.Add(tableLayoutPanel1);
            Name = "GlavniMeniForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Glavni Meni - Zbirka Rastlin";
            FormClosed += GlavniMeniForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1, label2, label3, label4;
        private Button buttonGrmicevje, buttonIglavci, buttonListavci;
    }
}
