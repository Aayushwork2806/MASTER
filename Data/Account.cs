using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("accounts")]
    [Index(nameof(UnitId), Name = "FK_Accounts_BusinessUnits")]
    [Index(nameof(GroupId), Name = "FK_Mst_Accounts_Mst_AcGroup")]
    public partial class Account
    {
        public Account()
        {
            Accountsdtls = new HashSet<Accountsdtl>();
            Booksuppliers = new HashSet<Booksupplier>();
            Despatches = new HashSet<Despatch>();
            Feeheads = new HashSet<Feehead>();
            Feereceipts = new HashSet<Feereceipt>();
            Financialunits = new HashSet<Financialunit>();
            Inwards = new HashSet<Inward>();
            ItemAccounts = new HashSet<Item>();
            ItemPurchaseAccounts = new HashSet<Item>();
            Itemsuppliermappings = new HashSet<Itemsuppliermapping>();
            Materialreceipts = new HashSet<Materialreceipt>();
            Openingbalances = new HashSet<Openingbalance>();
            Purchaseinquiries = new HashSet<Purchaseinquiry>();
            Purchaseinvoices = new HashSet<Purchaseinvoice>();
            Purchaseorders = new HashSet<Purchaseorder>();
            Purchasequotations = new HashSet<Purchasequotation>();
            Purchasereturns = new HashSet<Purchasereturn>();
            Salaryheads = new HashSet<Salaryhead>();
            Tblmaterialreceipts = new HashSet<Tblmaterialreceipt>();
            Voucherdtls = new HashSet<Voucherdtl>();
        }

        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int AccountNo { get; set; }
        [Required]
        [StringLength(40)]
        public string AccName { get; set; }
        public double? OpBalance { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public bool? SubLedger { get; set; }
        [Column(TypeName = "date")]
        public DateTime? IntroductionDate { get; set; }
        [StringLength(25)]
        public string PanNo { get; set; }
        public bool IsActive { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(GroupId))]
        [InverseProperty(nameof(Accountsgroup.Accounts))]
        public virtual Accountsgroup Group { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Accounts))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(Accountsdtl.Accounts))]
        public virtual ICollection<Accountsdtl> Accountsdtls { get; set; }
        [InverseProperty(nameof(Booksupplier.Account))]
        public virtual ICollection<Booksupplier> Booksuppliers { get; set; }
        [InverseProperty(nameof(Despatch.Account))]
        public virtual ICollection<Despatch> Despatches { get; set; }
        [InverseProperty(nameof(Feehead.Account))]
        public virtual ICollection<Feehead> Feeheads { get; set; }
        [InverseProperty(nameof(Feereceipt.Account))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Financialunit.PurchaseDiscountAccount))]
        public virtual ICollection<Financialunit> Financialunits { get; set; }
        [InverseProperty(nameof(Inward.Supplier))]
        public virtual ICollection<Inward> Inwards { get; set; }
        [InverseProperty(nameof(Item.Account))]
        public virtual ICollection<Item> ItemAccounts { get; set; }
        [InverseProperty(nameof(Item.PurchaseAccount))]
        public virtual ICollection<Item> ItemPurchaseAccounts { get; set; }
        [InverseProperty(nameof(Itemsuppliermapping.Supplier))]
        public virtual ICollection<Itemsuppliermapping> Itemsuppliermappings { get; set; }
        [InverseProperty(nameof(Materialreceipt.SupplierAcc))]
        public virtual ICollection<Materialreceipt> Materialreceipts { get; set; }
        [InverseProperty(nameof(Openingbalance.Account))]
        public virtual ICollection<Openingbalance> Openingbalances { get; set; }
        [InverseProperty(nameof(Purchaseinquiry.SupplierAcc))]
        public virtual ICollection<Purchaseinquiry> Purchaseinquiries { get; set; }
        [InverseProperty(nameof(Purchaseinvoice.SupplierAcc))]
        public virtual ICollection<Purchaseinvoice> Purchaseinvoices { get; set; }
        [InverseProperty(nameof(Purchaseorder.SupplierAcc))]
        public virtual ICollection<Purchaseorder> Purchaseorders { get; set; }
        [InverseProperty(nameof(Purchasequotation.SupplierAcc))]
        public virtual ICollection<Purchasequotation> Purchasequotations { get; set; }
        [InverseProperty(nameof(Purchasereturn.SupplierAcc))]
        public virtual ICollection<Purchasereturn> Purchasereturns { get; set; }
        [InverseProperty(nameof(Salaryhead.Account))]
        public virtual ICollection<Salaryhead> Salaryheads { get; set; }
        [InverseProperty(nameof(Tblmaterialreceipt.LngSupplier))]
        public virtual ICollection<Tblmaterialreceipt> Tblmaterialreceipts { get; set; }
        [InverseProperty(nameof(Voucherdtl.Account))]
        public virtual ICollection<Voucherdtl> Voucherdtls { get; set; }
    }
}
