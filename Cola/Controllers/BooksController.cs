using Cola.BackgroundTasks.Queue;
using Cola.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBackgroundQueue<Book> _queue;

        public BooksController(IBackgroundQueue<Book> queue)
        {
            _queue = queue;
        }

        [HttpGet]
        [Route("Publish") ]
        public async Task<IActionResult> Publish()
        {
            try
            {
                Book unLibro = new Book()
                {
                    Title = "Hola mundo"
                };

                _queue.Enqueue(unLibro);
                return Accepted();
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
    }
}
