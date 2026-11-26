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
    public partial class TutoresForm : Form
    {

        private int idSelecionado = 0;
        public TutoresForm()
        {
            InitializeComponent();
            ListarTutores();

            // Desabilitar os botões Atualizar e Excluir
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ListarTutores(string filtro = "")
        {
            // Instanciar a classe de conexão ao banco
            var banco = new BancoContext();

            // Executar o método ToList para retornar uma lista de seleções
            var tutores = banco.ControleTutor
                . Where(p => p.nome.Contains(filtro))
                .ToList();

            // Carrega no gridview a lista de seleções
            dataGridView1.DataSource = tutores;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (!CamposValidos())
            {
                return;
            }

            var banco = new BancoContext();

            var tutor = new Tutores
            {
                nome = txtNome.Text,
                cpf = txtCpf.Text,
                telefone = txtTelefone1.Text,
                telefone2 = txtTelefone2.Text,
                telefone3 = txtTelefone3.Text,
                cep = txtCep.Text,
                numero = txtNumero.Text,
                rua = txtRua.Text,
                bairro = txtBairro.Text,
                cidade = txtCidade.Text,
            };

            banco.ControleTutor.Add(tutor);
            banco.SaveChanges();

            Mensagem.Aviso("Dados gravados com sucesso");

            ListarTutores();

            LimparCampos();

            txtNome.Focus();

        }

        private bool CamposValidos()
        {
            if (txtNome.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o nome");
                txtNome.Focus();
                return false;
            }

            if (txtCpf.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o cpf");
                txtCpf.Focus();
                return false;
            }

            if (txtTelefone1.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o telefone");
                txtTelefone1.Focus();
                return false;
            }

            if (txtCep.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o cep");
                txtCep.Focus();
                return false;
            }

            if (txtNumero.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o numero");
                txtNumero.Focus();
                return false;
            }

            if (txtRua.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe a rua");
                txtRua.Focus();
                return false;
            }

            if (txtBairro.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o bairro");
                txtBairro.Focus();
                return false;
            }

            if (txtCidade.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe a cidade");
                txtCidade.Focus();
                return false;
            }

            return true;
        }


        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone1.Clear();
            txtTelefone2.Clear();
            txtTelefone3.Clear();
            txtCep.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            btnAdicionar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void txtTelefone1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone3_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefone3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Desabilitar o botão Add para evitar clique acidental
            btnAdicionar.Enabled = false;

            // Habilitar os botões Atualizar e Excluir
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;

            if (e.RowIndex < 0)
            {
                return;
            }

            var objTutor = dataGridView1.Rows[e.RowIndex].DataBoundItem as Tutores;

            if (objTutor == null)
            {
                return;
            }

            idSelecionado = objTutor.idTutor;
            txtNome.Text = objTutor.nome;
            txtCpf.Text = objTutor.cpf;
            txtTelefone1.Text = objTutor.telefone;
            txtTelefone2.Text = objTutor.telefone2;
            txtTelefone3.Text = objTutor.telefone3;
            txtCep.Text = objTutor.cep;
            txtNumero.Text = objTutor.numero;
            txtRua.Text = objTutor.rua;
            txtBairro.Text = objTutor.bairro;
            txtCidade.Text = objTutor.cidade;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                Mensagem.Aviso("Selecione uma linha do grid");
                return;
            }

            // Solicitar a confirmação de exclusão
            var resposta = Mensagem.Confirmacao("Deseja excluir esta seleção?");
            if (resposta != DialogResult.Yes)
            {
                return;
            }

            // Buscar a conexão com o banco
            var banco = new BancoContext();

            // Verificar se o idSelecionado existe no banco de dados
            var objSelecao = banco.ControleTutor.Find(idSelecionado);
            if (objSelecao == null)
            {
                return;
            }

            // Executa a exclusão
            banco.ControleTutor.Remove(objSelecao);
            banco.SaveChanges();

            LimparCampos();
            ListarTutores();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                Mensagem.Aviso("Selecione uma linha no grid");
                return;
            }

            // Verfificar se os campos são válidos
            if (!CamposValidos())
            {
                return;
            }

            var banco = new BancoContext();
            var objSelecao = banco.ControleTutor.Find(idSelecionado);
            if (objSelecao == null)
            {
                return;
            }

            // Obter os novos dados do formulário e atualizar no objeto que será
            // atualizado no banco
            objSelecao.nome = txtNome.Text;
            objSelecao.cpf = txtCpf.Text;
            objSelecao.telefone = txtTelefone1.Text;
            objSelecao.telefone2 = txtTelefone2.Text;
            objSelecao.telefone3 = txtTelefone3.Text;
            objSelecao.cep = txtCep.Text;
            objSelecao.numero = txtNumero.Text;
            objSelecao.rua = txtRua.Text;
            objSelecao.bairro = txtBairro.Text;
            objSelecao.cidade = txtCidade.Text;
            banco.SaveChanges();

            LimparCampos();
            ListarTutores();

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

            }
        }

        private void txtCampoBusca_TextChanged(object sender, EventArgs e)
        {
            ListarTutores(txtCampoBusca.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarTutores(txtCampoBusca.Text);
        }
    }

}
