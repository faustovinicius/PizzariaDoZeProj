using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using PizzariaDoZe.DAO;

namespace PizzariaDoZeProj
{
    public partial class Funcionario : Form
    {
        private readonly FuncionarioDAO funcionarioDAO;
        UserControlEndereco userControlEndereco = new UserControlEndereco();

        public Funcionario()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instância da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            // Adiciona o manipulador de evento para os TextBoxes
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += new KeyEventHandler(TextBoxKeyDown);
                }
            }
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void buttonSalvar_Click(object? sender, EventArgs e)
        {
            if (userControlEndereco.TextBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço válido!");
                return;
            }

            // Instância e Preenche o objeto com os dados da view
            var funcionario = new PizzariaDoZe.DAO.Funcionario
            {
                Id = 0,
                Nome = textBoxNome.Text,
              //  Cpf = maskedTextBoxCPF.Text,//
                Matricula = textBoxMatricula.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxSenha.Text),
                Grupo = (radioButtonAdministrador.Checked) ? '1' : (radioButtonAtendente.Checked) ? '2' : '3',
                Motorista = textBoxCNH.Text,
              //  Validade = maskedTextBoxValidade.Value,//
                Observacao = textBoxObservacao.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(userControlEndereco.TextBoxId.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };

            try
            {
                // Chama o método da model para inserir e capturar o ID do funcionário
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! ID do Funcionário: " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
