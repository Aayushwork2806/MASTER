using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("stores")]
    [Index(nameof(BusinessUnitId), Name = "FK_Stores_BusinessUnits")]
    [Index(nameof(YearEndBy), Name = "FK_Stores_Users")]
    public partial class Store
    {
        public Store()
        {
            Itemstoremappings = new HashSet<Itemstoremapping>();
            Materialissues = new HashSet<Materialissue>();
            Materialreceipts = new HashSet<Materialreceipt>();
            Materialrequisitions = new HashSet<Materialrequisition>();
            Materialreturns = new HashSet<Materialreturn>();
            Openingstocks = new HashSet<Openingstock>();
            Physicalstocks = new HashSet<Physicalstock>();
            Purchaseindents = new HashSet<Purchaseindent>();
            Purchaseinquiries = new HashSet<Purchaseinquiry>();
            Purchaseinvoices = new HashSet<Purchaseinvoice>();
            Purchaseorders = new HashSet<Purchaseorder>();
            Purchasequotations = new HashSet<Purchasequotation>();
            Purchasereturns = new HashSet<Purchasereturn>();
            Stockdetails = new HashSet<Stockdetail>();
            StockreceiveFromStores = new HashSet<Stockreceive>();
            StockreceiveToStores = new HashSet<Stockreceive>();
            StocktransferFromStores = new HashSet<Stocktransfer>();
            StocktransferToStores = new HashSet<Stocktransfer>();
            StocktransferrequestFromStores = new HashSet<Stocktransferrequest>();
            StocktransferrequestToStores = new HashSet<Stocktransferrequest>();
            StorestoremappingStoreId1Navigations = new HashSet<Storestoremapping>();
            StorestoremappingStoreId2Navigations = new HashSet<Storestoremapping>();
            Subdepartmentstoresmappings = new HashSet<Subdepartmentstoresmapping>();
            Userstoremappings = new HashSet<Userstoremapping>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string StoresDesc { get; set; }
        [Required]
        [StringLength(20)]
        public string StoresShortName { get; set; }
        public int BusinessUnitId { get; set; }
        [MaxLength(6)]
        public DateTime StartDate { get; set; }
        [MaxLength(6)]
        public DateTime EndDate { get; set; }
        public bool CanPurchase { get; set; }
        public bool CanSale { get; set; }
        public bool IsYearEndProcessed { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public int? PrevStoreId { get; set; }
        public int? YearEndBy { get; set; }
        [MaxLength(6)]
        public DateTime? YearEndOn { get; set; }

        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Stores))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(YearEndBy))]
        [InverseProperty(nameof(User.Stores))]
        public virtual User YearEndByNavigation { get; set; }
        [InverseProperty(nameof(Itemstoremapping.Store))]
        public virtual ICollection<Itemstoremapping> Itemstoremappings { get; set; }
        [InverseProperty(nameof(Materialissue.FromStore))]
        public virtual ICollection<Materialissue> Materialissues { get; set; }
        [InverseProperty(nameof(Materialreceipt.Store))]
        public virtual ICollection<Materialreceipt> Materialreceipts { get; set; }
        [InverseProperty(nameof(Materialrequisition.ToStore))]
        public virtual ICollection<Materialrequisition> Materialrequisitions { get; set; }
        [InverseProperty(nameof(Materialreturn.ToStore))]
        public virtual ICollection<Materialreturn> Materialreturns { get; set; }
        [InverseProperty(nameof(Openingstock.Store))]
        public virtual ICollection<Openingstock> Openingstocks { get; set; }
        [InverseProperty(nameof(Physicalstock.Store))]
        public virtual ICollection<Physicalstock> Physicalstocks { get; set; }
        [InverseProperty(nameof(Purchaseindent.Stores))]
        public virtual ICollection<Purchaseindent> Purchaseindents { get; set; }
        [InverseProperty(nameof(Purchaseinquiry.Store))]
        public virtual ICollection<Purchaseinquiry> Purchaseinquiries { get; set; }
        [InverseProperty(nameof(Purchaseinvoice.Store))]
        public virtual ICollection<Purchaseinvoice> Purchaseinvoices { get; set; }
        [InverseProperty(nameof(Purchaseorder.Store))]
        public virtual ICollection<Purchaseorder> Purchaseorders { get; set; }
        [InverseProperty(nameof(Purchasequotation.Store))]
        public virtual ICollection<Purchasequotation> Purchasequotations { get; set; }
        [InverseProperty(nameof(Purchasereturn.Store))]
        public virtual ICollection<Purchasereturn> Purchasereturns { get; set; }
        [InverseProperty(nameof(Stockdetail.Store))]
        public virtual ICollection<Stockdetail> Stockdetails { get; set; }
        [InverseProperty(nameof(Stockreceive.FromStore))]
        public virtual ICollection<Stockreceive> StockreceiveFromStores { get; set; }
        [InverseProperty(nameof(Stockreceive.ToStore))]
        public virtual ICollection<Stockreceive> StockreceiveToStores { get; set; }
        [InverseProperty(nameof(Stocktransfer.FromStore))]
        public virtual ICollection<Stocktransfer> StocktransferFromStores { get; set; }
        [InverseProperty(nameof(Stocktransfer.ToStore))]
        public virtual ICollection<Stocktransfer> StocktransferToStores { get; set; }
        [InverseProperty(nameof(Stocktransferrequest.FromStore))]
        public virtual ICollection<Stocktransferrequest> StocktransferrequestFromStores { get; set; }
        [InverseProperty(nameof(Stocktransferrequest.ToStore))]
        public virtual ICollection<Stocktransferrequest> StocktransferrequestToStores { get; set; }
        [InverseProperty(nameof(Storestoremapping.StoreId1Navigation))]
        public virtual ICollection<Storestoremapping> StorestoremappingStoreId1Navigations { get; set; }
        [InverseProperty(nameof(Storestoremapping.StoreId2Navigation))]
        public virtual ICollection<Storestoremapping> StorestoremappingStoreId2Navigations { get; set; }
        [InverseProperty(nameof(Subdepartmentstoresmapping.Stores))]
        public virtual ICollection<Subdepartmentstoresmapping> Subdepartmentstoresmappings { get; set; }
        [InverseProperty(nameof(Userstoremapping.Store))]
        public virtual ICollection<Userstoremapping> Userstoremappings { get; set; }
    }
}
