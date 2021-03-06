//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMVCProjects.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Operations
    {
        public int Id { get; set; }
        [Display(Name ="StudentName")]
        [Required(ErrorMessage ="StudentName bo? ge?ilemez")]
        public Nullable<int> StudentId { get; set; }
        [Display(Name = "BookName")]
        [Required(ErrorMessage = "BookName bo? ge?ilemez")]
        public Nullable<int> BookId { get; set; }
        [Required(ErrorMessage = "Price bo? ge?ilemez")]
        public Nullable<int> Price { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Students Students { get; set; }
    }
}
