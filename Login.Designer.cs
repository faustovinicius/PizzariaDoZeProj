namespace PizzariaDoZeProj
{
    partial class Login
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
            labelUsuario = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelSenha = new Label();
            ButtonEndereco = new Button();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Firebrick;
            labelUsuario.Location = new Point(271, 141);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(51, 16);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuário";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 1;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = Color.Firebrick;
            labelSenha.Location = new Point(271, 196);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(43, 16);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha";
            labelSenha.Click += label2_Click;
            // 
            // ButtonEndereco
            // 
            ButtonEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonEndereco.BackColor = Color.Firebrick;
            ButtonEndereco.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEndereco.ForeColor = Color.White;
            ButtonEndereco.Location = new Point(350, 257);
            ButtonEndereco.Name = "ButtonEndereco";
            ButtonEndereco.Size = new Size(111, 61);
            ButtonEndereco.TabIndex = 2;
            ButtonEndereco.Text = "Login";
            ButtonEndereco.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logopizzaria;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonEndereco);
            Controls.Add(textBox2);
            Controls.Add(labelSenha);
            Controls.Add(textBox1);
            Controls.Add(labelUsuario);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelSenha;
        private Button ButtonEndereco;
    }
}