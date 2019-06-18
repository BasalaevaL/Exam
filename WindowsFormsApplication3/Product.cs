namespace WindowsFormsApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        [StringLength(10)]
        public string prod_id { get; set; }

        [Required]
        [StringLength(10)]
        public string vend_id { get; set; }

        [Required]
        [StringLength(255)]
        public string prod_name { get; set; }

        public decimal prod_price { get; set; }

        [Column(TypeName = "text")]
        public string prod_desc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
