using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("leaveyear")]
    public partial class Leaveyear
    {
        public Leaveyear()
        {
            Employeeleaves = new HashSet<Employeeleaf>();
            Financialunits = new HashSet<Financialunit>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string LeaveYearDescription { get; set; }
        [StringLength(4)]
        public string ShortName { get; set; }
        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }
        public bool Deleted { get; set; }

        [InverseProperty(nameof(Employeeleaf.LeaveYear))]
        public virtual ICollection<Employeeleaf> Employeeleaves { get; set; }
        [InverseProperty(nameof(Financialunit.LeaveYear))]
        public virtual ICollection<Financialunit> Financialunits { get; set; }
    }
}
