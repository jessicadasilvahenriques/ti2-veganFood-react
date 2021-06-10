using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using veganFood.Models;

namespace veganFood.Data
{
    public class VeganDbContext : IdentityDbContext
    {
        public VeganDbContext(DbContextOptions<VeganDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }

    }
}
