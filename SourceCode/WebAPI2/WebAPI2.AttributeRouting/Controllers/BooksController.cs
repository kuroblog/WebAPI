
namespace WebAPI2.AttributeRouting.Controllers
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;
    using Models;
    using System.Linq.Expressions;
    using System;
    using DTOs;

    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        private BooksAPIContext db = new BooksAPIContext();

        private static readonly Expression<Func<Book, BookDto>> AsBookDto = x => new BookDto
        {
            Title = x.Title,
            Author = x.Author.Name,
            Genre = x.Genre
        };

        // GET: api/Books
        //public IQueryable<Book> GetBooks()
        //{
        //    return db.Books;
        //}
        [Route("")]
        public IQueryable<BookDto> GetBooks()
        {
            return db.Books.Include(x => x.Author).Select(AsBookDto);
        }

        // GET: api/Books/5
        //[ResponseType(typeof(Book))]
        //public async Task<IHttpActionResult> GetBook(int id)
        //{
        //    Book book = await db.Books.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(book);
        //}
        [Route("{id:int}")]
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            var book = await db.Books.Include(x => x.Author).Where(x => x.BookId == id).Select(AsBookDto).FirstOrDefaultAsync();
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [Route("{id:int}/details")]
        public async Task<IHttpActionResult> GetBookDetail(int id)
        {
            var book = await (from b in db.Books.Include(x => x.Author)
                              where b.AuthorId == id
                              select new BookDetailDto
                              {
                                  Title = b.Title,
                                  Genre = b.Genre,
                                  PublishDate = b.PublishDate,
                                  Price = b.Price,
                                  Description = b.Description,
                                  Author = b.Author.Name
                              }).FirstOrDefaultAsync();
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [Route("{genre}")]
        public IQueryable<BookDto> GetBooksByGenre(string genre)
        {
            return db.Books.Include(x => x.Author).Where(x => x.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).Select(AsBookDto);
        }

        [Route("~/api/authors/{authorId}/books")]
        public IQueryable<BookDto> GetBooksByAuthor(int authorId)
        {
            return db.Books.Include(x => x.Author).Where(x => x.AuthorId == authorId).Select(AsBookDto);
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            db.Dispose();
            base.Dispose(disposing);
        }

        #region these methoods can not be used in this demo
        // PUT: api/Books/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBook(int id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != book.BookId)
            {
                return BadRequest();
            }

            db.Entry(book).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Books
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> PostBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Books.Add(book);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = book.BookId }, book);
        }

        // DELETE: api/Books/5
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> DeleteBook(int id)
        {
            Book book = await db.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            db.Books.Remove(book);
            await db.SaveChangesAsync();

            return Ok(book);
        }

        private bool BookExists(int id)
        {
            return db.Books.Count(e => e.BookId == id) > 0;
        }
        #endregion
    }
}