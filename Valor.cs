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
    public partial class Valor : Form
    {
        private ValorDAO valorDAO;
        public Valor()
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
    }
    private void ButtonSalvar_Click(object? sender, EventArgs e)
    {

        //Instância e Preenche o objeto com os dados da view
        var valor = new Valor
        {
            Id = 0,
            Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
            Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
            ValorPizza = decimal.Parse(maskedTextValor.Text),
            ValorBorda = decimal.Parse(textBoxValorBorda.Text),
        };
        try
        {
            // chama o método para inserir da camada model
            valorDAO.Inserir(valor);
            MessageBox.Show("Dados inseridos com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }
    public void AtualizaTelaEditar(int id)
    {
        //Instância e Preenche o objeto com os dados da view
        var valor = new Valor
        {
            Id = id,
        };
        try
        {
            // chama o método para buscar todos os dados da nossa camada model
            DataTable linhas = valorDAO.Buscar(valor);
            // seta os dados na tela
            foreach (DataRow row in linhas.Rows)
            {
                textBoxId.Text = row[0].ToString();
                listBoxTamanho.Text = ClassEnums.GetDescription((EnumValorTamanho)char.Parse(row[1].ToString()));
                listBoxCategoria.Text = ClassEnums.GetDescription((EnumSaborCategoria)char.Parse(row[2].ToString()));
                maskedTextValor.Text = row[3].ToString();
                textBoxValorBorda.Text = row[4].ToString();
            }
            maskedTextValor.Focus();
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
            MessageBox.Show("Selecione um valor!");
            return;
        }
        //Instância e Preenche o objeto com os dados da view
        var valor = new Valor
        {
            Id = int.Parse(textBoxId.Text),
            Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
            Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
            ValorPizza = decimal.Parse(maskedTextValor.Text),
            ValorBorda = decimal.Parse(textBoxValorBorda.Text),
        };
        try
        {
            // chama o método para editar da camada model
            valorDAO.Editar(valor);
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
            MessageBox.Show("Selecione um valor!");
            return;
        }
        //Instância e Preenche o objeto com os dados da view
        var valor = new Valor
        {
            Id = int.Parse(textBoxId.Text),
        };
        try
        {
            // chama o método para inserir da camada model
            valorDAO.Excluir(valor);
            MessageBox.Show("Dados excluídos com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    /* private void CarregaEnumListBox()
     {
         //popular listBoxTipo
         listBoxTamanho.Items.Clear();
         listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
         //popular listBoxCategoria
         listBoxCategoria.Items.Clear();
         listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
     }
    */

}
