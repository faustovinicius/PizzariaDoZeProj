using PizzariaDoZe;

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

namespace PizzariaDoZeProj
{
    public partial class Produtos : Form
    {
        private ProdutoDAO produtoDAO;
        public Produtos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);

            // Adicione o manipulador de evento para os controles de label
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.KeyDown += new KeyEventHandler(LabelKeyDown);
                }
            }
        }

        private void LabelKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Control currentControl = (Control)sender;
                this.SelectNextControl(currentControl, true, true, true, true);
                e.Handled = true;
            }
        }
        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
    }
    private void ButtonSalvar_Click(object? sender, EventArgs e)
    {

        //Instância e Preenche o objeto com os dados da view
        var produto = new Produto
        {
            Id = 0,
            Descricao = textBoxNome.Text,
            Valor = decimal.Parse(textBoxValor.Text),
            Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
            ML = listBoxML.Text,
        };
        try
        {
            // chama o método para inserir da camada model
            produtoDAO.Inserir(produto);
            MessageBox.Show("Dados inseridos com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void ButtonEditar_Click(object sender, EventArgs e)
    {
        if (textBoxId.Text.Length <= 0)
        {
            MessageBox.Show("Selecione um produto!");
            return;
        }
        //Instância e Preenche o objeto com os dados da view
        var produto = new Produto
        {
            Id = int.Parse(textBoxId.Text),
            Descricao = textBoxNome.Text,
            Valor = decimal.Parse(textBoxValor.Text),
            Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
            ML = listBoxML.Text,
        };
        try
        {
            // chama o método para editar da camada model
            produtoDAO.Editar(produto);
            MessageBox.Show("Dados editados com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void ButtonExcluir_Click(object sender, EventArgs e)
    {
        if (textBoxId.Text.Length <= 0)
        {
            MessageBox.Show("Selecione um produto!");
            return;
        }
        //Instância e Preenche o objeto com os dados da view
        var produto = new Produto
        {
            Id = int.Parse(textBoxId.Text),
        };
        try
        {
            // chama o método para inserir da camada model
            produtoDAO.Excluir(produto);
            MessageBox.Show("Dados excluídos com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
