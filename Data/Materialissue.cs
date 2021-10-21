using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialissue")]
    [Index(nameof(BusinessUnitId), Name = "FK_MaterialIssue_BusinessUnits")]
    [Index(nameof(FromStoreId), Name = "FK_MaterialIssue_Stores")]
    [Index(nameof(ToSubDepartmentId), Name = "FK_MaterialIssue_SubDepartment")]
    public partial class Materialissue
    {
        public Materialissue()
        {
            Materialissuedetails = new HashSet<Materialissuedetail>();
        }

        [Key]
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        [MaxLength(6)]
        public DateTime MaterialIssueDate { get; set; }
        public int FromStoreId { get; set; }
        public int ToSubDepartmentId { get; set; }
        public int AddedBy { get; set; }
        public int? MaterialIssueNo { get; set; }

        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Materialissues))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(FromStoreId))]
        [InverseProperty(nameof(Store.Materialissues))]
        public virtual Store FromStore { get; set; }
        [ForeignKey(nameof(ToSubDepartmentId))]
        [InverseProperty(nameof(Master.Materialissues))]
        public virtual Master ToSubDepartment { get; set; }
        [InverseProperty(nameof(Materialissuedetail.MaterialIssue))]
        public virtual ICollection<Materialissuedetail> Materialissuedetails { get; set; }
    }
}
