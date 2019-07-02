using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStore.Models
{
    public class Book : BaseModel
    {
        public int WriterId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }
    }
}
