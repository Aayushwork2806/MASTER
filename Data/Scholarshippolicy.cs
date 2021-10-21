using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholarshippolicy")]
    [Index(nameof(UnitId), Name = "FK_ScholarShipPolicy_BusinessUnits")]
    [Index(nameof(CategoryId), Name = "FK_ScholarShipPolicy_Masters")]
    [Index(nameof(SessionId), Name = "FK_ScholarShipPolicy_Session")]
    public partial class Scholarshippolicy
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SessionId { get; set; }
        public double? BoysAmount { get; set; }
        public double? GirlsAmount { get; set; }
        public short? ForMonths { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.Scholarshippolicies))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Scholarshippolicies")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Scholarshippolicies))]
        public virtual Businessunit Unit { get; set; }
    }
}
