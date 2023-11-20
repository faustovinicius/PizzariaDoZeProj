namespace PizzariaDoZeProj
{
    partial class Produtos
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
            labelProdutos = new Label();
            textID = new TextBox();
            LabelID = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            labelML = new Label();
            panel2 = new Panel();
            labelTipo = new Label();
            labelValor = new Label();
            label1 = new Label();
            textBoxValor = new TextBox();
            labelNome = new Label();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            maskedTextBoxValor = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelProdutos.ForeColor = Color.Firebrick;
            labelProdutos.Location = new Point(11, 7);
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(281, 35);
            labelProdutos.TabIndex = 72;
            labelProdutos.Text = "Cadastrar Produtos:";
            // 
            // textID
            // 
            textID.Location = new Point(29, 82);
            textID.Name = "textID";
            textID.Size = new Size(58, 23);
            textID.TabIndex = 0;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(29, 63);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 16);
            LabelID.TabIndex = 70;
            LabelID.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logopizzaria;
            panel1.Controls.Add(maskedTextBoxValor);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(labelML);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelTipo);
            panel1.Controls.Add(labelValor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxValor);
            panel1.Controls.Add(labelNome);
            panel1.Location = new Point(11, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 229);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(326, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 173);
            panel3.TabIndex = 11;
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.ForeColor = Color.Firebrick;
            labelML.Location = new Point(326, 15);
            labelML.Name = "labelML";
            labelML.Size = new Size(29, 16);
            labelML.TabIndex = 68;
            labelML.Text = "ML:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(179, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 174);
            panel2.TabIndex = 10;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.ForeColor = Color.Firebrick;
            labelTipo.Location = new Point(179, 15);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(36, 16);
            labelTipo.TabIndex = 66;
            labelTipo.Text = "Tipo:";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.ForeColor = Color.Firebrick;
            labelValor.Location = new Point(18, 154);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(41, 16);
            labelValor.TabIndex = 64;
            labelValor.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(60, 260);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 63;
            label1.Text = "Valor:";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(18, 106);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(152, 23);
            textBoxValor.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.Firebrick;
            labelNome.Location = new Point(18, 87);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(45, 16);
            labelNome.TabIndex = 43;
            labelNome.Text = "Nome:";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(316, 283);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 5;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(179, 286);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(44, 286);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 61);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(18, 173);
            maskedTextBoxValor.Mask = "$ 999,999.00";
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(152, 23);
            maskedTextBoxValor.TabIndex = 3;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 355);
            Controls.Add(labelProdutos);
            Controls.Add(textID);
            Controls.Add(LabelID);
            Controls.Add(panel1);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Name = "Produtos";
            Text = "Produtos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelProdutos;
        public TextBox textID;
        public Label LabelID;
        private Panel panel1;
        private Panel panel3;
        public Label labelML;
        private Panel panel2;
        public Label labelTipo;
        public Label labelValor;
        public Label label1;
        public TextBox textBoxValor;
        public Label labelNome;
        public Button buttonExcluir;
        public Button buttonEditar;
        public Button buttonSalvar;
        public MaskedTextBox maskedTextBoxValor;
    }
}