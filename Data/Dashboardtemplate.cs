using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("dashboardtemplates")]
    public partial class Dashboardtemplate
    {
        public Dashboardtemplate()
        {
            Userdashboards = new HashSet<Userdashboard>();
            Userroledashboards = new HashSet<Userroledashboard>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DbTemplate { get; set; }
        public bool Deleted { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public byte[] TemplateImage { get; set; }
        [StringLength(50)]
        public string TemplateText { get; set; }
        [StringLength(50)]
        public string Templatehref { get; set; }

        [InverseProperty(nameof(Userdashboard.DashBoard))]
        public virtual ICollection<Userdashboard> Userdashboards { get; set; }
        [InverseProperty(nameof(Userroledashboard.DashBoard))]
        public virtual ICollection<Userroledashboard> Userroledashboards { get; set; }
    }
}
