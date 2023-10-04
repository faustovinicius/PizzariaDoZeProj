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
    public partial class UserControlLogradouro : UserControl
    {
        public UserControlLogradouro()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

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

        private void TextCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextCep_TextChanged(object sender, EventArgs e)
        {
            if (textCep.TextLength == 5)
            {
                textCep.Text += "-";
                textCep.SelectionStart = textCep.TextLength;
            }
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void UserControlLogradouro_Load(object sender, EventArgs e)
        {

        }
    }
}
