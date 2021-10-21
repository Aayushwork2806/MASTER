using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("userroledashboard")]
    [Index(nameof(DashBoardId), Name = "FK_UserRoleDashBoard_DashboardTemplates")]
    [Index(nameof(RoleId), Name = "FK_UserRoleDashBoard_Role")]
    public partial class Userroledashboard
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int DashBoardId { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(DashBoardId))]
        [InverseProperty(nameof(Dashboardtemplate.Userroledashboards))]
        public virtual Dashboardtemplate DashBoard { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Userroledashboards")]
        public virtual Role Role { get; set; }
    }
}
