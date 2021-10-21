using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("role")]
    public partial class Role
    {
        public Role()
        {
            Businessunitroles = new HashSet<Businessunitrole>();
            Tblfavoritemenus = new HashSet<Tblfavoritemenu>();
            Userdashboards = new HashSet<Userdashboard>();
            Userroledashboards = new HashSet<Userroledashboard>();
            Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool Deleted { get; set; }

        [InverseProperty(nameof(Businessunitrole.Role))]
        public virtual ICollection<Businessunitrole> Businessunitroles { get; set; }
        [InverseProperty(nameof(Tblfavoritemenu.LngRole))]
        public virtual ICollection<Tblfavoritemenu> Tblfavoritemenus { get; set; }
        [InverseProperty(nameof(Userdashboard.Role))]
        public virtual ICollection<Userdashboard> Userdashboards { get; set; }
        [InverseProperty(nameof(Userroledashboard.Role))]
        public virtual ICollection<Userroledashboard> Userroledashboards { get; set; }
        [InverseProperty(nameof(User.DefaultRole))]
        public virtual ICollection<User> Users { get; set; }
    }
}
