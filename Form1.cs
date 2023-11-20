using PizzariaDoZeProj;
using System;
using System.Windows.Forms;

namespace PizzariaDoZeProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown);


            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            this.StartPosition = FormStartPosition.CenterScreen;



            CreateContextMenu();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                CustomMessageBoxForm customMessageBox = new CustomMessageBoxForm();
                customMessageBox.StartPosition = FormStartPosition.CenterScreen;
                DialogResult result = customMessageBox.ShowDialog();


                switch (result)
                {
                    case DialogResult.Yes:
                        Application.Exit();
                        break;

                    case DialogResult.No:

                        break;

                    case DialogResult.Cancel:
                        this.WindowState = FormWindowState.Minimized;
                        break;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void abrirAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void buttonEndereco_Click(object sender, EventArgs e)
        {
            Logradouro LogradouroForm = new Logradouro();
            LogradouroForm.ShowDialog();
        }

        private void ButtonFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionario FuncionariosForm = new Funcionario();
            FuncionariosForm.ShowDialog();
        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            Clientes ClientesForm = new Clientes();
            ClientesForm.ShowDialog();
        }

        private void ButtonIngredientes_Click(object sender, EventArgs e)
        {
            Ingredientes IngredientesForm = new Ingredientes();
            IngredientesForm.ShowDialog();
        }

        private void ButtonSabores_Click(object sender, EventArgs e)
        {
            Sabores SaboresForm = new Sabores();
            SaboresForm.ShowDialog();
        }

        private void ButtonValores_Click(object sender, EventArgs e)
        {
            Valor ValoresForm = new Valor();
            ValoresForm.ShowDialog();
        }

        private void ButtonProdutos_Click(object sender, EventArgs e)
        {
            Produtos ProdutosForm = new Produtos();
            ProdutosForm.ShowDialog();
        }

        private void ButtonConfiguracoes_Click(object sender, EventArgs e)
        {
            FormConfiguracoes config = new FormConfiguracoes()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            _ = config.ShowDialog();
            // remove todos os controles e recria a tela, aplicando assim o novo idioma
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void CreateContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            contextMenu.Items.Add("Início", null, MenuItemClick);
            contextMenu.Items.Add("Logradouro", null, MenuItemClick);
            contextMenu.Items.Add("Funcionários", null, MenuItemClick);
            contextMenu.Items.Add("Clientes", null, MenuItemClick);
            contextMenu.Items.Add("Ingrediente", null, MenuItemClick);
            contextMenu.Items.Add("Sabor", null, MenuItemClick);
            contextMenu.Items.Add("Valor", null, MenuItemClick);
            contextMenu.Items.Add("Produto", null, MenuItemClick);
            contextMenu.Items.Add("Configurações", null, MenuItemClick);
            contextMenu.Items.Add("Sair", null, MenuItemClick);

            this.ContextMenuStrip = contextMenu;
        }

        private void MenuItemClick(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;

            switch (menuItem.Text)
            {
                case "Início":
                    // Lógica para lidar com a opção "Início"
                    break;

                case "Logradouro":
                    Logradouro LogradouroForm = new Logradouro();
                    LogradouroForm.ShowDialog();
                    break;

                case "Funcionários":
                    Funcionario FuncionariosForm = new Funcionario();
                    FuncionariosForm.ShowDialog();
                    break;

                case "Clientes":
                    Clientes ClientesForm = new Clientes();
                    ClientesForm.ShowDialog();
                    break;

                case "Ingrediente":
                    Ingredientes IngredientesForm = new Ingredientes();
                    IngredientesForm.ShowDialog();
                    break;

                case "Sabor":
                    Sabores SaboresForm = new Sabores();
                    SaboresForm.ShowDialog();
                    break;

                case "Valor":
                    Valor ValoresForm = new Valor();
                    ValoresForm.ShowDialog();
                    break;

                case "Produto":
                    Produtos ProdutosForm = new Produtos();
                    ProdutosForm.ShowDialog();
                    break;

                case "Configurações":
                    FormConfiguracoes config = new FormConfiguracoes()
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    _ = config.ShowDialog();
                    Controls.Clear();
                    InitializeComponent();
                    Funcoes.AjustaResourcesControl(this);
                    break;

                case "Sair":
                    Application.Exit();
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:


                        break;

                    case Keys.F2:

                        Logradouro LogradouroForm = new Logradouro();
                        LogradouroForm.ShowDialog();
                        break;

                    case Keys.F3:

                        Funcionario FuncionariosForm = new Funcionario();
                        FuncionariosForm.ShowDialog();
                        break;

                    case Keys.F4:

                        Clientes ClientesForm = new Clientes();
                        ClientesForm.ShowDialog();
                        break;

                    case Keys.F5:

                        Ingredientes IngredientesForm = new Ingredientes();
                        IngredientesForm.ShowDialog();
                        break;

                    case Keys.F6:

                        Sabores SaboresForm = new Sabores();
                        SaboresForm.ShowDialog();
                        break;

                    case Keys.F7:

                        Valor ValoresForm = new Valor();
                        ValoresForm.ShowDialog();
                        break;

                    case Keys.F8:

                        Produtos ProdutosForm = new Produtos();
                        ProdutosForm.ShowDialog();
                        break;

                    case Keys.F9:

                        FormConfiguracoes config = new FormConfiguracoes()
                        {
                            StartPosition = FormStartPosition.CenterScreen
                        };
                        _ = config.ShowDialog();
                        Controls.Clear();
                        InitializeComponent();
                        Funcoes.AjustaResourcesControl(this);
                        break;

                    case Keys.Delete:
                        // tratamento especifico para o atalho
                        e.Handled = true;
                        e.SuppressKeyPress = true;


                        CustomMessageBoxForm customMessageBox = new CustomMessageBoxForm();
                        customMessageBox.StartPosition = FormStartPosition.CenterScreen;
                        DialogResult result = customMessageBox.ShowDialog();

                        switch (result)
                        {
                            case DialogResult.Yes:
                                Application.Exit();
                                break;

                            case DialogResult.No:

                                break;

                            case DialogResult.Cancel:
                                this.WindowState = FormWindowState.Minimized;
                                break;
                        }
                        break;
                }
            }
        }


    }
}

