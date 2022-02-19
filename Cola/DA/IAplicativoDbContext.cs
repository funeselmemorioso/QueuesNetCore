using Cola.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Cola.DA
{
    public interface IAplicativoDbContext
    {
        DbSet<Book> Libros { get; set; }   
        Task<int> Commit();
        void Dispose();
    }
}
