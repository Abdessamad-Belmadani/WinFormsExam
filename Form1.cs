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

            Console.WriteLine("button one clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}