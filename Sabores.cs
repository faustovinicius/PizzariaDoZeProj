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
    public partial class Sabores : Form
    {
        public Sabores()
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

        private void labelFoto_Click(object sender, EventArgs e)
        {

        }

        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
   
}
