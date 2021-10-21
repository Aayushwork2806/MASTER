using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialreturn")]
    [Index(nameof(BusinessUnitId), Name = "FK_MaterialReturn_BusinessUnits")]
    [Index(nameof(ToStoreId), Name = "FK_MaterialReturn_Stores")]
    [Index(nameof(FromSubDepartmentId), Name = "FK_MaterialReturn_SubDepartment")]
    [Index(nameof(AddedBy), Name = "FK_MaterialReturn_Users")]
    public partial class Materialreturn
    {
        public Materialreturn()
        {
            Materialreturndetails = new HashSet<Materialreturndetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime MaterialReturnDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int FromSubDepartmentId { get; set; }
        public int ToStoreId { get; set; }
        public int AddedBy { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Materialreturns))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Materialreturns))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(FromSubDepartmentId))]
        [InverseProperty(nameof(Master.Materialreturns))]
        public virtual Master FromSubDepartment { get; set; }
        [ForeignKey(nameof(ToStoreId))]
        [InverseProperty(nameof(Store.Materialreturns))]
        public virtual Store ToStore { get; set; }
        [InverseProperty(nameof(Materialreturndetail.MaterialReturn))]
        public virtual ICollection<Materialreturndetail> Materialreturndetails { get; set; }
    }
}
