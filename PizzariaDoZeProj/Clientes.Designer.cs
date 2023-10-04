namespace PizzariaDoZeProj
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            userControlLogradouro1 = new UserControlLogradouro();
            textID = new TextBox();
            LabelID = new Label();
            labelCPF = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelTelefone = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelComplemento = new Label();
            textBoxComplemento = new TextBox();
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            labelClientes = new Label();
            panel1 = new Panel();
            textBoxTelefone = new MaskedTextBox();
            textBoxCPF = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userControlLogradouro1
            // 
            userControlLogradouro1.BackgroundImage = (Image)resources.GetObject("userControlLogradouro1.BackgroundImage");
            userControlLogradouro1.Location = new Point(307, 28);
            userControlLogradouro1.Name = "userControlLogradouro1";
            userControlLogradouro1.Size = new Size(481, 153);
            userControlLogradouro1.TabIndex = 5;
            // 
            // textID
            // 
            textID.Location = new Point(13, 66);
            textID.Name = "textID";
            textID.Size = new Size(44, 23);
            textID.TabIndex = 0;
            textID.KeyPress += textID_KeyPress;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(13, 49);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 16);
            LabelID.TabIndex = 0;
            LabelID.Text = "ID:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.ForeColor = Color.Firebrick;
            labelCPF.Location = new Point(51, 2);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(36, 16);
            labelCPF.TabIndex = 1;
            labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.Firebrick;
            labelNome.Location = new Point(12, 92);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(45, 16);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(0, 64);
            textBoxNome.MaxLength = 15;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(279, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.ForeColor = Color.Firebrick;
            labelTelefone.Location = new Point(13, 138);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(61, 16);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Firebrick;
            labelEmail.Location = new Point(112, 90);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 16);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(124, 157);
            textBoxEmail.MaxLength = 15;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(167, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.ForeColor = Color.Firebrick;
            labelComplemento.Location = new Point(443, 199);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(92, 16);
            labelComplemento.TabIndex = 6;
            labelComplemento.Text = "Complemento:";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(443, 218);
            textBoxComplemento.MaxLength = 15;
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(330, 23);
            textBoxComplemento.TabIndex = 7;
            textBoxComplemento.TextChanged += textBoxComplemento_TextChanged;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.ForeColor = Color.Firebrick;
            labelNumero.Location = new Point(307, 199);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(57, 16);
            labelNumero.TabIndex = 5;
            labelNumero.Text = "Número:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(307, 218);
            textBoxNumero.MaxLength = 6;
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(130, 23);
            textBoxNumero.TabIndex = 6;
            textBoxNumero.KeyPress += textBoxNumero_KeyPress;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(453, 339);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 10;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(307, 339);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 9;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(161, 339);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 61);
            buttonSalvar.TabIndex = 8;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientes.ForeColor = Color.Firebrick;
            labelClientes.Location = new Point(12, 3);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(269, 35);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Cadastrar Clientes:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logopizzaria;
            panel1.Controls.Add(textBoxTelefone);
            panel1.Controls.Add(textBoxCPF);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(labelCPF);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 133);
            panel1.TabIndex = 0;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(0, 110);
            textBoxTelefone.Mask = "(00) 00000-0000";
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(106, 23);
            textBoxTelefone.TabIndex = 3;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(51, 19);
            textBoxCPF.Mask = "000.000.000-00";
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(77, 23);
            textBoxCPF.TabIndex = 1;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(800, 450);
            Controls.Add(labelClientes);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelNumero);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Controls.Add(textID);
            Controls.Add(LabelID);
            Controls.Add(userControlLogradouro1);
            Controls.Add(panel1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControlLogradouro userControlLogradouro1;
        public TextBox textID;
        public Label LabelID;
        public Label labelCPF;
        public Label labelNome;
        public TextBox textBoxNome;
        public Label labelTelefone;
        public Label labelEmail;
        public TextBox textBoxEmail;
        public Label labelComplemento;
        public TextBox textBoxComplemento;
        public Label labelNumero;
        public TextBox textBoxNumero;
        public Button buttonExcluir;
        public Button buttonEditar;
        public Button buttonSalvar;
        public Label labelClientes;
        private Panel panel1;
        private MaskedTextBox textBoxCPF;
        public MaskedTextBox textBoxTelefone;
    }
}