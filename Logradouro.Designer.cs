namespace PizzariaDoZeProj
{
    partial class Logradouro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logradouro));
            buttonSalvar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            ButtonBuscar = new Button();
            textBoxFiltro = new TextBox();
            dataGridViewDados = new DataGridView();
            userControlEndereco1 = new userControlLogradouro();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(212, 377);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(119, 61);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditar.BackColor = Color.DarkRed;
            buttonEditar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(337, 377);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(462, 377);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Location = new Point(549, 188);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(75, 23);
            ButtonBuscar.TabIndex = 4;
            ButtonBuscar.Text = "Procurar";
            ButtonBuscar.UseVisualStyleBackColor = true;
            ButtonBuscar.Click += ButtonBuscar_Click;
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(158, 189);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(385, 23);
            textBoxFiltro.TabIndex = 5;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(158, 218);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(466, 150);
            dataGridViewDados.TabIndex = 6;
            // 
            // userControlEndereco1
            // 
            userControlEndereco1.BackgroundImage = (Image)resources.GetObject("userControlEndereco1.BackgroundImage");
            userControlEndereco1.Location = new Point(158, 29);
            userControlEndereco1.Name = "userControlEndereco1";
            userControlEndereco1.Size = new Size(466, 153);
            userControlEndereco1.TabIndex = 7;
            // 
            // Logradouro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlEndereco1);
            Controls.Add(dataGridViewDados);
            Controls.Add(textBoxFiltro);
            Controls.Add(ButtonBuscar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Name = "Logradouro";
            Text = "Logradouro";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonSalvar;
        public Button buttonEditar;

        public Button buttonExcluir;
        private Button ButtonBuscar;
        private TextBox textBoxFiltro;
        private DataGridView dataGridViewDados;
        private userControlLogradouro userControlEndereco1;
    }
}