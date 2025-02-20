using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja3_Seminarska
{
    public partial class GlavniMeniForm : Form
    {
        public GlavniMeniForm()
        {
            InitializeComponent();
        }

        private void buttonGrmicevje_Click(object sender, EventArgs e)
        {
            ListavciForm listavciForm = new ListavciForm(RastlinskiTip.Grmicevje/*"grmicevje"*/);
            listavciForm.Show();
            this.Hide();
        }

        private void buttonIglavci_Click(object sender, EventArgs e)
        {
            ListavciForm listavciForm = new ListavciForm(RastlinskiTip.Iglavci/*"iglavci"*/);
            listavciForm.Show();
            this.Hide();

        }

        private void buttonListavci_Click(object sender, EventArgs e)
        {
            ListavciForm listavciForm = new ListavciForm(RastlinskiTip.Listavci/*"listavci"*/);
            listavciForm.Show();
            this.Hide();
        }

        private void GlavniMeniForm_Load(object sender, EventArgs e)
        {

        }

        private void GlavniMeniForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
