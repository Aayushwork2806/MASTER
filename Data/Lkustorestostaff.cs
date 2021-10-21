using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("lkustorestostaff")]
    [Index(nameof(FacultyId), Name = "FK_lkuStorestoStaff_Employee")]
    [Index(nameof(StoreId), Name = "FK_lkuStorestoStaff_lkuStorestoStaff")]
    public partial class Lkustorestostaff
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        public int? StoreId { get; set; }
        public int? FacultyId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        [InverseProperty(nameof(Employee.Lkustorestostaffs))]
        public virtual Employee Faculty { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty(nameof(Lkustoresmst.Lkustorestostaffs))]
        public virtual Lkustoresmst Store { get; set; }
    }
}
