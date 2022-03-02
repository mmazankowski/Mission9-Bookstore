using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mission9_Bookstore.Models
{
    public class EFBookstoreRepository : iBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp; 
        }

        public IQueryable<Book> Books => context.Books;
    }
}
