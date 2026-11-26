using System;
using System.Collections.Generic;
using System.Text;

namespace PetLimeira.Services
{
    internal class Mensagem
    {
        public static void Erro(string msg)
        {
            MessageBox.Show(
                msg,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        // Método para aviso
        public static void Aviso(string msg)
        {
            MessageBox.Show(
                msg,
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }

        public static DialogResult Confirmacao(string msg)
        {
            return MessageBox.Show(
                msg,
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
        }
    }
}
