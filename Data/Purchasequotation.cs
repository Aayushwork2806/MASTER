using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchasequotation")]
    [Index(nameof(SupplierAccId), Name = "FK_PurchaseQuotation_Accounts")]
    [Index(nameof(BusinessUnitId), Name = "FK_PurchaseQuotation_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_PurchaseQuotation_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PurchaseQuotation_Users")]
    public partial class Purchasequotation
    {
        public Purchasequotation()
        {
            Purchasequotationdetails = new HashSet<Purchasequotationdetail>();
            Purchasequotationremarks = new HashSet<Purchasequotationremark>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime QuotationDate { get; set; }
        [StringLength(25)]
        public string SupplierRefNo { get; set; }
        public int? SupplierId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValidTill { get; set; }
        public decimal BasicAmount { get; set; }
        public decimal? BillDiscount { get; set; }
        public decimal? BillDiscountPer { get; set; }
        public decimal AmountAfterDiscount { get; set; }
        public decimal AmountAfterTax { get; set; }
        [Required]
        [StringLength(2)]
        public string SourceDoc { get; set; }
        public int AddedBy { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? StoreId { get; set; }
        public int? SupplierAccId { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Purchasequotations))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Purchasequotations))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Purchasequotations")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(SupplierAccId))]
        [InverseProperty(nameof(Account.Purchasequotations))]
        public virtual Account SupplierAcc { get; set; }
        [InverseProperty(nameof(Purchasequotationdetail.PurchaseQuotation))]
        public virtual ICollection<Purchasequotationdetail> Purchasequotationdetails { get; set; }
        [InverseProperty(nameof(Purchasequotationremark.PurchaseQuotation))]
        public virtual ICollection<Purchasequotationremark> Purchasequotationremarks { get; set; }
    }
}
