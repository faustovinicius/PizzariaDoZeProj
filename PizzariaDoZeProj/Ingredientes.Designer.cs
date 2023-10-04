namespace PizzariaDoZeProj
{
    partial class Ingredientes
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
            labelIngredientes = new Label();
            panel1 = new Panel();
            textBoxID = new TextBox();
            LabelID = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            buttonSalvar = new Button();
            ButtonBuscar = new Button();
            textBoxFiltro = new TextBox();
            dataGridViewDados = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Yu Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngredientes.ForeColor = Color.Firebrick;
            labelIngredientes.Location = new Point(38, 9);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(328, 35);
            labelIngredientes.TabIndex = 59;
            labelIngredientes.Text = "Cadastrar Ingredientes:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logopizzaria;
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(LabelID);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(textBoxNome);
            panel1.Location = new Point(38, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 113);
            panel1.TabIndex = 0;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(39, 47);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(58, 23);
            textBoxID.TabIndex = 0;
            textBoxID.KeyPress += TextBoxID_KeyPress;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelID.ForeColor = Color.Firebrick;
            LabelID.Location = new Point(39, 28);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(24, 16);
            LabelID.TabIndex = 40;
            LabelID.Text = "ID:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.Firebrick;
            labelNome.Location = new Point(118, 28);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(45, 16);
            labelNome.TabIndex = 38;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(118, 47);
            textBoxNome.MaxLength = 15;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(337, 23);
            textBoxNome.TabIndex = 1;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(348, 184);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 59);
            buttonExcluir.TabIndex = 4;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(223, 184);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 59);
            buttonEditar.TabIndex = 3;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(98, 184);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 59);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += ButtonSalvar_Click;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonBuscar.BackColor = Color.DarkRed;
            ButtonBuscar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBuscar.ForeColor = Color.White;
            ButtonBuscar.Location = new Point(395, 276);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(119, 30);
            ButtonBuscar.TabIndex = 5;
            ButtonBuscar.Text = "Buscar";
            ButtonBuscar.UseVisualStyleBackColor = false;
            ButtonBuscar.Click += ButtonBuscar_Click;
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(77, 280);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(312, 23);
            textBoxFiltro.TabIndex = 6;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(77, 309);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(201, 117);
            dataGridViewDados.TabIndex = 60;
            // 
            // Ingredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(551, 438);
            Controls.Add(dataGridViewDados);
            Controls.Add(textBoxFiltro);
            Controls.Add(ButtonBuscar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(panel1);
            Controls.Add(labelIngredientes);
            Name = "Ingredientes";
            Text = "Ingredientes";
            Load += Ingredientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelIngredientes;
        private Panel panel1;
        public TextBox textBoxNome;
        public Label labelNome;
        public Label LabelID;
        public TextBox textBoxID;
        public Button buttonExcluir;
        public Button buttonEditar;
        public Button buttonSalvar;
        public Button ButtonBuscar;
        private TextBox textBoxFiltro;
        private DataGridView dataGridViewDados;
    }
}