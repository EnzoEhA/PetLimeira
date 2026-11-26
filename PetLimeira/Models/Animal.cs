using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        [Column("id")]
        public int idAnimal { get; set; }

        [Column("nome")]
        public string nome { get; set; } = string.Empty;

        [Column("especie")]
        public string especie { get; set; } = string.Empty;

        [Column("raca")]
        public string raca { get; set; } = string.Empty;

        [Column("sexo")]
        public char sexo { get; set; }

        [Column("idade")]
        public int idade { get; set; } = 0;

        [Column("peso")]
        public decimal peso { get; set; } = 0;

        [Column("castrado")]
        public bool castrado { get; set; }

        [Column("id_tutor")]
        public int idTutor { get; set; }
    }
}
