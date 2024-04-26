using System;
using System.ComponentModel.DataAnnotations;

public class Carpooler
{
    public long ID { get; set; }
    [StringLength(255)]
    public string? Name { get; set; }
    public string? Origin { get; set; }
    public string? Destination { get; set; }
    public DateTime? Date { get; set; }
    public decimal? Reward { get; set; }
}
