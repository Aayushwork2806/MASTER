using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("hostalexpensehead")]
    [Index(nameof(UnitId), Name = "FK_ExpenseHead_BusinessUnits")]
    public partial class Hostalexpensehead
    {
        public Hostalexpensehead()
        {
            Hostelexpensesdtls = new HashSet<Hostelexpensesdtl>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string HeadName { get; set; }
        public double? Amount { get; set; }
        [StringLength(3)]
        public string HeadType { get; set; }
        public bool IsActive { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Hostalexpenseheads))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Hostelexpensesdtl.HostelHead))]
        public virtual ICollection<Hostelexpensesdtl> Hostelexpensesdtls { get; set; }
    }
}
