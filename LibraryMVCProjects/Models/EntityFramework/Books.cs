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
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.Operations = new HashSet<Operations>();
        }
    
        public int Id { get; set; }
        public Nullable<int> WriterId { get; set; }
        public Nullable<int> BookTypeId { get; set; }
        public Nullable<int> Page { get; set; }
        public string BookName { get; set; }
    
        public virtual BookTypes BookTypes { get; set; }
        public virtual Writers Writers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operations> Operations { get; set; }
    }
}