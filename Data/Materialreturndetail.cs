using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialreturndetail")]
    [Index(nameof(ItemId), Name = "FK_MateialReturnDetail_Items")]
    [Index(nameof(MaterialIssueDetailId), Name = "FK_MateialReturnDetail_MaterialIssueDetail")]
    [Index(nameof(MaterialReturnId), Name = "FK_MateialReturnDetail_MaterialReturn")]
    public partial class Materialreturndetail
    {
        [Key]
        public int Id { get; set; }
        public int MaterialReturnId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal QtyReturned { get; set; }
        public int MaterialIssueDetailId { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Materialreturndetails")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(MaterialIssueDetailId))]
        [InverseProperty(nameof(Materialissuedetail.Materialreturndetails))]
        public virtual Materialissuedetail MaterialIssueDetail { get; set; }
        [ForeignKey(nameof(MaterialReturnId))]
        [InverseProperty(nameof(Materialreturn.Materialreturndetails))]
        public virtual Materialreturn MaterialReturn { get; set; }
    }
}
