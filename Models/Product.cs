using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BaiTapBuoi5.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = "";

    [Precision(18, 2)]
    public decimal Price { get; set; }
}