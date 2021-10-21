using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("inward")]
    [Index(nameof(SupplierId), Name = "FK_Inward_Accounts")]
    [Index(nameof(UnitId), Name = "FK_Inward_BusinessUnits")]
    [Index(nameof(FinYearId), Name = "FK_Inward_FinancialYear")]
    [Index(nameof(SubCategoryId), Name = "FK_Inward_InwardSubCategory")]
    [Index(nameof(CategoryId), Name = "FK_Inward_Masters")]
    [Index(nameof(VoucherId), Name = "FK_Inward_Voucher")]
    public partial class Inward
    {
        public Inward()
        {
            Despatches = new HashSet<Despatch>();
            Inwarddetails = new HashSet<Inwarddetail>();
            Taskschedulers = new HashSet<Taskscheduler>();
        }

        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int FinYearId { get; set; }
        public int InwardNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime InwardDate { get; set; }
        [StringLength(15)]
        public string FileNo { get; set; }
        public double? DocumentNo { get; set; }
        [MaxLength(6)]
        public DateTime? DocumentDate { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public int? ForwardToId { get; set; }
        [StringLength(50)]
        public string ForwardToText { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
        public bool IsBillPaid { get; set; }
        [StringLength(15)]
        public string BillNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BillDate { get; set; }
        public int? SupplierId { get; set; }
        [StringLength(10)]
        public string PaymentMode { get; set; }
        [StringLength(8)]
        public string ChequeNo { get; set; }
        public double? Amount { get; set; }
        [StringLength(250)]
        public string Remark { get; set; }
        public bool Status { get; set; }
        public int? DespatchId { get; set; }
        public int? VoucherId { get; set; }
        public int UnitId { get; set; }
        public int? ScholarId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.Inwards))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(FinYearId))]
        [InverseProperty(nameof(Financialyear.Inwards))]
        public virtual Financialyear FinYear { get; set; }
        [ForeignKey(nameof(SubCategoryId))]
        [InverseProperty(nameof(Inwardsubcategory.Inwards))]
        public virtual Inwardsubcategory SubCategory { get; set; }
        [ForeignKey(nameof(SupplierId))]
        [InverseProperty(nameof(Account.Inwards))]
        public virtual Account Supplier { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Inwards))]
        public virtual Businessunit Unit { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("Inwards")]
        public virtual Voucher Voucher { get; set; }
        [InverseProperty(nameof(Despatch.Inward))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Inwarddetail.Inward))]
        public virtual ICollection<Inwarddetail> Inwarddetails { get; set; }
        [InverseProperty(nameof(Taskscheduler.Inward))]
        public virtual ICollection<Taskscheduler> Taskschedulers { get; set; }
    }
}
