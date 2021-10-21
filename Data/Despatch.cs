using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("despatch")]
    [Index(nameof(AccountId), Name = "FK_Despatch_Accounts")]
    [Index(nameof(UnitId), Name = "FK_Despatch_BusinessUnits")]
    [Index(nameof(FinYearId), Name = "FK_Despatch_FinancialYear")]
    [Index(nameof(InwardId), Name = "FK_Despatch_Inward")]
    [Index(nameof(SubCategoryId), Name = "FK_Despatch_InwardSubCategory")]
    [Index(nameof(CategoryId), Name = "FK_Despatch_Masters")]
    [Index(nameof(VoucherId), Name = "FK_Despatch_Voucher")]
    public partial class Despatch
    {
        public Despatch()
        {
            Despatchdtls = new HashSet<Despatchdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int FinYearId { get; set; }
        public int DespatchNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DespatchDate { get; set; }
        [StringLength(15)]
        public string FileNo { get; set; }
        public double? DocumentNo { get; set; }
        [MaxLength(6)]
        public DateTime? DocumentDate { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public int? AccountId { get; set; }
        [StringLength(250)]
        public string Referance { get; set; }
        [StringLength(250)]
        public string Remark { get; set; }
        public bool Status { get; set; }
        public int? InwardId { get; set; }
        public int? VoucherId { get; set; }
        public int UnitId { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Despatches")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.Despatches))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(FinYearId))]
        [InverseProperty(nameof(Financialyear.Despatches))]
        public virtual Financialyear FinYear { get; set; }
        [ForeignKey(nameof(InwardId))]
        [InverseProperty("Despatches")]
        public virtual Inward Inward { get; set; }
        [ForeignKey(nameof(SubCategoryId))]
        [InverseProperty(nameof(Inwardsubcategory.Despatches))]
        public virtual Inwardsubcategory SubCategory { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Despatches))]
        public virtual Businessunit Unit { get; set; }
        [ForeignKey(nameof(VoucherId))]
        [InverseProperty("Despatches")]
        public virtual Voucher Voucher { get; set; }
        [InverseProperty(nameof(Despatchdtl.Despatch))]
        public virtual ICollection<Despatchdtl> Despatchdtls { get; set; }
    }
}
