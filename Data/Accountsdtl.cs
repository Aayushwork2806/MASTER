using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("accountsdtl")]
    [Index(nameof(AccountsId), Name = "FK_AccountsDtl_Accounts")]
    [Index(nameof(CityId), Name = "FK_AccountsDtl_Masters")]
    [Index(nameof(StateId), Name = "FK_AccountsDtl_Masters1")]
    public partial class Accountsdtl
    {
        [Key]
        public int Id { get; set; }
        public int AccountsId { get; set; }
        [StringLength(30)]
        public string ContactPerson { get; set; }
        [StringLength(100)]
        public string Address1 { get; set; }
        [StringLength(100)]
        public string Address2 { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        [StringLength(6)]
        public string Pin { get; set; }
        [StringLength(25)]
        public string PhoneOff { get; set; }
        [StringLength(25)]
        public string PhoneWorks { get; set; }
        [StringLength(25)]
        public string FaxNo { get; set; }
        [StringLength(25)]
        public string Mobile { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Website { get; set; }
        [Column("TINNO")]
        [StringLength(25)]
        public string Tinno { get; set; }
        [Column("TINDate", TypeName = "date")]
        public DateTime? Tindate { get; set; }
        public double? CreditPeriod { get; set; }
        public double? CreditLimit { get; set; }

        [ForeignKey(nameof(AccountsId))]
        [InverseProperty(nameof(Account.Accountsdtls))]
        public virtual Account Accounts { get; set; }
        [ForeignKey(nameof(CityId))]
        [InverseProperty(nameof(Master.AccountsdtlCities))]
        public virtual Master City { get; set; }
        [ForeignKey(nameof(StateId))]
        [InverseProperty(nameof(Master.AccountsdtlStates))]
        public virtual Master State { get; set; }
    }
}
