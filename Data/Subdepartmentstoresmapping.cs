using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("subdepartmentstoresmapping")]
    [Index(nameof(SubDepartmentId), Name = "FK_SubDepartmentStoresMapping_Masters")]
    [Index(nameof(StoresId), Name = "FK_SubDepartmentStoresMapping_Stores")]
    public partial class Subdepartmentstoresmapping
    {
        [Key]
        public int Id { get; set; }
        public int SubDepartmentId { get; set; }
        public int StoresId { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(StoresId))]
        [InverseProperty(nameof(Store.Subdepartmentstoresmappings))]
        public virtual Store Stores { get; set; }
        [ForeignKey(nameof(SubDepartmentId))]
        [InverseProperty(nameof(Master.Subdepartmentstoresmappings))]
        public virtual Master SubDepartment { get; set; }
    }
}
