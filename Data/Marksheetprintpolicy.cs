using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marksheetprintpolicy")]
    [Index(nameof(UnitId), Name = "FK_MarksheetPrintPolicy_BusinessUnits")]
    [Index(nameof(SessionId), Name = "FK_MarksheetPrintPolicy_Session")]
    public partial class Marksheetprintpolicy
    {
        public Marksheetprintpolicy()
        {
            Marksheetprintpolicydtls = new HashSet<Marksheetprintpolicydtl>();
            Marksheets = new HashSet<Marksheet>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        [Required]
        [StringLength(50)]
        public string PolicyName { get; set; }
        [StringLength(50)]
        public string TitleToPrint { get; set; }
        public bool Deleted { get; set; }
        public int UnitId { get; set; }
        [StringLength(0)]
        public string MarkSheetFormat { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Marksheetprintpolicies")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Marksheetprintpolicies))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Marksheetprintpolicydtl.MarkSheetPolicy))]
        public virtual ICollection<Marksheetprintpolicydtl> Marksheetprintpolicydtls { get; set; }
        [InverseProperty(nameof(Marksheet.PrintPolicy))]
        public virtual ICollection<Marksheet> Marksheets { get; set; }
    }
}
