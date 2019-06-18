namespace WindowsFormsApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [StringLength(10)]
        public string vend_id { get; set; }

        [Required]
        [StringLength(50)]
        public string vend_name { get; set; }

        [StringLength(50)]
        public string vend_address { get; set; }

        [StringLength(50)]
        public string vend_city { get; set; }

        [StringLength(5)]
        public string vend_state { get; set; }

        [StringLength(10)]
        public string vend_zip { get; set; }

        [StringLength(50)]
        public string vend_country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
