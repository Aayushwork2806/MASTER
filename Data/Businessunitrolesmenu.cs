using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("businessunitrolesmenu")]
    [Index(nameof(BusinessUnitRolesId), Name = "FK_BusinessUnitRolesMenu_BusinessUnitRoles")]
    [Index(nameof(MenuId), Name = "FK_BusinessUnitRolesMenu_Menus")]
    public partial class Businessunitrolesmenu
    {
        [Key]
        public int Id { get; set; }
        public int BusinessUnitRolesId { get; set; }
        public int MenuId { get; set; }
        public bool CanRead { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanAdd { get; set; }
        public bool CanPrint { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(BusinessUnitRolesId))]
        [InverseProperty(nameof(Businessunitrole.Businessunitrolesmenus))]
        public virtual Businessunitrole BusinessUnitRoles { get; set; }
        [ForeignKey(nameof(MenuId))]
        [InverseProperty("Businessunitrolesmenus")]
        public virtual Menu Menu { get; set; }
    }
}
