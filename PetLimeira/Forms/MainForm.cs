using PetLimeira.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();

            //Mensagem.Erro("Deu ruim. Muito ruim");
            //Mensagem.Aviso("Deu ruim. Muito ruim");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obter a data e hora atual
            DateTime dataHoraAtual = DateTime.Now;

            // Atualizar o status com a data e hora
            status2.Text = dataHoraAtual.ToString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pedir confirmação para fechar
            DialogResult confirmacao = MessageBox.Show(
                "Deseja fechar a aplicação",
                "Confirmação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.OK)


                // Fechar a aplicação
                Application.Exit();
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://youtube.com");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void linhaDeComandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTutores = new AnimalForm();
            formTutores.MdiParent = this;
            formTutores.WindowState = FormWindowState.Maximized;
            formTutores.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAnimal = new AnimalForm();
            formAnimal.MdiParent = this;
            formAnimal.WindowState = FormWindowState.Maximized;
            formAnimal.Show();
        }
    }
}
