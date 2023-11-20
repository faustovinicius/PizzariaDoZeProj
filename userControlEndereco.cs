using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.DAO;

namespace PizzariaDoZeProj
{
    public partial class userControlLogradouro : UserControl
    {
        private readonly EnderecoDAO enderecoDAO;

        public userControlLogradouro()
        {
            // Pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // Cria a instância da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);

            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            // Adiciona o manipulador de evento para os TextBoxes
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += new KeyEventHandler(TextBoxKeyDown);
                }
            }

            // Adiciona o manipulador de evento Leave para o campo de CEP
            maskedTextBoxCep.Leave += MaskedTextBoxCep_Leave;
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void TextCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextCep_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxCep.TextLength == 5)
            {
                maskedTextBoxCep.Text += "-";
                maskedTextBoxCep.SelectionStart = maskedTextBoxCep.TextLength;
            }
        }

        private void TextID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textCep_Leave(object sender, EventArgs e)
        {
            // Pode adicionar lógica adicional ao sair do campo CEP, se necessário
        }

        private void MaskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            // Ao sair do campo de CEP, realiza a busca do endereço
            if (maskedTextBoxCep.Text.Trim().Length > 0)
            {
                var endereco = new Endereco
                {
                    Id = 0,
                    Cep = maskedTextBoxCep.Text.Trim()
                };

                try
                {
                    // Chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = enderecoDAO.Buscar(endereco);

                    // Seta os dados na tela
                    TextBoxId.Text = "";
                    TextLogradouro.Text = "";
                    textBairro.Text = "";
                    ComboBoxCidade.Text = "";
                    ComboBoxEstado.Text = "";
                    ComboBoxPais.Text = "";

                    foreach (DataRow row in linhas.Rows)
                    {
                        TextBoxId.Text = row["id"].ToString();
                        TextLogradouro.Text = row["logradouro"].ToString();
                        textBairro.Text = row["bairro"].ToString();
                        ComboBoxCidade.Text = row["cidade"].ToString();
                        ComboBoxEstado.Text = row["uf"].ToString();
                        ComboBoxPais.Text = row["pais"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
