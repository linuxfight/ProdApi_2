using System.ComponentModel.DataAnnotations;

namespace ProdApi_2.Models;

public class Country
{
    public int Id { get; set; }
    [MaxLength(60)]
    
    public required string Name { get; set; }
    [MaxLength(2)]
    public required string Alpha2 { get; set; }
    [MaxLength(3)]
    public required string Alpha3 { get; set; }
    [MaxLength(20)]
    public required string Region { get; set; }
}