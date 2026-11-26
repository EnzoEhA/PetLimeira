using PetLimeira.Data;
using PetLimeira.Models;
using PetLimeira.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            // CriarHashParaOBanco();
        }
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            // Validar os campos vazios 
            if (txtLogin.Text.Trim() == "")
            {
                Mensagem.Aviso("informe o login");
                txtLogin.Focus();
                return;
            }
            {
                if (txtSenha.Text.Trim() == "")
                {
                    Mensagem.Aviso("informe a Senha");
                    txtSenha.Focus();
                    return;
                }
            }

            // autenticação com os dados digitados
            var banco = new BancoContext();

            //Busca no banco o primeiro registro de usuário que seja igual ao login informado
            var usuario = banco.ControleUsuario
                .FirstOrDefault(userDoBanco =>
                userDoBanco.Login == txtLogin.Text.Trim());

            // O código acima irá retornar um objeto usuário do banco.
            // Com isso poderemos usar usuario.id, usuario.login e usuario.senha
            // Na comparação abaixo, chamo o método verificar e passo como parâmetro
            // a senha digitada e a senha retornada do banco.
            if (
                usuario == null ||
                !HashSenha.Verificar(txtSenha.Text, usuario.Senha))
            {
                Mensagem.Aviso("Usuário ou senha inválidos");
                return;                 // Encerrar a execução do método
            }



            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CriarHashParaOBanco()
        {
            var minhaHash = HashSenha.Gerar("123");
            var banco = new BancoContext();
            var admin = new Usuario { Login = "dono", Senha = minhaHash };

            banco.ControleUsuario.Add(admin);
            banco.SaveChanges();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ipSenha_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                ipSenha.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                ipSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
    }
}
