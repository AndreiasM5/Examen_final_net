using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Entity;

[Table("order")]
public class Order
{
    [Column("order_id")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId { get; set; }
    
    public decimal TotalAmount { get; set; }

    [ForeignKey("User")]
    public string UserId { get; set; }

    public User User { get; set; }

    public List<Product> Products { get; set;}
}
