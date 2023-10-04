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
    public partial class Ingredientes : Form
    {

        private readonly IngredienteDAO dao;


        public Ingredientes()
        {

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

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

        private void Ingredientes_Load(object sender, EventArgs e)
        {

        }
        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Mark the event as handled, preventing the character from being entered
            }
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente()
            {
                Id = 0,
                Nome = textBoxNome.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = textBoxFiltro.Text,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente); // Correção aqui: mude de ingredienteDAO para dao
                                                            // seta o datasouce do dataGridView com os dados retornados
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
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente);

                foreach (DataRow row in linhas.Rows)
                {
                    textBoxId.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = int.Parse(textBoxId.Text),
                Nome = textBoxNome.Text,
            };
            try
            {
                // chama o método da model para editar
                dao.Editar(ingrediente);
                MessageBox.Show("Dados editados com sucesso! " + textBoxId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
