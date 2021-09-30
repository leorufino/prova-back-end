using BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace BACK.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades de classes de modelo que vão virar as tabelas no banco
        public DbSet<Filme> Filmes { get; set; }
    }
}