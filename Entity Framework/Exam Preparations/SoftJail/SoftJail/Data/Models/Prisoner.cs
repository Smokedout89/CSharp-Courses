﻿namespace SoftJail.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;

    public class Prisoner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.PrisonerFullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        public string Nickname { get; set; }

        public int Age { get; set; }

        public DateTime IncarcerationDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public decimal? Bail { get; set; }

        [ForeignKey(nameof(Cell))]
        public int? CellId { get; set; }
        public virtual Cell Cell { get; set; }

        public virtual ICollection<Mail> Mails { get; set; } = new HashSet<Mail>();

        public virtual ICollection<OfficerPrisoner> PrisonerOfficers { get; set; } = new HashSet<OfficerPrisoner>();
    }
}