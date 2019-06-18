namespace WindowsFormsApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [StringLength(10)]
        public string cust_id { get; set; }

        [Required]
        [StringLength(50)]
        public string cust_name { get; set; }

        [StringLength(50)]
        public string cust_address { get; set; }

        [StringLength(50)]
        public string cust_city { get; set; }

        [StringLength(5)]
        public string cust_state { get; set; }

        [StringLength(10)]
        public string cust_zip { get; set; }

        [StringLength(50)]
        public string cust_country { get; set; }

        [StringLength(50)]
        public string cust_contact { get; set; }

        [StringLength(255)]
        public string cust_email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
