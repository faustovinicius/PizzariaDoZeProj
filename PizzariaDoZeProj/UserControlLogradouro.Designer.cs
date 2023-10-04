namespace PizzariaDoZeProj
{
    partial class UserControlLogradouro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBoxCidade = new ComboBox();
            ComboBoxPais = new ComboBox();
            LabelPais = new Label();
            ComboBoxEstado = new ComboBox();
            textBairro = new TextBox();
            LabelBairro = new Label();
            LabelCidade = new Label();
            LabelEstado = new Label();
            TextLogradouro = new TextBox();
            LabelLogradouro = new Label();
            LabelCEP = new Label();
            textID = new TextBox();
            LabelID = new Label();
            textCep = new MaskedTextBox();
            SuspendLayout();
            // 
            // ComboBoxCidade
            // 
            ComboBoxCidade.FormattingEnabled = true;
            ComboBoxCidade.Location = new Point(2, 127);
            ComboBoxCidade.Name = "ComboBoxCidade";
            ComboBoxCidade.Size = new Size(186, 23);
            ComboBoxCidade.TabIndex = 5;
            // 
            // ComboBoxPais
            // 
            ComboBoxPais.FormattingEnabled = true;
            ComboBoxPais.Location = new Point(2, 72);
            ComboBoxPais.Name = "ComboBoxPais";
            ComboBoxPais.Size = new Size(310, 23);
            ComboBoxPais.TabIndex = 3;
            // 
            // LabelPais
            // 
            LabelPais.AutoSize = true;
            LabelPais.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPais.ForeColor = Color.Firebrick;
            LabelPais.Location = new Point(2, 53);
            LabelPais.Name = "LabelPais";
            LabelPais.Size = new Size(35, 16);
            LabelPais.TabIndex = 35;
            LabelPais.Text = "País:";
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(318, 72);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(145, 23);
            ComboBoxEstado.TabIndex = 4;
            // 
            // textBairro
            // 
            textBairro.Location = new Point(194, 127);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(269, 23);
            textBairro.TabIndex = 6;
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBairro.ForeColor = Color.Firebrick;
            LabelBairro.Location = new Point(194, 108);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(47, 16);
            LabelBairro.TabIndex = 32;
            LabelBairro.Text = "Bairro:";
            // 
            // LabelCidade
            // 
            LabelCidade.AutoSize = true;
            LabelCidade.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCidade.ForeColor = Color.Firebrick;
            LabelCidade.Location = new Point(2, 108);
            LabelCidade.Name = "LabelCidade";
            LabelCidade.Size = new Size(51, 16);
            LabelCidade.TabIndex = 31;
            LabelCidade.Text = "Cidade:";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelEstado.ForeColor = Color.Firebrick;
            LabelEstado.Location = new Point(318, 53);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(51, 16);
            LabelEstado.TabIndex = 30;
            LabelEstado.Text = "Estado:";
            // 
            // TextLogradouro
            // 
            TextLogradouro.Location = new Point(194, 20);
            TextLogradouro.Name = "TextLogradouro";
            TextLogradouro.Size = new Size(269, 23);
            TextLogradouro.TabIndex = 2;
            // 
            // LabelLogradouro
            // 
            LabelLogradouro.AutoSize = true;
            LabelLogradouro.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLogradouro.ForeColor = Color.Firebrick;
            LabelLogradouro.Location = new Point(194, 1);
            LabelLogradouro.Name = "LabelLogradouro";
            LabelLogradouro.Size = new Size(77, 16);
            LabelLogradouro.TabIndex = 28;
            LabelLogradouro.Text = "Logradouro:";
            // 
            // LabelCEP
            // 
            LabelCEP.AutoSize = true;
            LabelCEP.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelCEP.ForeColor = Color.Firebrick;
            LabelCEP.Location = new Point(61, 1);
            LabelCEP.Name = "LabelCEP";
            LabelCEP.Size = new Size(36, 16);
            LabelCEP.TabIndex = 26;
            LabelCEP.Text = "CEP:";
            // 
            // textID
            // 
            textID.Location = new Point(2, 20);
            textID.Name = "textID";
            textID.Size = new Size(53, 23);
            textID.TabIndex = 0;
            textID.KeyPress += textID_KeyPress;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(2, 1);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 16);
            LabelID.TabIndex = 24;
            LabelID.Text = "ID:";
            // 
            // textCep
            // 
            textCep.Location = new Point(61, 20);
            textCep.Mask = "00000-000";
            textCep.Name = "textCep";
            textCep.Size = new Size(127, 23);
            textCep.TabIndex = 1;
            // 
            // UserControlLogradouro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            Controls.Add(textCep);
            Controls.Add(ComboBoxCidade);
            Controls.Add(ComboBoxPais);
            Controls.Add(LabelPais);
            Controls.Add(ComboBoxEstado);
            Controls.Add(textBairro);
            Controls.Add(LabelBairro);
            Controls.Add(LabelCidade);
            Controls.Add(LabelEstado);
            Controls.Add(TextLogradouro);
            Controls.Add(LabelLogradouro);
            Controls.Add(LabelCEP);
            Controls.Add(textID);
            Controls.Add(LabelID);
            Name = "UserControlLogradouro";
            Size = new Size(481, 153);
            Load += UserControlLogradouro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label LabelPais;
        public TextBox textBairro;
        public Label LabelBairro;
        public Label LabelCidade;
        public Label LabelEstado;
        public TextBox TextLogradouro;
        public Label LabelLogradouro;
        public Label LabelCEP;
        public TextBox textID;
        public Label LabelID;
        public MaskedTextBox textCep;
        public ComboBox ComboBoxCidade;
        public ComboBox ComboBoxPais;
        public ComboBox ComboBoxEstado;
    }
}
