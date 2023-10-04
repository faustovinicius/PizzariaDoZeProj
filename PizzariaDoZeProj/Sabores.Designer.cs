namespace PizzariaDoZeProj
{
    partial class Sabores
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
            labelSabores = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            labelFoto = new Label();
            panel4 = new Panel();
            labelTipo = new Label();
            panel3 = new Panel();
            labelCategoria = new Label();
            LabelListaIngredientes = new Label();
            panel2 = new Panel();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textID = new TextBox();
            LabelID = new Label();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSabores
            // 
            labelSabores.AutoSize = true;
            labelSabores.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabores.ForeColor = Color.Firebrick;
            labelSabores.Location = new Point(12, 9);
            labelSabores.Name = "labelSabores";
            labelSabores.Size = new Size(269, 35);
            labelSabores.TabIndex = 60;
            labelSabores.Text = "Cadastrar Sabores:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logopizzaria;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(labelFoto);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(labelTipo);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(labelCategoria);
            panel1.Controls.Add(LabelListaIngredientes);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(textID);
            panel1.Controls.Add(LabelID);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 353);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Location = new Point(18, 239);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 111);
            panel5.TabIndex = 5;
            // 
            // labelFoto
            // 
            labelFoto.AutoSize = true;
            labelFoto.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFoto.ForeColor = Color.Firebrick;
            labelFoto.Location = new Point(30, 220);
            labelFoto.Name = "labelFoto";
            labelFoto.Size = new Size(38, 16);
            labelFoto.TabIndex = 51;
            labelFoto.Text = "Foto:";
            labelFoto.Click += labelFoto_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(153, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(116, 53);
            panel4.TabIndex = 3;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.ForeColor = Color.Firebrick;
            labelTipo.Location = new Point(153, 146);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(36, 16);
            labelTipo.TabIndex = 49;
            labelTipo.Text = "Tipo:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(30, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(117, 52);
            panel3.TabIndex = 2;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.ForeColor = Color.Firebrick;
            labelCategoria.Location = new Point(30, 146);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(68, 16);
            labelCategoria.TabIndex = 47;
            labelCategoria.Text = "Categoria:";
            // 
            // LabelListaIngredientes
            // 
            LabelListaIngredientes.AutoSize = true;
            LabelListaIngredientes.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelListaIngredientes.ForeColor = Color.Firebrick;
            LabelListaIngredientes.Location = new Point(286, 0);
            LabelListaIngredientes.Name = "LabelListaIngredientes";
            LabelListaIngredientes.Size = new Size(83, 16);
            LabelListaIngredientes.TabIndex = 46;
            LabelListaIngredientes.Text = "Ingredientes:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(286, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 242);
            panel2.TabIndex = 4;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(30, 120);
            textBoxNome.MaxLength = 15;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(239, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.Firebrick;
            labelNome.Location = new Point(30, 101);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(45, 16);
            labelNome.TabIndex = 43;
            labelNome.Text = "Nome:";
            // 
            // textID
            // 
            textID.Location = new Point(30, 46);
            textID.Name = "textID";
            textID.Size = new Size(58, 23);
            textID.TabIndex = 0;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(30, 27);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 16);
            LabelID.TabIndex = 41;
            LabelID.Text = "ID:";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(284, 403);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 8;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(147, 406);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 7;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(12, 406);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 61);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // Sabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(415, 479);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(panel1);
            Controls.Add(labelSabores);
            Name = "Sabores";
            Text = "Sabores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelSabores;
        private Panel panel1;
        public Label LabelID;
        public TextBox textID;
        public Label labelNome;
        private Panel panel2;
        public TextBox textBoxNome;
        public Label labelTipo;
        private Panel panel3;
        public Label labelCategoria;
        public Label LabelListaIngredientes;
        private Panel panel5;
        public Label labelFoto;
        private Panel panel4;
        public Button buttonExcluir;
        public Button buttonEditar;
        public Button buttonSalvar;
    }
}