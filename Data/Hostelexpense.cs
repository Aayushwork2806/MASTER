using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("hostelexpenses")]
    [Index(nameof(UnitId), Name = "FK_HostelExpenses_BusinessUnits")]
    [Index(nameof(ScholarId), Name = "FK_HostelExpenses_Scholar")]
    [Index(nameof(SessionId), Name = "FK_HostelExpenses_Session")]
    public partial class Hostelexpense
    {
        public Hostelexpense()
        {
            Hostelexpensesdtls = new HashSet<Hostelexpensesdtl>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public int DocNo { get; set; }
        public int ScholarId { get; set; }
        public int UnitId { get; set; }
        public int SessionId { get; set; }
        public double Amount { get; set; }
        [StringLength(150)]
        public string Narration { get; set; }
        [StringLength(15)]
        public string PayMode { get; set; }
        [StringLength(20)]
        public string ChequeNo { get; set; }
        public bool? Deleted { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Hostelexpenses")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Hostelexpenses")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Hostelexpenses))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Hostelexpensesdtl.HostelExpenses))]
        public virtual ICollection<Hostelexpensesdtl> Hostelexpensesdtls { get; set; }
    }
}
