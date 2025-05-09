using Microsoft.EntityFrameworkCore;
using ProdutosApp.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contexto pata configuração do Entity Framework.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor para injeção de dependência~, ou seja para que esta classe 
        /// possa receber as configurações do banco de dados.
        /// </summary>
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        /// <summary>
        /// Método para adionar as classes de mapeamento feitas no projeto
        /// 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
