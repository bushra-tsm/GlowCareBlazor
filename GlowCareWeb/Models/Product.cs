using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GlowCareWeb.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;

    public int Stock { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    public bool IsActive { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual Category Category { get; set; } = null!;
}
