using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("financialyear")]
    public partial class Financialyear
    {
        public Financialyear()
        {
            Bonussetups = new HashSet<Bonussetup>();
            Businessunits = new HashSet<Businessunit>();
            Despatches = new HashSet<Despatch>();
            Employeebonus = new HashSet<Employeebonu>();
            Inwards = new HashSet<Inward>();
            Openingbalances = new HashSet<Openingbalance>();
            Professionaltaxslabs = new HashSet<Professionaltaxslab>();
            Tdsslabs = new HashSet<Tdsslab>();
            Users = new HashSet<User>();
            Vouchers = new HashSet<Voucher>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string FinYearDescription { get; set; }
        [StringLength(4)]
        public string ShortName { get; set; }
        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ToDate { get; set; }
        public bool Deleted { get; set; }

        [InverseProperty(nameof(Bonussetup.FinYear))]
        public virtual ICollection<Bonussetup> Bonussetups { get; set; }
        [InverseProperty(nameof(Businessunit.DefaultFinYear))]
        public virtual ICollection<Businessunit> Businessunits { get; set; }
        [InverseProperty(nameof(Despatch.FinYear))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Employeebonu.FinYear))]
        public virtual ICollection<Employeebonu> Employeebonus { get; set; }
        [InverseProperty(nameof(Inward.FinYear))]
        public virtual ICollection<Inward> Inwards { get; set; }
        [InverseProperty(nameof(Openingbalance.FinYear))]
        public virtual ICollection<Openingbalance> Openingbalances { get; set; }
        [InverseProperty(nameof(Professionaltaxslab.AssmentYear))]
        public virtual ICollection<Professionaltaxslab> Professionaltaxslabs { get; set; }
        [InverseProperty(nameof(Tdsslab.AssessmentYear))]
        public virtual ICollection<Tdsslab> Tdsslabs { get; set; }
        [InverseProperty(nameof(User.DefaultFinYear))]
        public virtual ICollection<User> Users { get; set; }
        [InverseProperty(nameof(Voucher.FinYear))]
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
