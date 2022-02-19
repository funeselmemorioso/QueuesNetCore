using Cola.Models;
using System;
using System.Threading.Tasks;

namespace Cola.DA
{
    public class BooksRepository : IBooksRepository
    {
        IAplicativoDbContext _dbContext;

        public BooksRepository(IAplicativoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book> Insertar(Book book)
        {
            try
            {
                await _dbContext.Libros.AddAsync(book);
                await _dbContext.Commit();
                return book;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
