namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Db db1 = new Db();
        private string id_exam="";
        public Form1()
        {
            InitializeComponent();
            LoadWelcome();
        }
        private void LoadWelcome()
        {
            label1.Visible = true;
            label1.Text = "Exam";
            label2.Visible=true;
            label2.Text = "ID";
            label3.Visible=true;
            label3.Text = "Durée";
            label4.Visible=true;
            label4.Text = "Date";
            label5.Visible=true;
            label5.Text = "Welcome";
            textBox1.Visible=true;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox2.Visible=true;
            textBox3.Visible=true;
            button1.Visible=true;
            button1.Text = "Add Exam";
            button2.Visible=true;
            button2.Text = "Cancel";
            label6.Visible=false;
            textBox4.Visible=false;
            radioButton1.Visible = false;
            radioButton2.Visible=false;
            dataGridView1.DataSource =null;

        }
        private void LoadQuestion()
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox1.Text= string.Empty;
            textBox2.Visible=false;
            textBox2.Text= string.Empty;    
            textBox3.Visible=false;
            textBox3.Text= string.Empty;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            label1.Text = "Question";
            
            button1.Text = "Add Question";
            


        }
        private void LoadOpenQuestion()
        {
            label1.Text = "Question Ouverte";
            
            label2.Visible = true;
         
            textBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "Ennonce";
            textBox2.Visible = true;
            label4.Visible = true;
            label4.Text = "Id exam";
            textBox3.Visible = true;
            textBox3.Text = this.id_exam;
            label6.Visible = false;
            textBox4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
        private void LoadQCMQuestion()
        {
            label1.Text = "Question QCM";
           
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "Ennonce";
            textBox2.Visible = true;
            label4.Visible = true;
            label4.Text = "Id exam";
            textBox3.Visible = true;
            textBox3.Text = this.id_exam;
            label6.Visible = true;
            textBox4.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == "Exam")
            {   
                Examen ex = new Examen(int.Parse(textBox1.Text), textBox3.Text, int.Parse(textBox2.Text));
                id_exam = textBox1.Text;
                dataGridView1.DataSource = db1.GetTable("examen");
                LoadQuestion();
                

            }else if (label1.Text == "Question")
            {
                if (radioButton1.Checked)
                {
                    LoadOpenQuestion();
                }

                else
                {
                    if (radioButton2.Checked)
                    {
                        LoadQCMQuestion();


                    }
                }
            }else if(label1.Text=="Question Ouverte")
            {
                QuestionOuverte qo = new QuestionOuverte(int.Parse(textBox1.Text), int.Parse(textBox3.Text), textBox2.Text);
                dataGridView1.DataSource = db1.GetTable("question_ouverte");
            }else if(label1.Text=="Question Qcm")
            {
                QuestionQcm qqcm = new QuestionQcm(int.Parse(textBox1.Text), int.Parse(textBox3.Text), textBox2.Text, int.Parse(textBox3.Text));
                dataGridView1.DataSource = db1.GetTable("question_qcm");
            }
           
           

           // Console.WriteLine("button one clicked");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           LoadWelcome();
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

        private void textBox2_duree_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}