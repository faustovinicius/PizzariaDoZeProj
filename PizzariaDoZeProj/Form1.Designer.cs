namespace PizzariaDoZeProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ButtonEndereco = new Button();
            ButtonFuncionarios = new Button();
            ButtonIngredientes = new Button();
            ButtonClientes = new Button();
            ButtonSabores = new Button();
            ButtonValores = new Button();
            ButtonProdutos = new Button();
            ButtonLogin = new Button();
            buttonConfiguracoes = new Button();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            AbrirAplicacao = new ToolStripMenuItem();
            Encerrar = new ToolStripMenuItem();
            Sobre = new ToolStripMenuItem();
            contextMenuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonEndereco
            // 
            ButtonEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonEndereco.BackColor = Color.DarkRed;
            ButtonEndereco.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEndereco.ForeColor = Color.White;
            ButtonEndereco.Location = new Point(12, 31);
            ButtonEndereco.Name = "ButtonEndereco";
            ButtonEndereco.Size = new Size(178, 61);
            ButtonEndereco.TabIndex = 0;
            ButtonEndereco.Text = "Endereço";
            ButtonEndereco.UseVisualStyleBackColor = false;
            ButtonEndereco.Click += buttonEndereco_Click;
            // 
            // ButtonFuncionarios
            // 
            ButtonFuncionarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonFuncionarios.BackColor = Color.DarkRed;
            ButtonFuncionarios.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonFuncionarios.ForeColor = Color.White;
            ButtonFuncionarios.Location = new Point(610, 98);
            ButtonFuncionarios.Name = "ButtonFuncionarios";
            ButtonFuncionarios.Size = new Size(178, 61);
            ButtonFuncionarios.TabIndex = 7;
            ButtonFuncionarios.Text = "Funcionários";
            ButtonFuncionarios.UseVisualStyleBackColor = false;
            ButtonFuncionarios.Click += ButtonFuncionarios_Click;
            // 
            // ButtonIngredientes
            // 
            ButtonIngredientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonIngredientes.BackColor = Color.DarkRed;
            ButtonIngredientes.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonIngredientes.ForeColor = Color.White;
            ButtonIngredientes.Location = new Point(12, 299);
            ButtonIngredientes.Name = "ButtonIngredientes";
            ButtonIngredientes.Size = new Size(178, 61);
            ButtonIngredientes.TabIndex = 4;
            ButtonIngredientes.Text = "Ingredientes";
            ButtonIngredientes.UseVisualStyleBackColor = false;
            ButtonIngredientes.Click += ButtonIngredientes_Click;
            // 
            // ButtonClientes
            // 
            ButtonClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonClientes.BackColor = Color.DarkRed;
            ButtonClientes.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonClientes.ForeColor = Color.White;
            ButtonClientes.Location = new Point(12, 366);
            ButtonClientes.Name = "ButtonClientes";
            ButtonClientes.Size = new Size(178, 61);
            ButtonClientes.TabIndex = 5;
            ButtonClientes.Text = "Clientes";
            ButtonClientes.UseVisualStyleBackColor = false;
            ButtonClientes.Click += ButtonClientes_Click;
            // 
            // ButtonSabores
            // 
            ButtonSabores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSabores.BackColor = Color.DarkRed;
            ButtonSabores.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSabores.ForeColor = Color.White;
            ButtonSabores.Location = new Point(12, 98);
            ButtonSabores.Name = "ButtonSabores";
            ButtonSabores.Size = new Size(178, 61);
            ButtonSabores.TabIndex = 1;
            ButtonSabores.Text = "Sabores";
            ButtonSabores.UseVisualStyleBackColor = false;
            ButtonSabores.Click += ButtonSabores_Click;
            // 
            // ButtonValores
            // 
            ButtonValores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonValores.BackColor = Color.DarkRed;
            ButtonValores.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonValores.ForeColor = Color.White;
            ButtonValores.Location = new Point(12, 165);
            ButtonValores.Name = "ButtonValores";
            ButtonValores.Size = new Size(178, 61);
            ButtonValores.TabIndex = 2;
            ButtonValores.Text = "Valores Pizza";
            ButtonValores.UseVisualStyleBackColor = false;
            ButtonValores.Click += ButtonValores_Click;
            // 
            // ButtonProdutos
            // 
            ButtonProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonProdutos.BackColor = Color.DarkRed;
            ButtonProdutos.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonProdutos.ForeColor = Color.White;
            ButtonProdutos.Location = new Point(12, 232);
            ButtonProdutos.Name = "ButtonProdutos";
            ButtonProdutos.Size = new Size(178, 61);
            ButtonProdutos.TabIndex = 3;
            ButtonProdutos.Text = "Produtos";
            ButtonProdutos.UseVisualStyleBackColor = false;
            ButtonProdutos.Click += ButtonProdutos_Click;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonLogin.BackColor = Color.DarkRed;
            ButtonLogin.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(610, 31);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(178, 61);
            ButtonLogin.TabIndex = 6;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // buttonConfiguracoes
            // 
            buttonConfiguracoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfiguracoes.BackColor = Color.DarkRed;
            buttonConfiguracoes.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfiguracoes.ForeColor = Color.White;
            buttonConfiguracoes.Location = new Point(610, 366);
            buttonConfiguracoes.Name = "buttonConfiguracoes";
            buttonConfiguracoes.Size = new Size(178, 61);
            buttonConfiguracoes.TabIndex = 8;
            buttonConfiguracoes.Text = "Configurações";
            buttonConfiguracoes.UseVisualStyleBackColor = false;
            buttonConfiguracoes.Click += ButtonConfiguracoes_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripPrincipal;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            notifyIconSystemTray.MouseDoubleClick += NotifyIconSystemTray_MouseDoubleClick;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { AbrirAplicacao, Encerrar, Sobre });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(181, 92);
            contextMenuStripPrincipal.Text = "Menu";
            // 
            // AbrirAplicacao
            // 
            AbrirAplicacao.Name = "AbrirAplicacao";
            AbrirAplicacao.Size = new Size(180, 22);
            AbrirAplicacao.Text = "Abrir Aplicação";
            AbrirAplicacao.Click += abrirAplicaçãoToolStripMenuItem_Click;
            // 
            // Encerrar
            // 
            Encerrar.Name = "Encerrar";
            Encerrar.Size = new Size(180, 22);
            Encerrar.Text = "Encerrar";
            Encerrar.Click += encerrarToolStripMenuItem_Click;
            // 
            // Sobre
            // 
            Sobre.Name = "Sobre";
            Sobre.Size = new Size(180, 22);
            Sobre.Text = "Sobre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfiguracoes);
            Controls.Add(ButtonLogin);
            Controls.Add(ButtonProdutos);
            Controls.Add(ButtonValores);
            Controls.Add(ButtonSabores);
            Controls.Add(ButtonClientes);
            Controls.Add(ButtonIngredientes);
            Controls.Add(ButtonFuncionarios);
            Controls.Add(ButtonEndereco);
            Name = "Form1";
            Text = "Pizzaria do Zé";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            Resize += Form1_Resize;
            contextMenuStripPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonEndereco;
        private Button ButtonFuncionarios;
        private Button ButtonIngredientes;
        private Button ButtonClientes;
        private Button ButtonSabores;
        private Button ButtonValores;
        private Button ButtonProdutos;
        private Button ButtonLogin;
        private Button buttonConfiguracoes;
        public NotifyIcon notifyIconSystemTray;
        public ContextMenuStrip contextMenuStripPrincipal;
        public ToolStripMenuItem AbrirAplicacao;
        public ToolStripMenuItem Encerrar;
        public ToolStripMenuItem Sobre;
    }
}