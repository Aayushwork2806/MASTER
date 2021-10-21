using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("departmentconsumption")]
    [Index(nameof(BusinessUnitId), Name = "FK_DepartmentConsumption_BusinessUnits")]
    [Index(nameof(ItemId), Name = "FK_DepartmentConsumption_Items")]
    [Index(nameof(SubDepartmentId), Name = "FK_DepartmentConsumption_Masters")]
    [Index(nameof(AddedBy), Name = "FK_DepartmentConsumption_Users")]
    public partial class Departmentconsumption
    {
        [Key]
        public int Id { get; set; }
        public int BusinessUnitId { get; set; }
        public int SubDepartmentId { get; set; }
        public int ItemId { get; set; }
        [StringLength(20)]
        public string BatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        public decimal ConsumedQty { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
        [StringLength(50)]
        public string Remark { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Departmentconsumptions))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Departmentconsumptions))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(ItemId))]
        [InverseProperty("Departmentconsumptions")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(SubDepartmentId))]
        [InverseProperty(nameof(Master.Departmentconsumptions))]
        public virtual Master SubDepartment { get; set; }
    }
}
