using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("userbusinessunitroles")]
    [Index(nameof(BusinessUnitRolesId), Name = "FK_UserBusinessUnitRoles_BusinessUnitRoles")]
    [Index(nameof(UserId), Name = "FK_UserBusinessUnitRoles_Users")]
    public partial class Userbusinessunitrole
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BusinessUnitRolesId { get; set; }

        [ForeignKey(nameof(BusinessUnitRolesId))]
        [InverseProperty(nameof(Businessunitrole.Userbusinessunitroles))]
        public virtual Businessunitrole BusinessUnitRoles { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Userbusinessunitroles")]
        public virtual User User { get; set; }
    }
}
