namespace Vaja2TEST
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewStudenti = new DataGridView();
            imeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentOcenaModelBindingSource = new BindingSource(components);
            buttonIzracunPovprecja = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentOcenaModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewStudenti, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonIzracunPovprecja, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dataGridViewStudenti
            // 
            dataGridViewStudenti.AutoGenerateColumns = false;
            dataGridViewStudenti.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridViewStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudenti.Columns.AddRange(new DataGridViewColumn[] { imeDataGridViewTextBoxColumn, ocenaDataGridViewTextBoxColumn });
            tableLayoutPanel1.SetColumnSpan(dataGridViewStudenti, 2);
            dataGridViewStudenti.DataSource = studentOcenaModelBindingSource;
            dataGridViewStudenti.Dock = DockStyle.Fill;
            dataGridViewStudenti.Location = new Point(3, 3);
            dataGridViewStudenti.Name = "dataGridViewStudenti";
            dataGridViewStudenti.RowHeadersWidth = 51;
            dataGridViewStudenti.Size = new Size(794, 404);
            dataGridViewStudenti.TabIndex = 0;
            dataGridViewStudenti.CellContentClick += dataGridViewStudenti_CellContentClick;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ocenaDataGridViewTextBoxColumn
            // 
            ocenaDataGridViewTextBoxColumn.DataPropertyName = "Ocena";
            ocenaDataGridViewTextBoxColumn.HeaderText = "Ocena";
            ocenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            ocenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentOcenaModelBindingSource
            // 
            studentOcenaModelBindingSource.DataSource = typeof(StudentOcenaModel);
            // 
            // buttonIzracunPovprecja
            // 
            buttonIzracunPovprecja.BackColor = Color.FromArgb(128, 128, 255);
            buttonIzracunPovprecja.Dock = DockStyle.Fill;
            buttonIzracunPovprecja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonIzracunPovprecja.Location = new Point(403, 413);
            buttonIzracunPovprecja.Name = "buttonIzracunPovprecja";
            buttonIzracunPovprecja.Size = new Size(394, 34);
            buttonIzracunPovprecja.TabIndex = 1;
            buttonIzracunPovprecja.Text = "Povprečna Ocena";
            buttonIzracunPovprecja.UseVisualStyleBackColor = false;
            buttonIzracunPovprecja.Click += buttonIzracunPovprecja_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentOcenaModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewStudenti;
        private Button buttonIzracunPovprecja;
        private DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private BindingSource studentOcenaModelBindingSource;
    }
}
