using Cola.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Cola.DA
{
    public class AplicativoDbContext : DbContext, IAplicativoDbContext
    {
        public AplicativoDbContext(DbContextOptions<AplicativoDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Libros { get; set; }    


        public async Task<int> Commit()
        {
            try
            {
                return await this.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override void Dispose()
        {
            this.DisposeAsync();
        }
    }
}
