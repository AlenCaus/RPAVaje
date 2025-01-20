using System.ComponentModel;
using System.Text.Json;

namespace Vaja2TEST
{
    public partial class Form1 : Form
    {

        private BindingList<StudentOcenaModel> studentData
        {
            get => studentOcenaModelBindingSource.List as BindingList<StudentOcenaModel>;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonIzracunPovprecja_Click(object sender, EventArgs e)
        {
            //var studentData = studentOcenaModelBindingSource.List as BindingList<StudentOcenaModel>;

            var studentjeZOceno = studentData.Where(x => x.Ocena is not null);

            MessageBox.Show($"Povprečje: {studentjeZOceno.Average(x => x.Ocena)}.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("studenti.json"))
            {
                var json = File.ReadAllText("studenti.json");
                var studentiList = JsonSerializer.Deserialize<List<StudentOcenaModel>>(json);

                foreach(var student in studentiList)
                {
                    studentData.Add(student);
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var json = JsonSerializer.Serialize(studentData);
            File.WriteAllText("studenti.json", json);
        }
    }
}
