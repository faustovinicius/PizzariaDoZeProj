namespace PizzariaDoZeProj
{
    partial class CustomMessageBoxForm
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
            labelTemCerteza = new Label();
            buttonContinuar = new Button();
            buttonSair = new Button();
            buttonMinimizar = new Button();
            SuspendLayout();
            // 
            // labelTemCerteza
            // 
            labelTemCerteza.AutoSize = true;
            labelTemCerteza.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemCerteza.Location = new Point(94, 9);
            labelTemCerteza.Name = "labelTemCerteza";
            labelTemCerteza.Size = new Size(115, 25);
            labelTemCerteza.TabIndex = 0;
            labelTemCerteza.Text = "Tem Certeza?";
            // 
            // buttonContinuar
            // 
            buttonContinuar.Location = new Point(12, 77);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(88, 29);
            buttonContinuar.TabIndex = 1;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = true;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // buttonSair
            // 
            buttonSair.Location = new Point(106, 77);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(88, 29);
            buttonSair.TabIndex = 2;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.Location = new Point(200, 77);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(88, 29);
            buttonMinimizar.TabIndex = 3;
            buttonMinimizar.Text = "Minimizar";
            buttonMinimizar.UseVisualStyleBackColor = true;
            buttonMinimizar.Click += buttonEnviarParaBandeja_Click;
            // 
            // CustomMessageBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 128);
            Controls.Add(buttonMinimizar);
            Controls.Add(buttonSair);
            Controls.Add(buttonContinuar);
            Controls.Add(labelTemCerteza);
            Name = "CustomMessageBoxForm";
            Text = "CustomMessageBoxForm";
            Load += CustomMessageBoxForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTemCerteza;
        private Button buttonContinuar;
        private Button buttonSair;
        private Button buttonMinimizar;
    }
}