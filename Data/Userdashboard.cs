using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("userdashboard")]
    [Index(nameof(DashBoardId), Name = "FK_UserDashBoard_DashboardTemplates")]
    [Index(nameof(RoleId), Name = "FK_UserDashBoard_Role")]
    [Index(nameof(UserId), Name = "FK_UserDashBoard_Users")]
    public partial class Userdashboard
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DashBoardId { get; set; }
        public bool Deleted { get; set; }
        public int? RoleId { get; set; }

        [ForeignKey(nameof(DashBoardId))]
        [InverseProperty(nameof(Dashboardtemplate.Userdashboards))]
        public virtual Dashboardtemplate DashBoard { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Userdashboards")]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Userdashboards")]
        public virtual User User { get; set; }
    }
}
