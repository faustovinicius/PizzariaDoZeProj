namespace PizzariaDoZeProj
{
    partial class Funcionario
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
            textID = new TextBox();
            LabelID = new Label();
            labelCPF = new Label();
            textBoxMatricula = new TextBox();
            LabelMatricula = new Label();
            radioButtonAdministrador = new RadioButton();
            radioButtonAtendente = new RadioButton();
            radioButtonEntregador = new RadioButton();
            labelGrupo = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelTelefone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
           
            textBoxCNH = new TextBox();
            labelCNH = new Label();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            textBoxObservacao = new TextBox();
            labelObservacao = new Label();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            labelFuncionarios = new Label();
            panel1 = new Panel();
            maskedTextBoxValidade = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            labelValidade = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textID
            // 
            textID.Location = new Point(0, 26);
            textID.Name = "textID";
            textID.Size = new Size(44, 23);
            textID.TabIndex = 0;
            
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(3, 7);
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
            labelCPF.Location = new Point(62, 71);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(36, 16);
            labelCPF.TabIndex = 1;
            labelCPF.Text = "CPF:";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(0, 119);
            textBoxMatricula.MaxLength = 15;
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(93, 23);
            textBoxMatricula.TabIndex = 4;
            // 
            // LabelMatricula
            // 
            LabelMatricula.AutoSize = true;
            LabelMatricula.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMatricula.ForeColor = Color.Firebrick;
            LabelMatricula.Location = new Point(3, 103);
            LabelMatricula.Name = "LabelMatricula";
            LabelMatricula.Size = new Size(66, 16);
            LabelMatricula.TabIndex = 4;
            LabelMatricula.Text = "Matrícula:";
            // 
            // radioButtonAdministrador
            // 
            radioButtonAdministrador.AutoSize = true;
            radioButtonAdministrador.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonAdministrador.ForeColor = Color.Firebrick;
            radioButtonAdministrador.Location = new Point(309, 90);
            radioButtonAdministrador.Name = "radioButtonAdministrador";
            radioButtonAdministrador.Size = new Size(106, 20);
            radioButtonAdministrador.TabIndex = 10;
            radioButtonAdministrador.TabStop = true;
            radioButtonAdministrador.Text = "Administrador";
            radioButtonAdministrador.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtendente
            // 
            radioButtonAtendente.AutoSize = true;
            radioButtonAtendente.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonAtendente.ForeColor = Color.Firebrick;
            radioButtonAtendente.Location = new Point(309, 144);
            radioButtonAtendente.Name = "radioButtonAtendente";
            radioButtonAtendente.Size = new Size(85, 20);
            radioButtonAtendente.TabIndex = 12;
            radioButtonAtendente.TabStop = true;
            radioButtonAtendente.Text = "Atendente";
            radioButtonAtendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntregador
            // 
            radioButtonEntregador.AutoSize = true;
            radioButtonEntregador.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonEntregador.ForeColor = Color.Firebrick;
            radioButtonEntregador.Location = new Point(309, 116);
            radioButtonEntregador.Name = "radioButtonEntregador";
            radioButtonEntregador.Size = new Size(90, 20);
            radioButtonEntregador.TabIndex = 11;
            radioButtonEntregador.TabStop = true;
            radioButtonEntregador.Text = "Entregador";
            radioButtonEntregador.UseVisualStyleBackColor = true;
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrupo.ForeColor = Color.Firebrick;
            labelGrupo.Location = new Point(297, 6);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(46, 16);
            labelGrupo.TabIndex = 10;
            labelGrupo.Text = "Grupo:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 141);
            textBoxNome.MaxLength = 15;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(279, 23);
            textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.Firebrick;
            labelNome.Location = new Point(12, 122);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(45, 16);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.ForeColor = Color.Firebrick;
            labelTelefone.Location = new Point(133, 7);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(61, 16);
            labelTelefone.TabIndex = 2;
            labelTelefone.Text = "Telefone:";
            labelTelefone.Click += labelTelefone_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(124, 183);
            textBoxEmail.MaxLength = 15;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(167, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Firebrick;
            labelEmail.Location = new Point(124, 167);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 16);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "E-mail:";
            // 
            
            // 
            // textBoxCNH
            // 
            textBoxCNH.Location = new Point(12, 228);
            textBoxCNH.MaxLength = 15;
            textBoxCNH.Name = "textBoxCNH";
            textBoxCNH.Size = new Size(124, 23);
            textBoxCNH.TabIndex = 6;
           
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCNH.ForeColor = Color.Firebrick;
            labelCNH.Location = new Point(12, 209);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(38, 16);
            labelCNH.TabIndex = 6;
            labelCNH.Text = "CNH:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(281, 164);
            textBoxSenha.MaxLength = 15;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(102, 23);
            textBoxSenha.TabIndex = 8;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = Color.Firebrick;
            labelSenha.Location = new Point(281, 145);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(47, 16);
            labelSenha.TabIndex = 8;
            labelSenha.Text = "Senha:";
            // 
            // textBoxObservacao
            // 
            textBoxObservacao.Location = new Point(13, 272);
            textBoxObservacao.MaxLength = 15;
            textBoxObservacao.Name = "textBoxObservacao";
            textBoxObservacao.Size = new Size(386, 23);
            textBoxObservacao.TabIndex = 9;
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObservacao.ForeColor = Color.Firebrick;
            labelObservacao.Location = new Point(12, 253);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(79, 16);
            labelObservacao.TabIndex = 9;
            labelObservacao.Text = "Observação:";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(501, 377);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 18;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(376, 377);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 17;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(251, 377);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 61);
            buttonSalvar.TabIndex = 16;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(421, 272);
            textBoxNumero.MaxLength = 15;
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(130, 23);
            textBoxNumero.TabIndex = 14;
            
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.ForeColor = Color.Firebrick;
            labelNumero.Location = new Point(421, 253);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(57, 16);
            labelNumero.TabIndex = 14;
            labelNumero.Text = "Número:";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(557, 272);
            textBoxComplemento.MaxLength = 15;
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(330, 23);
            textBoxComplemento.TabIndex = 15;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.ForeColor = Color.Firebrick;
            labelComplemento.Location = new Point(557, 253);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(92, 16);
            labelComplemento.TabIndex = 15;
            labelComplemento.Text = "Complemento:";
            // 
            // labelFuncionarios
            // 
            labelFuncionarios.AutoSize = true;
            labelFuncionarios.Font = new Font("Yu Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuncionarios.ForeColor = Color.Firebrick;
            labelFuncionarios.Location = new Point(13, 9);
            labelFuncionarios.Name = "labelFuncionarios";
            labelFuncionarios.Size = new Size(414, 44);
            labelFuncionarios.TabIndex = 0;
            labelFuncionarios.Text = "Cadastrar Funcionários:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logopizzaria;
            panel1.Controls.Add(maskedTextBoxValidade);
            panel1.Controls.Add(maskedTextBoxTelefone);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(labelGrupo);
            panel1.Controls.Add(textID);
            panel1.Controls.Add(LabelID);
            panel1.Controls.Add(textBoxMatricula);
            panel1.Controls.Add(labelTelefone);
            panel1.Controls.Add(LabelMatricula);
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(labelSenha);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 231);
            panel1.TabIndex = 0;
            
            // 
            // maskedTextBoxValidade
            // 
            maskedTextBoxValidade.Location = new Point(130, 164);
            maskedTextBoxValidade.Mask = "00/00/0000";
            maskedTextBoxValidade.Name = "maskedTextBoxValidade";
            maskedTextBoxValidade.Size = new Size(145, 23);
            maskedTextBoxValidade.TabIndex = 7;
            maskedTextBoxValidade.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(133, 26);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(146, 23);
            maskedTextBoxTelefone.TabIndex = 2;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(50, 25);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(77, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelValidade
            // 
            labelValidade.AutoSize = true;
            labelValidade.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidade.ForeColor = Color.Firebrick;
            labelValidade.Location = new Point(142, 209);
            labelValidade.Name = "labelValidade";
            labelValidade.Size = new Size(60, 16);
            labelValidade.TabIndex = 7;
            labelValidade.Text = "Validade:";
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(899, 450);
            Controls.Add(labelFuncionarios);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelNumero);
            Controls.Add(textBoxNumero);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelObservacao);
            Controls.Add(textBoxObservacao);
            Controls.Add(labelValidade);
            Controls.Add(labelCNH);
            Controls.Add(textBoxCNH);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(radioButtonEntregador);
            Controls.Add(radioButtonAtendente);
            Controls.Add(radioButtonAdministrador);
            Controls.Add(labelCPF);
        
            Controls.Add(panel1);
            Name = "Funcionario";
            Text = "Funcionarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        public TextBox textID;
        public Label LabelID;
        public Label labelCPF;
        public TextBox textBoxMatricula;
        public Label LabelMatricula;
        private Label labelGrupo;
        public TextBox textBoxNome;
        public Label labelNome;
        public TextBox textBoxTelefone;
        public Label labelTelefone;
        public TextBox textBoxEmail;
        public Label labelEmail;
       
        public TextBox textBoxCNH;
        public Label labelCNH;
        public TextBox textBox1;
        public TextBox textBoxSenha;
        public Label labelSenha;
        public TextBox textBoxObservacao;
        public Label labelObservacao;
        public Button buttonExcluir;
        public Button buttonEditar;
        public Button buttonSalvar;
        public TextBox textBoxNumero;
        public Label labelNumero;
        public TextBox textBoxComplemento;
        public Label labelComplemento;
        public Label labelFuncionarios;
        private Panel panel1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        public MaskedTextBox maskedTextBoxTelefone;
        public MaskedTextBox maskedTextBox1;
        public RadioButton radioButtonAdministrador;
        public RadioButton radioButtonAtendente;
        public RadioButton radioButtonEntregador;
        public Label labelValidade;
        public MaskedTextBox maskedTextBoxValidade;
    }
}