using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZeProj
{
    public partial class Clientes : Form
    {
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
    }
}
