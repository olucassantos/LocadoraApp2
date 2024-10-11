using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocadoraApp2.Classes;
using Pomelo.EntityFrameworkCore.MySql;

namespace LocadoraApp2.Contexto
{
    internal class LocadoraAppDbContext : DbContext
    {
        public DbSet<Midia> Midias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "server=localhost;database=locadoraapp;user=root;password=12345;port=3306;charset=utf8mb4;";

            optionsBuilder.UseMySql(conexao, 
                ServerVersion.AutoDetect(conexao));
        }
    }
}
