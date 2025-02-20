namespace Vaja3_Seminarska
{
    partial class ListavciForm
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
        //private void InitializeComponent()
        //{
        //    components = new System.ComponentModel.Container();
        //    tableLayoutPanel1 = new TableLayoutPanel();
        //    buttonIzbriši = new Button();
        //    buttonUredi = new Button();
        //    buttonNazaj = new Button();
        //    dataGridView1 = new DataGridView();
        //    slovenskoImeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    latinskoImeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    tipRastlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    višinaRastlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    cenaRastlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        //    rastlinaModelBindingSource = new BindingSource(components);
        //    buttonDodaj = new Button();
        //    buttonObdelaj = new Button();
        //    tableLayoutPanel1.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)rastlinaModelBindingSource).BeginInit();
        //    SuspendLayout();
        //    // 
        //    // tableLayoutPanel1
        //    // 
        //    tableLayoutPanel1.ColumnCount = 3;
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
        //    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        //    tableLayoutPanel1.Controls.Add(buttonIzbriši, 2, 3);
        //    tableLayoutPanel1.Controls.Add(buttonUredi, 2, 2);
        //    tableLayoutPanel1.Controls.Add(buttonNazaj, 2, 0);
        //    tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
        //    tableLayoutPanel1.Controls.Add(buttonDodaj, 2, 1);
        //    tableLayoutPanel1.Controls.Add(buttonObdelaj, 2, 4);
        //    tableLayoutPanel1.Dock = DockStyle.Fill;
        //    tableLayoutPanel1.Location = new Point(0, 0);
        //    tableLayoutPanel1.Name = "tableLayoutPanel1";
        //    tableLayoutPanel1.RowCount = 7;
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        //    tableLayoutPanel1.Size = new Size(951, 413);
        //    tableLayoutPanel1.TabIndex = 0;
        //    // 
        //    // buttonIzbriši
        //    // 
        //    buttonIzbriši.Dock = DockStyle.Fill;
        //    buttonIzbriši.Location = new Point(804, 113);
        //    buttonIzbriši.Name = "buttonIzbriši";
        //    buttonIzbriši.Size = new Size(144, 34);
        //    buttonIzbriši.TabIndex = 3;
        //    buttonIzbriši.Text = "Izbriši";
        //    buttonIzbriši.UseVisualStyleBackColor = true;
        //    buttonIzbriši.Click += buttonIzbriši_Click;
        //    // 
        //    // buttonUredi
        //    // 
        //    buttonUredi.Dock = DockStyle.Fill;
        //    buttonUredi.Location = new Point(804, 73);
        //    buttonUredi.Name = "buttonUredi";
        //    buttonUredi.Size = new Size(144, 34);
        //    buttonUredi.TabIndex = 2;
        //    buttonUredi.Text = "Uredi";
        //    buttonUredi.UseVisualStyleBackColor = true;
        //    buttonUredi.Click += buttonUredi_Click;
        //    // 
        //    // buttonNazaj
        //    // 
        //    buttonNazaj.Dock = DockStyle.Fill;
        //    buttonNazaj.Location = new Point(804, 3);
        //    buttonNazaj.Name = "buttonNazaj";
        //    buttonNazaj.Size = new Size(144, 29);
        //    buttonNazaj.TabIndex = 0;
        //    buttonNazaj.Text = "Nazaj";
        //    buttonNazaj.UseVisualStyleBackColor = true;
        //    buttonNazaj.Click += buttonNazaj_Click;
        //    // 
        //    // dataGridView1
        //    // 
        //    dataGridView1.AutoGenerateColumns = false;
        //    dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    dataGridView1.Columns.AddRange(new DataGridViewColumn[] { slovenskoImeDataGridViewTextBoxColumn, latinskoImeDataGridViewTextBoxColumn, tipRastlineDataGridViewTextBoxColumn, višinaRastlineDataGridViewTextBoxColumn, cenaRastlineDataGridViewTextBoxColumn });
        //    tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
        //    dataGridView1.DataSource = rastlinaModelBindingSource;
        //    dataGridView1.Dock = DockStyle.Fill;
        //    dataGridView1.Location = new Point(3, 3);
        //    dataGridView1.Name = "dataGridView1";
        //    dataGridView1.RowHeadersWidth = 51;
        //    tableLayoutPanel1.SetRowSpan(dataGridView1, 6);
        //    dataGridView1.Size = new Size(795, 367);
        //    dataGridView1.TabIndex = 4;
        //    // 
        //    // slovenskoImeDataGridViewTextBoxColumn
        //    // 
        //    slovenskoImeDataGridViewTextBoxColumn.DataPropertyName = "SlovenskoIme";
        //    slovenskoImeDataGridViewTextBoxColumn.HeaderText = "SlovenskoIme";
        //    slovenskoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
        //    slovenskoImeDataGridViewTextBoxColumn.Name = "slovenskoImeDataGridViewTextBoxColumn";
        //    slovenskoImeDataGridViewTextBoxColumn.Width = 125;
        //    // 
        //    // latinskoImeDataGridViewTextBoxColumn
        //    // 
        //    latinskoImeDataGridViewTextBoxColumn.DataPropertyName = "LatinskoIme";
        //    latinskoImeDataGridViewTextBoxColumn.HeaderText = "LatinskoIme";
        //    latinskoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
        //    latinskoImeDataGridViewTextBoxColumn.Name = "latinskoImeDataGridViewTextBoxColumn";
        //    latinskoImeDataGridViewTextBoxColumn.Width = 125;
        //    // 
        //    // tipRastlineDataGridViewTextBoxColumn
        //    // 
        //    tipRastlineDataGridViewTextBoxColumn.DataPropertyName = "TipRastline";
        //    tipRastlineDataGridViewTextBoxColumn.HeaderText = "TipRastline";
        //    tipRastlineDataGridViewTextBoxColumn.MinimumWidth = 6;
        //    tipRastlineDataGridViewTextBoxColumn.Name = "tipRastlineDataGridViewTextBoxColumn";
        //    tipRastlineDataGridViewTextBoxColumn.Width = 125;
        //    // 
        //    // višinaRastlineDataGridViewTextBoxColumn
        //    // 
        //    višinaRastlineDataGridViewTextBoxColumn.DataPropertyName = "VišinaRastline";
        //    višinaRastlineDataGridViewTextBoxColumn.HeaderText = "VišinaRastline";
        //    višinaRastlineDataGridViewTextBoxColumn.MinimumWidth = 6;
        //    višinaRastlineDataGridViewTextBoxColumn.Name = "višinaRastlineDataGridViewTextBoxColumn";
        //    višinaRastlineDataGridViewTextBoxColumn.Width = 125;
        //    // 
        //    // cenaRastlineDataGridViewTextBoxColumn
        //    // 
        //    cenaRastlineDataGridViewTextBoxColumn.DataPropertyName = "CenaRastline";
        //    cenaRastlineDataGridViewTextBoxColumn.HeaderText = "CenaRastline";
        //    cenaRastlineDataGridViewTextBoxColumn.MinimumWidth = 6;
        //    cenaRastlineDataGridViewTextBoxColumn.Name = "cenaRastlineDataGridViewTextBoxColumn";
        //    cenaRastlineDataGridViewTextBoxColumn.Width = 125;
        //    // 
        //    // rastlinaModelBindingSource
        //    // 
        //    rastlinaModelBindingSource.DataSource = typeof(RastlinaModel);
        //    // 
        //    // buttonDodaj
        //    // 
        //    buttonDodaj.Dock = DockStyle.Fill;
        //    buttonDodaj.Location = new Point(804, 38);
        //    buttonDodaj.Name = "buttonDodaj";
        //    buttonDodaj.Size = new Size(144, 29);
        //    buttonDodaj.TabIndex = 1;
        //    buttonDodaj.Text = "Dodaj";
        //    buttonDodaj.UseVisualStyleBackColor = true;
        //    buttonDodaj.Click += buttonDodaj_Click;
        //    // 
        //    // buttonObdelaj
        //    // 
        //    buttonObdelaj.Dock = DockStyle.Fill;
        //    buttonObdelaj.Location = new Point(804, 153);
        //    buttonObdelaj.Name = "buttonObdelaj";
        //    buttonObdelaj.Size = new Size(144, 34);
        //    buttonObdelaj.TabIndex = 5;
        //    buttonObdelaj.Text = "Obdelaj";
        //    buttonObdelaj.UseVisualStyleBackColor = true;
        //    buttonObdelaj.Click += buttonObdelaj_Click;
        //    // 
        //    // ListavciForm
        //    // 
        //    AutoScaleDimensions = new SizeF(8F, 20F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    ClientSize = new Size(951, 413);
        //    Controls.Add(tableLayoutPanel1);
        //    Name = "ListavciForm";
        //    StartPosition = FormStartPosition.CenterScreen;
        //    Text = "ListavciForm";
        //    FormClosed += ListavciForm_FormClosed;
        //    Load += buttonNazaj_Click;
        //    tableLayoutPanel1.ResumeLayout(false);
        //    ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)rastlinaModelBindingSource).EndInit();
        //    ResumeLayout(false);
        //}

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonNazaj = new Button();
            buttonDodaj = new Button();
            buttonUredi = new Button();
            buttonIzbriši = new Button();
            buttonObdelaj = new Button();
            dataGridView1 = new DataGridView();
            rastlinaModelBindingSource = new BindingSource(components);
            slovenskoImeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            latinskoImeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipRastlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            višinaRastlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cenaRastlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rastlinaModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(buttonNazaj, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonDodaj, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonUredi, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonIzbriši, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonObdelaj, 1, 4);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(964, 432);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonNazaj
            // 
            buttonNazaj.BackColor = Color.FromArgb(76, 175, 80);
            buttonNazaj.Dock = DockStyle.Fill;
            buttonNazaj.FlatAppearance.BorderSize = 0;
            buttonNazaj.FlatStyle = FlatStyle.Flat;
            buttonNazaj.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonNazaj.ForeColor = Color.White;
            buttonNazaj.Location = new Point(774, 3);
            buttonNazaj.Name = "buttonNazaj";
            buttonNazaj.Size = new Size(187, 72);
            buttonNazaj.TabIndex = 5;
            buttonNazaj.Text = "Nazaj";
            buttonNazaj.UseVisualStyleBackColor = false;
            buttonNazaj.Click += buttonNazaj_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.BackColor = Color.FromArgb(76, 175, 80);
            buttonDodaj.Dock = DockStyle.Fill;
            buttonDodaj.FlatAppearance.BorderSize = 0;
            buttonDodaj.FlatStyle = FlatStyle.Flat;
            buttonDodaj.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDodaj.ForeColor = Color.White;
            buttonDodaj.Location = new Point(774, 81);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(187, 72);
            buttonDodaj.TabIndex = 6;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // buttonUredi
            // 
            buttonUredi.BackColor = Color.FromArgb(76, 175, 80);
            buttonUredi.Dock = DockStyle.Fill;
            buttonUredi.FlatAppearance.BorderSize = 0;
            buttonUredi.FlatStyle = FlatStyle.Flat;
            buttonUredi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUredi.ForeColor = Color.White;
            buttonUredi.Location = new Point(774, 159);
            buttonUredi.Name = "buttonUredi";
            buttonUredi.Size = new Size(187, 72);
            buttonUredi.TabIndex = 7;
            buttonUredi.Text = "Uredi";
            buttonUredi.UseVisualStyleBackColor = false;
            buttonUredi.Click += buttonUredi_Click;
            // 
            // buttonIzbriši
            // 
            buttonIzbriši.BackColor = Color.FromArgb(76, 175, 80);
            buttonIzbriši.Dock = DockStyle.Fill;
            buttonIzbriši.FlatAppearance.BorderSize = 0;
            buttonIzbriši.FlatStyle = FlatStyle.Flat;
            buttonIzbriši.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonIzbriši.ForeColor = Color.White;
            buttonIzbriši.Location = new Point(774, 237);
            buttonIzbriši.Name = "buttonIzbriši";
            buttonIzbriši.Size = new Size(187, 72);
            buttonIzbriši.TabIndex = 8;
            buttonIzbriši.Text = "Izbriši";
            buttonIzbriši.UseVisualStyleBackColor = false;
            buttonIzbriši.Click += buttonIzbriši_Click;
            // 
            // buttonObdelaj
            // 
            buttonObdelaj.BackColor = Color.FromArgb(76, 175, 80);
            buttonObdelaj.Dock = DockStyle.Fill;
            buttonObdelaj.FlatAppearance.BorderSize = 0;
            buttonObdelaj.FlatStyle = FlatStyle.Flat;
            buttonObdelaj.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonObdelaj.ForeColor = Color.White;
            buttonObdelaj.Location = new Point(774, 315);
            buttonObdelaj.Name = "buttonObdelaj";
            buttonObdelaj.Size = new Size(187, 72);
            buttonObdelaj.TabIndex = 9;
            buttonObdelaj.Text = "Obdelaj";
            buttonObdelaj.UseVisualStyleBackColor = false;
            buttonObdelaj.Click += buttonObdelaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { slovenskoImeDataGridViewTextBoxColumn, latinskoImeDataGridViewTextBoxColumn, tipRastlineDataGridViewTextBoxColumn, višinaRastlineDataGridViewTextBoxColumn, cenaRastlineDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rastlinaModelBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 5);
            dataGridView1.Size = new Size(765, 384);
            dataGridView1.TabIndex = 10;
            // 
            // rastlinaModelBindingSource
            // 
            rastlinaModelBindingSource.DataSource = typeof(RastlinaModel);
            // 
            // slovenskoImeDataGridViewTextBoxColumn
            // 
            slovenskoImeDataGridViewTextBoxColumn.DataPropertyName = "SlovenskoIme";
            slovenskoImeDataGridViewTextBoxColumn.HeaderText = "Slovensko Ime";
            slovenskoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            slovenskoImeDataGridViewTextBoxColumn.Name = "slovenskoImeDataGridViewTextBoxColumn";
            slovenskoImeDataGridViewTextBoxColumn.Width = 140;
            // 
            // latinskoImeDataGridViewTextBoxColumn
            // 
            latinskoImeDataGridViewTextBoxColumn.DataPropertyName = "LatinskoIme";
            latinskoImeDataGridViewTextBoxColumn.HeaderText = "Latinsko Ime";
            latinskoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            latinskoImeDataGridViewTextBoxColumn.Name = "latinskoImeDataGridViewTextBoxColumn";
            latinskoImeDataGridViewTextBoxColumn.Width = 140;
            // 
            // tipRastlineDataGridViewTextBoxColumn
            // 
            tipRastlineDataGridViewTextBoxColumn.DataPropertyName = "TipRastline";
            tipRastlineDataGridViewTextBoxColumn.HeaderText = "Tip Rastline";
            tipRastlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipRastlineDataGridViewTextBoxColumn.Name = "tipRastlineDataGridViewTextBoxColumn";
            tipRastlineDataGridViewTextBoxColumn.Width = 140;
            // 
            // višinaRastlineDataGridViewTextBoxColumn
            // 
            višinaRastlineDataGridViewTextBoxColumn.DataPropertyName = "VišinaRastline";
            višinaRastlineDataGridViewTextBoxColumn.HeaderText = "Višina Rastline";
            višinaRastlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            višinaRastlineDataGridViewTextBoxColumn.Name = "višinaRastlineDataGridViewTextBoxColumn";
            višinaRastlineDataGridViewTextBoxColumn.Width = 140;
            // 
            // cenaRastlineDataGridViewTextBoxColumn
            // 
            cenaRastlineDataGridViewTextBoxColumn.DataPropertyName = "CenaRastline";
            cenaRastlineDataGridViewTextBoxColumn.HeaderText = "Cena Rastline";
            cenaRastlineDataGridViewTextBoxColumn.MinimumWidth = 6;
            cenaRastlineDataGridViewTextBoxColumn.Name = "cenaRastlineDataGridViewTextBoxColumn";
            cenaRastlineDataGridViewTextBoxColumn.Width = 140;
            // 
            // ListavciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 230, 201);
            ClientSize = new Size(964, 432);
            Controls.Add(tableLayoutPanel1);
            Name = "ListavciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listavci - Zbirka Rastlin";
            FormClosed += ListavciForm_FormClosed;
            Load += ListavciForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rastlinaModelBindingSource).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonNazaj;
        private Button buttonDodaj;
        private Button buttonUredi;
        private Button buttonIzbriši;
        private Button buttonObdelaj;
        private DataGridView dataGridView1;
        private BindingSource rastlinaModelBindingSource;
        private DataGridViewTextBoxColumn slovenskoImeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn latinskoImeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipRastlineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn višinaRastlineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cenaRastlineDataGridViewTextBoxColumn;
    }
}