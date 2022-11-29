namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Db db1 = new Db();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Examen ex = new Examen(int.Parse(textBox1_id.Text),textBox3_datedebut.Text, int.Parse(textBox2_duree.Text) );
            if (label1.Text == "Exam")
            {
                    dataGridView1.DataSource = db1.GetTable("examen");
            }
           

           // Console.WriteLine("button one clicked");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}