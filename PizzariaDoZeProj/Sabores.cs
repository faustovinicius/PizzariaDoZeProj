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
    }
}
