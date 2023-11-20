using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.DAO;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//debuggar, problema usercontrol
namespace PizzariaDoZeProj
{
    public partial class Clientes : Form
    {
        private readonly EnderecoDAO enderecoDAO;

        public Clientes()
        {
            InitializeComponent();

            Funcoes.AjustaResourcesControl(this);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            // tentando usar manipulador de evento 
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += new KeyEventHandler(TextBoxKeyDown);
                }
            }

            // Adicionando o código fornecido
            // userControlEndereco.maskedTextBoxCep.Leave += MaskedTextBoxCep_Leave;

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = textBoxCPF.Text.Replace(".", "").Replace("-", "");

            if (input.Length == 11)
            {
                string formattedCPF = $"{input.Substring(0, 3)}.{input.Substring(3, 3)}.{input.Substring(6, 3)}-{input.Substring(9)}";
                textBoxCPF.Text = formattedCPF;
            }
        }

        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (input.Length >= 10)
            {
                string formattedNumber = $"({input.Substring(0, 2)}) {input.Substring(2, 4)}-{input.Substring(6, 4)}";
                textBoxTelefone.Text = formattedNumber;
            }
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            if (userControlEndereco.textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = textBoxNome.Text,
                Cpf = maskedTextBoxCpf.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEMail.Text,
                EnderecoId = int.Parse(userControlEndereco.textBoxId.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length <= 0 || userControlEndereco.textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um cliente e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = int.Parse(textBoxId.Text),
                Nome = textBoxNome.Text,
                Cpf = maskedTextBoxCpf.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEMail.Text,
                EnderecoId = int.Parse(userControlEndereco.textBoxId.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para editar
                clienteDAO.Editar(cliente);
                MessageBox.Show("Dados editados com sucesso! " + textBoxId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Editar(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter(); id.ParameterName = "@id"; id.Value = cliente.Id; comando.Parameters.Add(id);
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome"; nome.Value = cliente.Nome; comando.Parameters.Add(nome);
            var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf"; cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
            var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone"; telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
            var email = comando.CreateParameter(); email.ParameterName = "@email"; email.Value = cliente.Email; comando.Parameters.Add(email);
            var endereco_id = comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id"; endereco_id.Value = cliente.EnderecoId; comando.Parameters.Add(endereco_id);
            var numero = comando.CreateParameter(); numero.ParameterName = "@numero"; numero.Value = cliente.Numero; comando.Parameters.Add(numero);
            var complemento = comando.CreateParameter(); complemento.ParameterName = "@complemento"; complemento.Value = cliente.Complemento; comando.Parameters.Add(complemento);
            conexao.Open();
            //realiza o UPDATE
            comando.CommandText = @"UPDATE tb_clientes SET " +
            "nome_cliente = @nome, " +
            "cpf = @cpf, " +
            "telefone = @telefone, " +
            "email = @email, " +
            "endereco_id = @endereco_id, " +
            "numero = @numero, " +
            "complemento = @complemento " +
            "WHERE id_cliente = @id;";
            //executa o comando no banco de dados
            
    }    

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                 DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxId.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                    maskedTextBoxCpf.Text = row[2].ToString();
                    maskedTextBoxTelefone.Text = row[3].ToString();
                    textBoxEMail.Text = row[4].ToString();
                    userControlEndereco.textBoxId.Text = row[5].ToString();
                    userControlEndereco.maskedTextBoxCep.Text = row[6].ToString();
                    userControlEndereco.textBoxLogradouro.Text = row[7].ToString();
                    userControlEndereco.textBoxBairro.Text = row[8].ToString();
                    userControlEndereco.comboBoxCidade.Text = row[10].ToString();
                    userControlEndereco.comboBoxUF.Text = row[12].ToString();
                    userControlEndereco.comboBoxPais.Text = row[14].ToString();
                    textBoxNumero.Text = row[15].ToString();
                    textBoxComplemento.Text = row[16].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            private void DataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                if (dataGridViewDados.SelectedCells.Count > 0)
                {
                    //pega a primeira coluna, que esta com o ID, da linha selecionada
                    DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    AtualizaTelaEditar(id);
                }
            }
            public void Excluir(Cliente cliente)
            {
                using var conexao = factory.CreateConnection(); //Cria conexão
                conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
                using var comando = factory.CreateCommand(); //Cria comando
                comando!.Connection = conexao; //Atribui conexão
                                               //Adiciona parâmetro (@campo e valor)
                var id = comando.CreateParameter();
                id.ParameterName = "@id";
                id.Value = cliente.Id;
                comando.Parameters.Add(id);
                conexao.Open();
                //realiza o DELETE
                comando.CommandText = @"DELETE FROM tb_clientes WHERE id_cliente = @id;";
                //executa o comando no banco de dados
                _ = comando.ExecuteNonQuery();
            }

            private void ButtonExcluir_Click(object sender, EventArgs e)
            {
                if (textBoxId.Text.Length <= 0)
                {
                    MessageBox.Show("Selecione um cliente!");
                    return;
                }
                //Instância e Preenche o objeto com os dados da view
                var cliente = new Cliente
                {
                    Id = int.Parse(textBoxId.Text),
                };
                try
                {
                    // chama o método da model para excluir
                    clienteDAO.Excluir(cliente);
                    MessageBox.Show("Dados excluidos com sucesso! " + textBoxId.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
