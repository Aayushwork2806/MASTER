using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("materialreceipt")]
    [Index(nameof(SupplierAccId), Name = "FK_MaterialReceipt_Accounts")]
    [Index(nameof(BusinessUnitId), Name = "FK_MaterialReceipt_BusinessUnits")]
    [Index(nameof(StoreId), Name = "FK_MaterialReceipt_Stores")]
    [Index(nameof(AddedBy), Name = "FK_MaterialReceipt_Users")]
    public partial class Materialreceipt
    {
        public Materialreceipt()
        {
            Materialreceiptdetails = new HashSet<Materialreceiptdetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime MaterialReceiptDate { get; set; }
        public int? SupplierId { get; set; }
        [Required]
        [StringLength(25)]
        public string SupplierRefNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SupplierDocDate { get; set; }
        public int BusinessUnitId { get; set; }
        public int StoreId { get; set; }
        public int AddedBy { get; set; }
        public int? SupplierAccId { get; set; }
        [Column("MRNo")]
        public int? Mrno { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.Materialreceipts))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Materialreceipts))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Materialreceipts")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(SupplierAccId))]
        [InverseProperty(nameof(Account.Materialreceipts))]
        public virtual Account SupplierAcc { get; set; }
        [InverseProperty(nameof(Materialreceiptdetail.MaterialReceipt))]
        public virtual ICollection<Materialreceiptdetail> Materialreceiptdetails { get; set; }
    }
}
