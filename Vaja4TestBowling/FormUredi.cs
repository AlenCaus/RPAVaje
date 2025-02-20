using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja4TestBowling
{
    public partial class FormUredi : Form
    {
        public FormUredi()
        {
            InitializeComponent();
        }

        private void buttonPreklici_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textTocke.Text, out _))
            {
                MessageBox.Show("Točke morejo biti v števični obliku, čuješ?");
                return;

            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
