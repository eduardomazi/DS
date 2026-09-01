namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int cont = 7;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 7 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                lsbMostra.Items.Add(fatorial.ToString());
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num = 10;
            lsbMostra.Items.Clear();

            do
            {
                lsbMostra.Items.Add((num * num).ToString());
                num++;
            }
            while (num <= 20);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int maisvc = 0;
            lsbMostra.Items.Clear();

            for (maisvc = 1; maisvc <= 25000; maisvc *= 3)
            {
                lsbMostra.Items.Add(maisvc.ToString());
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            // Array ou vetor é uma estrutura de dados que armazena
            // valores que podem ser acessados por uma posição
            // frutas[0] = "Maça", frutas[1] = "Mamão",.....
            string[] frutas = ["Uva", "Maracuja", "Pera", "Morango"];

            lsbMostra.Items.Clear();
            // lsbMostra.Items.Add(frutas[0]);
            // lsbMostra.Items.Add(frutas[1]);

            foreach (string coisas in frutas)
            {
                lsbMostra.Items.Add(coisas);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int cont = 8;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 8 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                if (cont == 2)
                {
                    break;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int cont = 4;
            lsbMostra.Items.Clear();
            double fatorial = 2;

            while (cont <= 4 & cont >= 2)
            {
                fatorial *= cont;
                cont--;

                if (cont == 2)
                {
                    continue;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }
    }
}
