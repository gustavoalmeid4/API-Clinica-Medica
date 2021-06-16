using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxTI.Challenge.Medical.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public int CRM { get; set; }
    }
}
