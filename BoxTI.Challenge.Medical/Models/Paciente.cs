using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxTI.Challenge.Medical.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string TipoSanguineo { get; set; }
    }
}
