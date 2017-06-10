namespace KnockoutDemo.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(64)]
        public string Phone { get; set; }

        [StringLength(64)]
        public string Email { get; set; }

        [StringLength(64)]
        public string Address1 { get; set; }

        [StringLength(64)]
        public string Address2 { get; set; }

        [StringLength(64)]
        public string City { get; set; }

        [StringLength(16)]
        public string State { get; set; }

        [StringLength(4)]
        public string PostCode { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}
