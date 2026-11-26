using Microsoft.EntityFrameworkCore;
using PetLimeira.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PetLimeira.Data
{
    public class BancoContext : DbContext
    {
        // Propiedade que funcionará como um controle remoto
        // Ela será usada para executar as ações do CRUD
        public DbSet<Tutores> ControleTutor { get; set; }
        public DbSet<Usuario> ControleUsuario { get; set; }
        public DbSet<Animal> ControleAnimal { get; set; }


        // método para informações do banco 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conexao = "server=127.0.0.1;port=3307;database=petLimeira;user=root;";
            //var versao = new MariaDbServerVersion(new Version(11, 4, 9));
            options.UseMySql(conexao, ServerVersion.AutoDetect(conexao));

        }
    }
}

