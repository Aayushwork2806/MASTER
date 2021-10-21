using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("openingbalance")]
    [Index(nameof(AccountId), Name = "FK_OpeningBalance_Accounts")]
    [Index(nameof(FinYearId), Name = "FK_OpeningBalance_FinancialYear")]
    public partial class Openingbalance
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int FinYearId { get; set; }
        public double? OpeningBal { get; set; }
        public bool Deleted { get; set; }
        [StringLength(1)]
        public string DrCr { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Openingbalances")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(FinYearId))]
        [InverseProperty(nameof(Financialyear.Openingbalances))]
        public virtual Financialyear FinYear { get; set; }
    }
}
