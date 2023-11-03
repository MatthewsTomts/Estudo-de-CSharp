namespace test
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = int.Parse(txt_idade.Text);
                var curso = txt_curso.Text;

                foreach (var item in Alunos)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show($"Erro, Aluno {nome} já cadastrado");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

                lv_alunos.Items.Add(new ListViewItem(new string[] { 
                    aluno.Nome, aluno.Idade.ToString(), aluno.Curso 
                }));
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite uma idade válida");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}