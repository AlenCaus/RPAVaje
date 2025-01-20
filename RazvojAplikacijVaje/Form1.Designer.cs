namespace RazvojAplikacijVaje
{
    partial class VnosPriimek
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
            txtPriimek = new TextBox();
            txtIme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPriimek
            // 
            txtPriimek.Location = new Point(298, 93);
            txtPriimek.Name = "txtPriimek";
            txtPriimek.Size = new Size(181, 27);
            txtPriimek.TabIndex = 0;
            txtPriimek.TextChanged += txtPriimek_TextChanged;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(281, 47);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(125, 27);
            txtIme.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 54);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 2;
            label1.Text = "Prosim vnesite vaše ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 100);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 3;
            label2.Text = "Prosim vnesite vaš priimek:";
            // 
            // button1
            // 
            button1.Location = new Point(518, 54);
            button1.Name = "button1";
            button1.Size = new Size(149, 67);
            button1.TabIndex = 4;
            button1.Text = "Potrdi Vnos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VnosPriimek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIme);
            Controls.Add(txtPriimek);
            Name = "VnosPriimek";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPriimek;
        private TextBox txtIme;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
