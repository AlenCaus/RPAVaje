using System.ComponentModel;

namespace Vaja2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIzracunPovprecja_Click(object sender, EventArgs e)
        {
            var students = studentOcenaModelBindingSource.List as BindingList<StudentOcenaModel>;

            var studentsWithGrade = students.Where(x => x.Ocena.HasValue);

            if (!studentsWithGrade.Any(x => x.Ocena.HasValue))
            {
                return;
            }

            var average = studentsWithGrade.Average(x => x.Ocena);
            MessageBox.Show($"Povprečna ocena: {Math.Round(average.Value)}");
        }
    }
}
