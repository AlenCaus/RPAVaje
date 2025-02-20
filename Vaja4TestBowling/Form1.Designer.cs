namespace Vaja4TestBowling
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
            buttonDodaj = new Button();
            dataGridView1 = new DataGridView();
            imeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tockeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ColumnUredi = new DataGridViewTextBoxColumn();
            ColumnOdstrani = new DataGridViewTextBoxColumn();
            igralecModelBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)igralecModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.125F));
            tableLayoutPanel1.Controls.Add(buttonDodaj, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8888893F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(690, 386);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(94, 29);
            buttonDodaj.TabIndex = 0;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imeDataGridViewTextBoxColumn, tockeDataGridViewTextBoxColumn, ColumnUredi, ColumnOdstrani });
            dataGridView1.DataSource = igralecModelBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(681, 377);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            imeDataGridViewTextBoxColumn.ReadOnly = true;
            imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tockeDataGridViewTextBoxColumn
            // 
            tockeDataGridViewTextBoxColumn.DataPropertyName = "Tocke";
            tockeDataGridViewTextBoxColumn.HeaderText = "Tocke";
            tockeDataGridViewTextBoxColumn.MinimumWidth = 6;
            tockeDataGridViewTextBoxColumn.Name = "tockeDataGridViewTextBoxColumn";
            tockeDataGridViewTextBoxColumn.ReadOnly = true;
            tockeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ColumnUredi
            // 
            ColumnUredi.HeaderText = "Uredi";
            ColumnUredi.MinimumWidth = 6;
            ColumnUredi.Name = "ColumnUredi";
            ColumnUredi.ReadOnly = true;
            ColumnUredi.Width = 125;
            // 
            // ColumnOdstrani
            // 
            ColumnOdstrani.HeaderText = "Odstrani";
            ColumnOdstrani.MinimumWidth = 6;
            ColumnOdstrani.Name = "ColumnOdstrani";
            ColumnOdstrani.ReadOnly = true;
            ColumnOdstrani.Width = 125;
            // 
            // igralecModelBindingSource
            // 
            igralecModelBindingSource.DataSource = typeof(IgralecModel);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)igralecModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonDodaj;
        private DataGridView dataGridView1;
        private BindingSource igralecModelBindingSource;
        private DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tockeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ColumnUredi;
        private DataGridViewTextBoxColumn ColumnOdstrani;
    }
}
