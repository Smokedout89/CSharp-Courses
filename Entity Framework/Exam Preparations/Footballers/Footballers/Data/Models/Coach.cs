﻿namespace Footballers.Data.Models;

using System.ComponentModel.DataAnnotations;
using Common;

public class Coach
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ValidationConstants.CoachNameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    public string Nationality { get; set; } = null!;

    public virtual ICollection<Footballer> Footballers { get; set; } = new List<Footballer>();
}