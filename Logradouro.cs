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

namespace PizzariaDoZeProj
{
    public partial class Logradouro : Form
    {
        private readonly EnderecoDAO enderecoDAO;

        public Logradouro()
        {
            // Pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // Cria a instância da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);

            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            // Adiciona o manipulador de evento para os TextBoxes
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += new KeyEventHandler(TextBoxKeyDown);
                }
            }

            // Adiciona o manipulador de evento Leave para o campo de CEP
            textBoxFiltro.Leave += TextBoxFiltro_Leave;
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void TextBoxFiltro_Leave(object sender, EventArgs e)
        {
            // Ao sair do campo de CEP, realiza a busca do endereço
            if (textBoxFiltro.Text.Trim().Length > 0)
            {
                var endereco = new Endereco
                {
                    Id = 0,
                    Cep = textBoxFiltro.Text.Trim()
                };

                try
                {
                    // Chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = enderecoDAO.Buscar(endereco);

                    // Seta o datasource do dataGridView com os dados retornados
                    dataGridViewDados.Columns.Clear();
                    dataGridViewDados.AutoGenerateColumns = true;
                    dataGridViewDados.DataSource = linhas;
                    dataGridViewDados.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            // Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco
            {
                Id = 0,
                Cep = textBoxFiltro.Text
            };

            try
            {
                // Chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);

                // Seta o datasource do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
