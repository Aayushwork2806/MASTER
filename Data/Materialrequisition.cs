using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialrequisition")]
    [Index(nameof(BusinessUnitId), Name = "FK_MaterialRequisition_BusinessUnits")]
    [Index(nameof(FromSubDepartmentId), Name = "FK_MaterialRequisition_Masters")]
    [Index(nameof(ToStoreId), Name = "FK_MaterialRequisition_Stores")]
    [Index(nameof(AddedBy), Name = "FK_MaterialRequisition_Users")]
    public partial class Materialrequisition
    {
        public Materialrequisition()
        {
            Materialrequisitiondetails = new HashSet<Materialrequisitiondetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime MaterialRequisitionDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int FromSubDepartmentId { get; set; }
        public int ToStoreId { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Materialrequisitions))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Materialrequisitions))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(FromSubDepartmentId))]
        [InverseProperty(nameof(Master.Materialrequisitions))]
        public virtual Master FromSubDepartment { get; set; }
        [ForeignKey(nameof(ToStoreId))]
        [InverseProperty(nameof(Store.Materialrequisitions))]
        public virtual Store ToStore { get; set; }
        [InverseProperty(nameof(Materialrequisitiondetail.MaterialRequisition))]
        public virtual ICollection<Materialrequisitiondetail> Materialrequisitiondetails { get; set; }
    }
}
