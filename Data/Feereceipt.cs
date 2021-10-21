using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feereceipt")]
    [Index(nameof(AccountId), Name = "FK_FeeReceipt_Accounts")]
    [Index(nameof(AdmFormId), Name = "FK_FeeReceipt_AdmissionForm")]
    [Index(nameof(UnitId), Name = "FK_FeeReceipt_BusinessUnits")]
    [Index(nameof(ForClassId), Name = "FK_FeeReceipt_Class")]
    [Index(nameof(BankId), Name = "FK_FeeReceipt_Masters1")]
    [Index(nameof(ForFeeGroupId), Name = "FK_FeeReceipt_Masters2")]
    [Index(nameof(RseriesId), Name = "FK_FeeReceipt_ReceiptSeries")]
    [Index(nameof(ScholarId), Name = "FK_FeeReceipt_Scholar")]
    [Index(nameof(SessionId), Name = "FK_FeeReceipt_Session")]
    [Index(nameof(InstallmentId), Name = "FK_FeeReceipt_SessionDtl")]
    [Index(nameof(UserId), Name = "FK_FeeReceipt_Users")]
    [Index(nameof(VoucherId), Name = "FK_FeeReceipt_Voucher")]
    public partial class Feereceipt
    {
        public Feereceipt()
        {
            Feepenalties = new HashSet<Feepenalty>();
            Feereceiptdtls = new HashSet<Feereceiptdtl>();
            Vouchers = new HashSet<Voucher>();
        }

        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        [Column("RSeriesId")]
        public int RseriesId { get; set; }
        public int RecNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime RecDate { get; set; }
        public int? ScholarId { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public int? InstallmentId { get; set; }
        [StringLength(15)]
        public string PayMode { get; set; }
        [StringLength(20)]
        public string ChequeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ChequeDate { get; set; }
        public int? BankId { get; set; }
        [StringLength(40)]
        public string ChequeBranch { get; set; }
        public double? ChequeAmount { get; set; }
        public double? CashAmount { get; set; }
        public double? ReceiptTotal { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ChqReturnDate { get; set; }
        [StringLength(150)]
        public string Remark { get; set; }
        public byte? Printed { get; set; }
        public bool? Posted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PostDate { get; set; }
        public int? ForClassId { get; set; }
        public int? ForFeeGroupId { get; set; }
        public int? AdmFormId { get; set; }
        public bool Deleted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CancelDate { get; set; }
        [StringLength(150)]
        public string CancelReason { get; set; }
        [Column(TypeName = "date")]
        public DateTime TransDate { get; set; }
        public int? UserId { get; set; }
        public int UnitId { get; set; }
        public bool? Submitted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubmittedDate { get; set; }
        [StringLength(50)]
        public string SubmittedRemark { get; set; }
        public double? SubTotal { get; set; }
        public double? BankCharges { get; set; }
        public int? VoucherId { get; set; }
        public double? NextInstDue { get; set; }
        public int? AccountId { get; set; }
        [StringLength(250)]
        public string Narration { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Feereceipts")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(AdmFormId))]
        [InverseProperty(nameof(Admissionform.Feereceipts))]
        public virtual Admissionform AdmForm { get; set; }
        [ForeignKey(nameof(BankId))]
        [InverseProperty(nameof(Master.FeereceiptBanks))]
        public virtual Master Bank { get; set; }
        [ForeignKey(nameof(ForClassId))]
        [InverseProperty(nameof(Class.Feereceipts))]
        public virtual Class ForClass { get; set; }
        [ForeignKey(nameof(ForFeeGroupId))]
        [InverseProperty(nameof(Master.FeereceiptForFeeGroups))]
        public virtual Master ForFeeGroup { get; set; }
        [ForeignKey(nameof(InstallmentId))]
        [InverseProperty(nameof(Sessiondtl.Feereceipts))]
        public virtual Sessiondtl Installment { get; set; }
        [ForeignKey(nameof(RseriesId))]
        [InverseProperty(nameof(Receiptseries.Feereceipts))]
        public virtual Receiptseries Rseries { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Feereceipts")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Feereceipts")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Feereceipts))]
        public virtual Businessunit Unit { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Feereceipts")]
        public virtual User User { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("Feereceipts")]
        public virtual Voucher Voucher { get; set; }
        [InverseProperty(nameof(Feepenalty.FeeReceipt))]
        public virtual ICollection<Feepenalty> Feepenalties { get; set; }
        [InverseProperty(nameof(Feereceiptdtl.Receipt))]
        public virtual ICollection<Feereceiptdtl> Feereceiptdtls { get; set; }
        [InverseProperty("Receipt")]
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
