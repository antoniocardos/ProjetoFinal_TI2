using EmpregoInfo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpregoInfo.Data
{
    /// <summary>
    /// Representa a DB do nosso sistema (EmpregoInfo)
    /// À custa de um ORM (Mapeador de objectos relacionais)
    /// </summary>
    public class EmpregoDB : DbContext{
        public EmpregoDB(DbContextOptions<EmpregoDB> options) : base(options) { }

        // adicionar as 'tabelas' à Base de Dados

        public DbSet<Utilizadores> Utilizadores { get; set; }

        public DbSet<Empresas> Empresas { get; set; }

        public DbSet<Anuncios> Anuncios { get; set; }

        public DbSet<Candidaturas> Candidaturas { get; set; }
    }
}
