using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("Tutores")]
    public class Tutores
    {

        [Key]
        [Column("id_tutor")]
        public int idTutor { get; set; }

        [Column("nome_completo")]
        public string nome { get; set; }

        [Column("cpf")]
        public string cpf { get; set; }

        [Column("rua")]
        public string rua { get; set; }

        [Column("numero")]
        public string numero { get; set; }

        [Column("bairro")]
        public string bairro { get; set; }

        [Column("cidade")]
        public string cidade { get; set; }

        [Column("cep")]
        public string cep { get; set; }

        [Column("telefone1")]
        public string telefone { get; set; }

        [Column("telefone2")]
        public string? telefone2 { get; set; }

        [Column("telefone3")]
        public string? telefone3 { get; set; }
    }
}
