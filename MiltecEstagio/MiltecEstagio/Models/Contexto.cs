using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiltecEstagio.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Estagiario> Estagiarios { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
