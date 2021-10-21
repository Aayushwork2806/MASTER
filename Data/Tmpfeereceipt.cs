using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tmpfeereceipt")]
    [Index(nameof(UnitId), Name = "FK_tmpFeeReceipt_BusinessUnits")]
    [Index(nameof(ForClassId), Name = "FK_tmpFeeReceipt_Class")]
    [Index(nameof(BankId), Name = "FK_tmpFeeReceipt_Masters1")]
    [Index(nameof(ForFeeGroupId), Name = "FK_tmpFeeReceipt_Masters2")]
    [Index(nameof(RseriesId), Name = "FK_tmpFeeReceipt_ReceiptSeries")]
    [Index(nameof(ScholarId), Name = "FK_tmpFeeReceipt_Scholar")]
    [Index(nameof(SessionId), Name = "FK_tmpFeeReceipt_Session")]
    [Index(nameof(InstallmentId), Name = "FK_tmpFeeReceipt_SessionDtl")]
    [Index(nameof(UserId), Name = "FK_tmpFeeReceipt_Users")]
    [Index(nameof(AdmFormId), Name = "FK_tmpFeeReceipt_tmpAdmissionForm")]
    public partial class Tmpfeereceipt
    {
        public Tmpfeereceipt()
        {
            Tmpfeereceiptdtls = new HashSet<Tmpfeereceiptdtl>();
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
        [StringLength(50)]
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
        [StringLength(50)]
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

        [ForeignKey(nameof(AdmFormId))]
        [InverseProperty(nameof(Tmpadmissionform.Tmpfeereceipts))]
        public virtual Tmpadmissionform AdmForm { get; set; }
        [ForeignKey(nameof(BankId))]
        [InverseProperty(nameof(Master.TmpfeereceiptBanks))]
        public virtual Master Bank { get; set; }
        [ForeignKey(nameof(ForClassId))]
        [InverseProperty(nameof(Class.Tmpfeereceipts))]
        public virtual Class ForClass { get; set; }
        [ForeignKey(nameof(ForFeeGroupId))]
        [InverseProperty(nameof(Master.TmpfeereceiptForFeeGroups))]
        public virtual Master ForFeeGroup { get; set; }
        [ForeignKey(nameof(InstallmentId))]
        [InverseProperty(nameof(Sessiondtl.Tmpfeereceipts))]
        public virtual Sessiondtl Installment { get; set; }
        [ForeignKey(nameof(RseriesId))]
        [InverseProperty(nameof(Receiptseries.Tmpfeereceipts))]
        public virtual Receiptseries Rseries { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Tmpfeereceipts")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Tmpfeereceipts")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Tmpfeereceipts))]
        public virtual Businessunit Unit { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Tmpfeereceipts")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Tmpfeereceiptdtl.Receipt))]
        public virtual ICollection<Tmpfeereceiptdtl> Tmpfeereceiptdtls { get; set; }
    }
}
