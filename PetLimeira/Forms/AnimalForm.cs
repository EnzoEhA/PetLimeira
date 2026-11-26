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
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
        InitializeComponent();
            CarregarCombos();
            ListarAnimais();
        }
        // No topo da classe AnimalForm, fora dos métodos
        private int idTutor = 0;

        private void CarregarCombos()
        {
            var banco = new BancoContext();

            // Combobox de sedes
            cmbNomeTutor.DisplayMember = "nome";       // O que o usuário vê
            cmbNomeTutor.ValueMember = "idTutor";         // O que é recuperado
            cmbNomeTutor.DataSource = banco.ControleTutor.ToList();

            // Combobox de Mandante
            cmbCpfTutor.DisplayMember = "cpf";     // O que o usuário vê
            cmbCpfTutor.ValueMember = "cpf";  // O que é recuperado
            cmbCpfTutor.DataSource = banco.ControleTutor.ToList();

            // Combobox de Visitante
            cmbTelefoneTutor.DisplayMember = "telefone";    // O que o usuário vê
            cmbTelefoneTutor.ValueMember = "telefone1"; // O que é recuperado
            cmbTelefoneTutor.DataSource = banco.ControleTutor.ToList();


        }

        private void ListarAnimais()
        {
            var banco = new BancoContext();
            //var partidas = banco.ControlePartida.ToList();

            // Cria o relacionamento entre as entidades definidas no Entity Framework
            var animais =
                from a in banco.ControleAnimal
                join t in banco.ControleTutor on a.idTutor equals t.idTutor
                select new
                {
                    a.idAnimal,
                    Animal = a.nome,
                    a.especie,
                    a.raca,
                    a.sexo,
                    a.idade,
                    a.peso,
                    a.castrado,
                    Tutor = t.nome,
                    t.cpf,
                    t.telefone
                };


            dataGridView1.DataSource = animais.ToList();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (!Validar())
                return;


            var banco = new BancoContext();

            // Criar o objeto partida que será salvo no banco
            var animal = new Animal
            {
                nome = txtNome.Text,
                especie = txtEspecie.Text,
                raca = txtRaca.Text,
                sexo = cmbSexo.Text[0],
                idade = int.Parse(txtIdade.Text),
                peso = decimal.Parse(txtPeso.Text),
                castrado = cmbCastrado.Text == "Sim",
                idTutor = idTutor
            };

            banco.ControleAnimal.Add(animal);
            banco.SaveChanges();

            Mensagem.Aviso("Dados gravados com sucesso");
            ListarAnimais();
        }

        private bool Validar()
        {
            var banco = new BancoContext();


            // Busca o tutor pelo CPF digitado, na hora de validar
            string cpf = cmbCpfTutor.Text.Trim();
            var tutor = banco.ControleTutor.FirstOrDefault(t => t.cpf == cpf);

            if (tutor == null)
            {
                Mensagem.Aviso("Tutor não encontrado para este CPF");
                return false;
            }

            idTutor = tutor.idTutor;

            // Verifica os campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                Mensagem.Aviso("Preencha o nome e a espécie do animal");
                return false;
            }

            if (cmbSexo.SelectedIndex <= 0)
            {
                Mensagem.Aviso("Selecione o sexo do animal");
                return false;
            }

            // Impedir que o mesmo animal seja cadastrado duas vezes para o mesmo tutor
            string nome = txtNome.Text.Trim();
            bool jaExiste = banco.ControleAnimal.Any(
                a =>
                a.nome == nome &&
                a.idTutor == idTutor);

            if (jaExiste)
            {
                Mensagem.Aviso("Este tutor já possui um animal com este nome");
                return false;
            }

            return true;
        }
    }
}
