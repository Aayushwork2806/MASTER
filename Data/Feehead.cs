using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feeheads")]
    [Index(nameof(AccountId), Name = "FK_FeeHeads_Accounts")]
    [Index(nameof(UnitId), Name = "FK_FeeHeads_BusinessUnits")]
    [Index(nameof(CompanyId), Name = "FK_FeeHeads_BusinessUnits1")]
    [Index(nameof(BranchId), Name = "FK_FeeHeads_Masters")]
    public partial class Feehead
    {
        public Feehead()
        {
            Bookissuepolicies = new HashSet<Bookissuepolicy>();
            Classfees = new HashSet<Classfee>();
            Feeadjusteddtls = new HashSet<Feeadjusteddtl>();
            Feeadjusteds = new HashSet<Feeadjusted>();
            Feeclasses = new HashSet<Feeclass>();
            Feegroupfeeheads = new HashSet<Feegroupfeehead>();
            Feepenalties = new HashSet<Feepenalty>();
            Feereceiptdtls = new HashSet<Feereceiptdtl>();
            Feerefunddtls = new HashSet<Feerefunddtl>();
            Feesessions = new HashSet<Feesession>();
            InstituteBusFees = new HashSet<Institute>();
            InstituteLateFees = new HashSet<Institute>();
            InstitutePenalties = new HashSet<Institute>();
            InstituteSiblingDiscFees = new HashSet<Institute>();
            InstituteStaffDiscFees = new HashSet<Institute>();
            Scholarfees = new HashSet<Scholarfee>();
            Scholaroptfees = new HashSet<Scholaroptfee>();
            Scholarpreviousdues = new HashSet<Scholarpreviousdue>();
            Tmpfeereceiptdtls = new HashSet<Tmpfeereceiptdtl>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string FeeName { get; set; }
        [StringLength(10)]
        public string ShortName { get; set; }
        public int? PrintSeq { get; set; }
        [StringLength(1)]
        public string PayMode { get; set; }
        [StringLength(1)]
        public string ApplFor { get; set; }
        [StringLength(1)]
        public string FeeType { get; set; }
        [StringLength(1)]
        public string Type { get; set; }
        [StringLength(1)]
        public string Refund { get; set; }
        [StringLength(1)]
        public string Effect { get; set; }
        public bool? Discount { get; set; }
        public bool? Include { get; set; }
        public double? Amount { get; set; }
        public int? CompanyId { get; set; }
        public int? AccountId { get; set; }
        public int? BranchId { get; set; }
        [Column("PostCMoney")]
        public bool? PostCmoney { get; set; }
        public bool? HostelFee { get; set; }
        public bool? AdmFormFee { get; set; }
        public int UnitId { get; set; }
        public bool Deleted { get; set; }
        public bool? PocketMoney { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Feeheads")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(BranchId))]
        [InverseProperty(nameof(Master.Feeheads))]
        public virtual Master Branch { get; set; }
        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Businessunit.FeeheadCompanies))]
        public virtual Businessunit Company { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.FeeheadUnits))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Bookissuepolicy.FeeHead))]
        public virtual ICollection<Bookissuepolicy> Bookissuepolicies { get; set; }
        [InverseProperty(nameof(Classfee.Fee))]
        public virtual ICollection<Classfee> Classfees { get; set; }
        [InverseProperty(nameof(Feeadjusteddtl.FeeHead))]
        public virtual ICollection<Feeadjusteddtl> Feeadjusteddtls { get; set; }
        [InverseProperty(nameof(Feeadjusted.FeeHead))]
        public virtual ICollection<Feeadjusted> Feeadjusteds { get; set; }
        [InverseProperty(nameof(Feeclass.Fee))]
        public virtual ICollection<Feeclass> Feeclasses { get; set; }
        [InverseProperty(nameof(Feegroupfeehead.Fee))]
        public virtual ICollection<Feegroupfeehead> Feegroupfeeheads { get; set; }
        [InverseProperty(nameof(Feepenalty.FeeHead))]
        public virtual ICollection<Feepenalty> Feepenalties { get; set; }
        [InverseProperty(nameof(Feereceiptdtl.FeeHead))]
        public virtual ICollection<Feereceiptdtl> Feereceiptdtls { get; set; }
        [InverseProperty(nameof(Feerefunddtl.FeeHead))]
        public virtual ICollection<Feerefunddtl> Feerefunddtls { get; set; }
        [InverseProperty(nameof(Feesession.Fee))]
        public virtual ICollection<Feesession> Feesessions { get; set; }
        [InverseProperty(nameof(Institute.BusFee))]
        public virtual ICollection<Institute> InstituteBusFees { get; set; }
        [InverseProperty(nameof(Institute.LateFee))]
        public virtual ICollection<Institute> InstituteLateFees { get; set; }
        [InverseProperty(nameof(Institute.Penalty))]
        public virtual ICollection<Institute> InstitutePenalties { get; set; }
        [InverseProperty(nameof(Institute.SiblingDiscFee))]
        public virtual ICollection<Institute> InstituteSiblingDiscFees { get; set; }
        [InverseProperty(nameof(Institute.StaffDiscFee))]
        public virtual ICollection<Institute> InstituteStaffDiscFees { get; set; }
        [InverseProperty(nameof(Scholarfee.Fee))]
        public virtual ICollection<Scholarfee> Scholarfees { get; set; }
        [InverseProperty(nameof(Scholaroptfee.Fee))]
        public virtual ICollection<Scholaroptfee> Scholaroptfees { get; set; }
        [InverseProperty(nameof(Scholarpreviousdue.FeeHead))]
        public virtual ICollection<Scholarpreviousdue> Scholarpreviousdues { get; set; }
        [InverseProperty(nameof(Tmpfeereceiptdtl.FeeHead))]
        public virtual ICollection<Tmpfeereceiptdtl> Tmpfeereceiptdtls { get; set; }
    }
}
