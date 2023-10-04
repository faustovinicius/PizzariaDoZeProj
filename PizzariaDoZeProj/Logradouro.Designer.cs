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
            userControlLogradouro1 = new UserControlLogradouro();
            buttonExcluir = new Button();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSalvar.BackColor = Color.DarkRed;
            buttonSalvar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(212, 334);
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
            buttonEditar.Location = new Point(337, 334);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 61);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // userControlLogradouro1
            // 
            userControlLogradouro1.BackgroundImage = (Image)resources.GetObject("userControlLogradouro1.BackgroundImage");
            userControlLogradouro1.Location = new Point(164, 131);
            userControlLogradouro1.Name = "userControlLogradouro1";
            userControlLogradouro1.Size = new Size(466, 153);
            userControlLogradouro1.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonExcluir.BackColor = Color.DarkRed;
            buttonExcluir.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.Location = new Point(462, 334);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(119, 61);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // Logradouro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlLogradouro1);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Name = "Logradouro";
            Text = "Logradouro";
            ResumeLayout(false);
        }

        #endregion
        public Button buttonSalvar;
        public Button buttonEditar;
        private UserControlLogradouro userControlLogradouro1;
        public Button buttonExcluir;
    }
}