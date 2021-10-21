using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseinquiry")]
    [Index(nameof(SupplierAccId), Name = "FK_PurchaseInquiry_Accounts")]
    [Index(nameof(BusinessUnitId), Name = "FK_PurchaseInquiry_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_PurchaseInquiry_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PurchaseInquiry_Users")]
    public partial class Purchaseinquiry
    {
        public Purchaseinquiry()
        {
            Purchaseinquirydetails = new HashSet<Purchaseinquirydetail>();
        }

        [Key]
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public int StoreId { get; set; }
        [Required]
        [StringLength(2)]
        public string SourceDoc { get; set; }
        public int AddedBy { get; set; }
        [MaxLength(6)]
        public DateTime AddedOn { get; set; }
        public int BusinessUnitId { get; set; }
        public int? SupplierAccId { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Purchaseinquiries))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Purchaseinquiries))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Purchaseinquiries")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(SupplierAccId))]
        [InverseProperty(nameof(Account.Purchaseinquiries))]
        public virtual Account SupplierAcc { get; set; }
        [InverseProperty(nameof(Purchaseinquirydetail.PurchaseInquiry))]
        public virtual ICollection<Purchaseinquirydetail> Purchaseinquirydetails { get; set; }
    }
}
