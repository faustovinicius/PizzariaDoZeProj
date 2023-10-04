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
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm()
        {

            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);


        }
        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonEnviarParaBandeja_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CustomMessageBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
