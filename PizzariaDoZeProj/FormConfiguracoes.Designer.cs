namespace PizzariaDoZeProj
{
    partial class FormConfiguracoes
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
            comboBoxIdioma = new ComboBox();
            ButtonSalvarIdioma = new Button();
            SuspendLayout();
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Location = new Point(12, 28);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(121, 23);
            comboBoxIdioma.TabIndex = 0;
            // 
            // ButtonSalvarIdioma
            // 
            ButtonSalvarIdioma.Location = new Point(157, 12);
            ButtonSalvarIdioma.Name = "ButtonSalvarIdioma";
            ButtonSalvarIdioma.Size = new Size(94, 52);
            ButtonSalvarIdioma.TabIndex = 1;
            ButtonSalvarIdioma.Text = "Salvar";
            ButtonSalvarIdioma.UseVisualStyleBackColor = true;
            ButtonSalvarIdioma.Click += ButtonSalvarIdioma_Click;
            // 
            // FormConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 121);
            Controls.Add(ButtonSalvarIdioma);
            Controls.Add(comboBoxIdioma);
            Name = "FormConfiguracoes";
            Text = "FormConfiguracoes";
            Load += FormConfiguracoes_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxIdioma;
        private Button ButtonSalvarIdioma;
    }
}