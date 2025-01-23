namespace Vaja2
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
            buttonIzracunPovprecja = new Button();
            dataGridView1 = new DataGridView();
            studentOcenaModelBindingSource = new BindingSource(components);
            studentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ocenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentOcenaModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonIzracunPovprecja, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(828, 415);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonIzracunPovprecja
            // 
            buttonIzracunPovprecja.Dock = DockStyle.Fill;
            buttonIzracunPovprecja.Location = new Point(417, 368);
            buttonIzracunPovprecja.Name = "buttonIzracunPovprecja";
            buttonIzracunPovprecja.Size = new Size(408, 44);
            buttonIzracunPovprecja.TabIndex = 0;
            buttonIzracunPovprecja.Text = "Izračunaj Povprečje";
            buttonIzracunPovprecja.UseVisualStyleBackColor = true;
            buttonIzracunPovprecja.Click += buttonIzracunPovprecja_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentDataGridViewTextBoxColumn, ocenaDataGridViewTextBoxColumn });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.DataSource = studentOcenaModelBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(822, 359);
            dataGridView1.TabIndex = 1;
            // 
            // studentOcenaModelBindingSource
            // 
            studentOcenaModelBindingSource.DataSource = typeof(StudentOcenaModel);
            // 
            // studentDataGridViewTextBoxColumn
            // 
            studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            studentDataGridViewTextBoxColumn.HeaderText = "Student";
            studentDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            studentDataGridViewTextBoxColumn.Width = 125;
            // 
            // ocenaDataGridViewTextBoxColumn
            // 
            ocenaDataGridViewTextBoxColumn.DataPropertyName = "Ocena";
            ocenaDataGridViewTextBoxColumn.HeaderText = "Ocena";
            ocenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            ocenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 415);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentOcenaModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonIzracunPovprecja;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private BindingSource studentOcenaModelBindingSource;
    }
}
