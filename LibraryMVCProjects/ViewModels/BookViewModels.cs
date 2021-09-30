using LibraryMVCProjects.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryMVCProjects.ViewModels
{
    public class BookViewModels
    {
        public List<Writers> Writers { get; set; }
        public List<BookTypes> BookTypes { get; set; }
        public Books Books { get; set; }
    }
}