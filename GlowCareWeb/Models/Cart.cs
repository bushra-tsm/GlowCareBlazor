using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GlowCareWeb.Models;

[Table("Cart")]
public partial class Cart
{
    [Key]
    public int CartId { get; set; }

    [StringLength(450)]
    public string UserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(255)]
    public string? PaymentIntentId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AmountPaid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [InverseProperty("Cart")]
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}
