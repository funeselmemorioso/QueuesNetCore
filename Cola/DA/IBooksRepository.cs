using Cola.Models;
using System.Threading.Tasks;

namespace Cola.DA
{
    public interface IBooksRepository
    {
        Task<Book> Insertar(Book book);
    }
}
