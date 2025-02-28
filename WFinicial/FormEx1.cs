using System.Security.Permissions;

namespace WFinicial
{
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show
                    ("Ok", "Aprovado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (media < 5)
            {
                MessageBox.Show
                    ("Deu Ruim", "Reprovado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show
                    ("Atenção", "Você está de Recuperção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
