using ControleDeContactos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContactos.Data
{
    public class BancoContext: DbContext //herdando o context do EFcore da Bd e gerar a importação do primeiro using 
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)// construtor da classe
        {
        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
