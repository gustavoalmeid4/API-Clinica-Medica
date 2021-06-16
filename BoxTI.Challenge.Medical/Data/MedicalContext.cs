using BoxTI.Challenge.Medical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxTI.Challenge.Medical.Data
{
    public class MedicalContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        public MedicalContext(DbContextOptions options) : base(options)
        {
        }

    }
}
