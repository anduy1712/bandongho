//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Images = "~/Content/images/add.png";
            this.OrderDetails = new HashSet<OrderDetail>();
        }
      
        public int IDProduct { get; set; }
        public string NameProduct { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Images { get; set; }
        public Nullable<System.DateTime> ProductDate { get; set; }
        public string Available { get; set; }
        public Nullable<int> IDCategory { get; set; }
        public string Descriptions { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
