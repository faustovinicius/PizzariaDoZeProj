namespace PizzariaDoZeProj
{
    partial class Valores
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
            labelValores = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            labelCategoria = new Label();
            panel2 = new Panel();
            labelTamanho = new Label();
            labelValorBorda = new Label();
            label1 = new Label();
            labelValor = new Label();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            maskedTextBoxValor = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textID
            // 
            textID.Location = new Point(30, 89);
            textID.Name = "textID";
            textID.Size = new Size(58, 23);
            textID.TabIndex = 0;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(30, 70);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 16);
            LabelID.TabIndex = 42;
            LabelID.Text = "ID:";
            // 
            // labelValores
            // 
            labelValores.AutoSize = true;
            labelValores.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelValores.ForeColor = Color.Firebrick;
            labelValores.Location = new Point(12, 14);
            labelValores.Name = "labelValores";
            labelValores.Size = new Size(260, 35);
            labelValores.TabIndex = 60;
            labelValores.Text = "Cadastrar Valores:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logopizzaria;
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(maskedTextBoxValor);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(labelCategoria);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelTamanho);
            panel1.Controls.Add(labelValorBorda);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelValor);
            panel1.Location = new Point(12, 55);
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
            panel3.TabIndex = 4;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.ForeColor = Color.Firebrick;
            labelCategoria.Location = new Point(326, 15);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(68, 16);
            labelCategoria.TabIndex = 68;
            labelCategoria.Text = "Categoria:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(179, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 174);
            panel2.TabIndex = 3;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanho.ForeColor = Color.Firebrick;
            labelTamanho.Location = new Point(179, 15);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(64, 16);
            labelTamanho.TabIndex = 66;
            labelTamanho.Text = "Tamanho:";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorBorda.ForeColor = Color.Firebrick;
            labelValorBorda.Location = new Point(18, 154);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(134, 16);
            labelValorBorda.TabIndex = 64;
            labelValorBorda.Text = "Valor Adicional Borda:";
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
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.ForeColor = Color.Firebrick;
            labelValor.Location = new Point(18, 87);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(41, 16);
            labelValor.TabIndex = 43;
            labelValor.Text = "Valor:";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(317, 290);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 7;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(180, 293);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 6;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(45, 293);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 61);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(18, 106);
            maskedTextBoxValor.Mask = "$ 999,999.00";
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(152, 23);
            maskedTextBoxValor.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(18, 173);
            maskedTextBox1.Mask = "$ 999,999.00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(152, 23);
            maskedTextBox1.TabIndex = 2;
            // 
            // Valores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(494, 355);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelValores);
            Controls.Add(textID);
            Controls.Add(LabelID);
            Controls.Add(panel1);
            Name = "Valores";
            Text = "Valores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textID;
        public Label LabelID;
        public Label labelValores;
        private Panel panel1;
        public Label labelValor;
        public Label labelValorBorda;
        public Label label1;
        private Panel panel3;
        public Label labelCategoria;
        private Panel panel2;
        public Label labelTamanho;
        public Button buttonExcluir;
        public Button buttonEditar;
        public Button buttonSalvar;
        public MaskedTextBox maskedTextBoxValor;
        public MaskedTextBox maskedTextBox1;
    }
}