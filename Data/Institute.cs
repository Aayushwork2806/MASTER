using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("institutes")]
    [Index(nameof(UnitId), Name = "FK_Institutes_BusinessUnits")]
    [Index(nameof(BusFeeId), Name = "FK_Institutes_FeeHeads")]
    [Index(nameof(LateFeeId), Name = "FK_Institutes_FeeHeads1")]
    [Index(nameof(SiblingDiscFeeId), Name = "FK_Institutes_FeeHeads2")]
    [Index(nameof(StaffDiscFeeId), Name = "FK_Institutes_FeeHeads3")]
    [Index(nameof(PenaltyId), Name = "FK_Institutes_FeeHeads4")]
    [Index(nameof(SessionId), Name = "FK_Institutes_Session")]
    [Index(nameof(LngUpdatedBy), Name = "FK_Institutes_Users")]
    public partial class Institute
    {
        [Key]
        public int Id { get; set; }
        public int UnitId { get; set; }
        [StringLength(1)]
        public string SchoolType { get; set; }
        [StringLength(100)]
        public string SchoolName { get; set; }
        [StringLength(30)]
        public string PrincipalName { get; set; }
        [StringLength(50)]
        public string Board { get; set; }
        [StringLength(25)]
        public string BoardRegNo { get; set; }
        [StringLength(25)]
        public string SchoolCode { get; set; }
        [StringLength(20)]
        public string BusinessNo { get; set; }
        [StringLength(1)]
        public string LateFeeMode { get; set; }
        public double? LateFeeAmt { get; set; }
        public int? LateFeeId { get; set; }
        [StringLength(1)]
        public string RecSeries { get; set; }
        [StringLength(1)]
        public string RecReset { get; set; }
        [StringLength(1)]
        public string RecStationary { get; set; }
        [StringLength(1)]
        public string RecFormat { get; set; }
        public short? ReceiptCopies { get; set; }
        [StringLength(1)]
        public string NextRno { get; set; }
        [StringLength(200)]
        public string RptFooter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(100)]
        public string RptPath { get; set; }
        [StringLength(1)]
        public string BusFees { get; set; }
        public int? DisplaySeq { get; set; }
        [StringLength(1)]
        public string PrevRecpDisplay { get; set; }
        [Column("FeeHDRno")]
        [StringLength(1)]
        public string FeeHdrno { get; set; }
        public int? BusFeeId { get; set; }
        public int? StaffDiscFeeId { get; set; }
        public int? SiblingDiscFeeId { get; set; }
        public long? SiblingDiscPer { get; set; }
        public long? StaffDisc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SysLockDate { get; set; }
        [StringLength(1)]
        public string AutoDateLock { get; set; }
        [StringLength(10)]
        public string CustCode { get; set; }
        public int? SessionId { get; set; }
        public bool? Deleted { get; set; }
        public byte[] PhotoPath { get; set; }
        [StringLength(1)]
        public string AttnMode { get; set; }
        [StringLength(1)]
        public string MarksEntry { get; set; }
        [Column("SMSForReceipt")]
        public bool SmsforReceipt { get; set; }
        [Column("SMSReceiptType")]
        [StringLength(1)]
        public string SmsreceiptType { get; set; }
        public int? BusFeeInst { get; set; }
        [StringLength(50)]
        public string ReceiptFormat { get; set; }
        public byte[] PhotoLogo { get; set; }
        public int? PenaltyId { get; set; }
        public int? ReceiptSeriesId { get; set; }
        public int? ReceiptSeriesOnlineId { get; set; }
        public bool Paymentgateway { get; set; }
        public bool? Otp { get; set; }
        [Column("CCardPer")]
        public double? CcardPer { get; set; }
        [Column("DCardPer")]
        public double? DcardPer { get; set; }
        [StringLength(1)]
        public string GenrateSchNo { get; set; }
        [StringLength(2)]
        public string FeePosting { get; set; }
        [Column("CreatePUser")]
        public bool CreatePuser { get; set; }
        [StringLength(15)]
        public string DefPayMode { get; set; }
        public int? VoucherAcId { get; set; }
        public double? LateMarking { get; set; }
        public int? ApplCategoryId { get; set; }
        public int? ApplAssignedTo { get; set; }
        [Column("TCFormat")]
        [StringLength(0)]
        public string Tcformat { get; set; }
        public bool? BatchWiseStock { get; set; }
        [Column("lngUpdatedBy")]
        public int? LngUpdatedBy { get; set; }
        [Column("datUpdatedDate")]
        [MaxLength(6)]
        public DateTime? DatUpdatedDate { get; set; }
        public int? ReportDays { get; set; }
        [Required]
        public bool? IsSameLibrary { get; set; }

        [ForeignKey(nameof(BusFeeId))]
        [InverseProperty(nameof(Feehead.InstituteBusFees))]
        public virtual Feehead BusFee { get; set; }
        [ForeignKey(nameof(LateFeeId))]
        [InverseProperty(nameof(Feehead.InstituteLateFees))]
        public virtual Feehead LateFee { get; set; }
        [ForeignKey(nameof(LngUpdatedBy))]
        [InverseProperty(nameof(User.Institutes))]
        public virtual User LngUpdatedByNavigation { get; set; }
        [ForeignKey(nameof(PenaltyId))]
        [InverseProperty(nameof(Feehead.InstitutePenalties))]
        public virtual Feehead Penalty { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Institutes")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SiblingDiscFeeId))]
        [InverseProperty(nameof(Feehead.InstituteSiblingDiscFees))]
        public virtual Feehead SiblingDiscFee { get; set; }
        [ForeignKey(nameof(StaffDiscFeeId))]
        [InverseProperty(nameof(Feehead.InstituteStaffDiscFees))]
        public virtual Feehead StaffDiscFee { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Institutes))]
        public virtual Businessunit Unit { get; set; }
    }
}
