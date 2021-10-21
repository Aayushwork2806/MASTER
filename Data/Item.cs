using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("items")]
    [Index(nameof(PurchaseAccountId), Name = "FK_Items_Account")]
    [Index(nameof(AccountId), Name = "FK_Items_Accounts")]
    [Index(nameof(ItemCategoryId), Name = "FK_Items_Masters")]
    [Index(nameof(Uom1id), Name = "FK_Items_Masters1")]
    [Index(nameof(Uom2id), Name = "FK_Items_Masters2")]
    [Index(nameof(ManufacturerId), Name = "FK_Items_Masters3")]
    [Index(nameof(DrugCategoryId), Name = "FK_Items_Masters4")]
    [Index(nameof(DrugGroupId), Name = "FK_Items_Masters5")]
    [Index(nameof(SubCategoryId), Name = "FK_Items_Masters6")]
    [Index(nameof(SaleTaxId), Name = "FK_Items_Tax")]
    [Index(nameof(PurchaseTaxId), Name = "FK_Items_Tax1")]
    public partial class Item
    {
        public Item()
        {
            Departmentconsumptions = new HashSet<Departmentconsumption>();
            Itemstoremappings = new HashSet<Itemstoremapping>();
            Itemsuppliermappings = new HashSet<Itemsuppliermapping>();
            Materialissuedetails = new HashSet<Materialissuedetail>();
            Materialreceiptdetails = new HashSet<Materialreceiptdetail>();
            Materialrequisitiondetails = new HashSet<Materialrequisitiondetail>();
            Materialreturndetails = new HashSet<Materialreturndetail>();
            Openingstocks = new HashSet<Openingstock>();
            Physicalstockdetails = new HashSet<Physicalstockdetail>();
            Purchaseindentdetails = new HashSet<Purchaseindentdetail>();
            Purchaseinquirydetails = new HashSet<Purchaseinquirydetail>();
            Purchaseinvoicedetails = new HashSet<Purchaseinvoicedetail>();
            Purchaseorderdetails = new HashSet<Purchaseorderdetail>();
            Purchasequotationdetails = new HashSet<Purchasequotationdetail>();
            Purchasereturndetails = new HashSet<Purchasereturndetail>();
            Stockattributes = new HashSet<Stockattribute>();
            Stockdetails = new HashSet<Stockdetail>();
            Stockreceivedetails = new HashSet<Stockreceivedetail>();
            Stocktransferdetails = new HashSet<Stocktransferdetail>();
            Stocktransferrequestdetails = new HashSet<Stocktransferrequestdetail>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ItemDescritpion { get; set; }
        public int ItemCategoryId { get; set; }
        [Column("UOM1Id")]
        public int Uom1id { get; set; }
        public int Contain { get; set; }
        [Column("UOM2Id")]
        public int Uom2id { get; set; }
        public int? ManufacturerId { get; set; }
        public int? GenericDrugId { get; set; }
        public int? DrugCategoryId { get; set; }
        public int? DrugGroupId { get; set; }
        public bool IsBatchRequired { get; set; }
        public bool IsExpiryDateRequired { get; set; }
        public bool IsPurchaseItem { get; set; }
        public bool IsSaleItem { get; set; }
        public bool IsFixedAsset { get; set; }
        public bool ShowInPharmacyTransaction { get; set; }
        [StringLength(150)]
        public string Remark { get; set; }
        public decimal? MinQty { get; set; }
        public decimal? MaxQty { get; set; }
        public decimal? ReOrderLevel { get; set; }
        [StringLength(20)]
        public string ItemCode { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public int? AccountId { get; set; }
        public int? PurchaseAccountId { get; set; }
        public bool IsInclude { get; set; }
        public bool IsExclude { get; set; }
        public int? SaleTaxId { get; set; }
        public int? PurchaseTaxId { get; set; }
        public int? SubCategoryId { get; set; }
        public decimal? PurchaseRate { get; set; }
        public decimal? SaleRate { get; set; }
        [Column("MRP")]
        public decimal? Mrp { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("ItemAccounts")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(DrugCategoryId))]
        [InverseProperty(nameof(Master.ItemDrugCategories))]
        public virtual Master DrugCategory { get; set; }
        [ForeignKey(nameof(DrugGroupId))]
        [InverseProperty(nameof(Master.ItemDrugGroups))]
        public virtual Master DrugGroup { get; set; }
        [ForeignKey(nameof(ItemCategoryId))]
        [InverseProperty(nameof(Master.ItemItemCategories))]
        public virtual Master ItemCategory { get; set; }
        [ForeignKey(nameof(ManufacturerId))]
        [InverseProperty(nameof(Master.ItemManufacturers))]
        public virtual Master Manufacturer { get; set; }
        [ForeignKey(nameof(PurchaseAccountId))]
        [InverseProperty("ItemPurchaseAccounts")]
        public virtual Account PurchaseAccount { get; set; }
        [ForeignKey(nameof(PurchaseTaxId))]
        [InverseProperty(nameof(Tax.ItemPurchaseTaxes))]
        public virtual Tax PurchaseTax { get; set; }
        [ForeignKey(nameof(SaleTaxId))]
        [InverseProperty(nameof(Tax.ItemSaleTaxes))]
        public virtual Tax SaleTax { get; set; }
        [ForeignKey(nameof(SubCategoryId))]
        [InverseProperty(nameof(Master.ItemSubCategories))]
        public virtual Master SubCategory { get; set; }
        [ForeignKey(nameof(Uom1id))]
        [InverseProperty(nameof(Master.ItemUom1s))]
        public virtual Master Uom1 { get; set; }
        [ForeignKey(nameof(Uom2id))]
        [InverseProperty(nameof(Master.ItemUom2s))]
        public virtual Master Uom2 { get; set; }
        [InverseProperty(nameof(Departmentconsumption.Item))]
        public virtual ICollection<Departmentconsumption> Departmentconsumptions { get; set; }
        [InverseProperty(nameof(Itemstoremapping.Item))]
        public virtual ICollection<Itemstoremapping> Itemstoremappings { get; set; }
        [InverseProperty(nameof(Itemsuppliermapping.Item))]
        public virtual ICollection<Itemsuppliermapping> Itemsuppliermappings { get; set; }
        [InverseProperty(nameof(Materialissuedetail.Item))]
        public virtual ICollection<Materialissuedetail> Materialissuedetails { get; set; }
        [InverseProperty(nameof(Materialreceiptdetail.Item))]
        public virtual ICollection<Materialreceiptdetail> Materialreceiptdetails { get; set; }
        [InverseProperty(nameof(Materialrequisitiondetail.Item))]
        public virtual ICollection<Materialrequisitiondetail> Materialrequisitiondetails { get; set; }
        [InverseProperty(nameof(Materialreturndetail.Item))]
        public virtual ICollection<Materialreturndetail> Materialreturndetails { get; set; }
        [InverseProperty(nameof(Openingstock.Item))]
        public virtual ICollection<Openingstock> Openingstocks { get; set; }
        [InverseProperty(nameof(Physicalstockdetail.Item))]
        public virtual ICollection<Physicalstockdetail> Physicalstockdetails { get; set; }
        [InverseProperty(nameof(Purchaseindentdetail.Item))]
        public virtual ICollection<Purchaseindentdetail> Purchaseindentdetails { get; set; }
        [InverseProperty(nameof(Purchaseinquirydetail.Item))]
        public virtual ICollection<Purchaseinquirydetail> Purchaseinquirydetails { get; set; }
        [InverseProperty(nameof(Purchaseinvoicedetail.Item))]
        public virtual ICollection<Purchaseinvoicedetail> Purchaseinvoicedetails { get; set; }
        [InverseProperty(nameof(Purchaseorderdetail.Item))]
        public virtual ICollection<Purchaseorderdetail> Purchaseorderdetails { get; set; }
        [InverseProperty(nameof(Purchasequotationdetail.Item))]
        public virtual ICollection<Purchasequotationdetail> Purchasequotationdetails { get; set; }
        [InverseProperty(nameof(Purchasereturndetail.Item))]
        public virtual ICollection<Purchasereturndetail> Purchasereturndetails { get; set; }
        [InverseProperty(nameof(Stockattribute.Item))]
        public virtual ICollection<Stockattribute> Stockattributes { get; set; }
        [InverseProperty(nameof(Stockdetail.Item))]
        public virtual ICollection<Stockdetail> Stockdetails { get; set; }
        [InverseProperty(nameof(Stockreceivedetail.Item))]
        public virtual ICollection<Stockreceivedetail> Stockreceivedetails { get; set; }
        [InverseProperty(nameof(Stocktransferdetail.Item))]
        public virtual ICollection<Stocktransferdetail> Stocktransferdetails { get; set; }
        [InverseProperty(nameof(Stocktransferrequestdetail.Item))]
        public virtual ICollection<Stocktransferrequestdetail> Stocktransferrequestdetails { get; set; }
    }
}
