namespace KnockoutDemo.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class OrderItem
    {
        [Key]
        [Required]
        public int OrderItemId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual Order Order { get; set; }
    }
}
