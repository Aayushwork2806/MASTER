using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("classfee")]
    [Index(nameof(UnitId), Name = "FK_ClassFee_BusinessUnits")]
    [Index(nameof(ClassId), Name = "FK_ClassFee_Class")]
    [Index(nameof(FeeId), Name = "FK_ClassFee_FeeHeads")]
    [Index(nameof(FeeGroupId), Name = "FK_ClassFee_Masters")]
    [Index(nameof(SessId), Name = "FK_ClassFee_Session")]
    public partial class Classfee
    {
        public Classfee()
        {
            Classfeedtls = new HashSet<Classfeedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int FeeGroupId { get; set; }
        public int SessId { get; set; }
        public int ClassId { get; set; }
        public int? Amount { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Classfees")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Feehead.Classfees))]
        public virtual Feehead Fee { get; set; }
        [ForeignKey(nameof(FeeGroupId))]
        [InverseProperty(nameof(Master.Classfees))]
        public virtual Master FeeGroup { get; set; }
        [ForeignKey(nameof(SessId))]
        [InverseProperty(nameof(Session.Classfees))]
        public virtual Session Sess { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Classfees))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Classfeedtl.ClassFee))]
        public virtual ICollection<Classfeedtl> Classfeedtls { get; set; }
    }
}
