using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PizzariaDoZeProj


{
    internal class ClassFuncoes
    {
        /// string hash = ClassFuncoes.Sha256Hash(textBoxSenha.Text);
        public static string Sha256Hash(string senha)
        {
            // Create a new Stringbuilder to collect the bytes and create a string.
            var hash = new StringBuilder();
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    hash.Append(data[i].ToString("x2"));
                }
            }
            // retorna o hash SHA256.
            return hash.ToString();
        }

        /// <summary>
        /// Altera a cor do BackGroud quando o campo ganha o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Enter += new System.EventHandler(ClassFuncoes.CampoEventoEnter); </example>
        public static void CampoEventoEnter(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightCyan;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightCyan;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightCyan;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGreen;
            }
        }
        /// <summary>
        /// Alterar a cor do BackGroup quando o campo perde o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Leave += new System.EventHandler(ClassFuncoes.CampoEventoLeave); </example>
        /// 
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            Form form = (Form)sender;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }

        public static void CampoEventoLeave(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.Red;
            }
        }

    }
}

