using LibraryMVCProjects.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryMVCProjects.ViewModels
{
    public class OperationViewModels
    {
        public List<Students> Students { get; set; }
        public List<Books> Books { get; set; }
        public Operations Operations { get; set; }
    }
}