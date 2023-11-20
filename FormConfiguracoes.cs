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

namespace PizzariaDoZeProj
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");


            // Adiciona as três opções à ComboBox
            comboBoxIdioma.Items.Add("pt-BR");
            comboBoxIdioma.Items.Add("en-US");
            comboBoxIdioma.Items.Add("es");

            // Verifica se o idioma atual é uma das opções e seleciona-o na ComboBox
            string idiomaAtual = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            if (comboBoxIdioma.Items.Contains(idiomaAtual))
            {
                comboBoxIdioma.SelectedItem = idiomaAtual;
            }
            else
            {
                // Se o idioma atual não estiver na lista, seleciona o primeiro item como padrão
                comboBoxIdioma.SelectedIndex = 0;
            }
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
        }

        private void ButtonSalvarIdioma_Click(object sender, EventArgs e)
        {
            // Abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");


            Program.AjustaIdiomaRegiao();
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso!");
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {

        }
    }
}
