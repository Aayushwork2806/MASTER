using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("purchaseindent")]
    [Index(nameof(BusinessUnitId), Name = "FK_PurchaseIndent_BusinessUnits")]
    [Index(nameof(SubDepartmentId), Name = "FK_PurchaseIndent_Masters")]
    [Index(nameof(StoresId), Name = "FK_PurchaseIndent_Stores")]
    [Index(nameof(AddedBy), Name = "FK_PurchaseIndent_Users")]
    [Index(nameof(ApprovedBy), Name = "FK_PurchaseIndent_Users1")]
    public partial class Purchaseindent
    {
        public Purchaseindent()
        {
            Purchaseindentdetails = new HashSet<Purchaseindentdetail>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(6)]
        public DateTime PurchaseIndentDate { get; set; }
        public int SubDepartmentId { get; set; }
        public int StoresId { get; set; }
        public int AddedBy { get; set; }
        public int? ApprovedBy { get; set; }
        public int BusinessUnitId { get; set; }
        public int? IndentNo { get; set; }

        [ForeignKey(nameof(AddedBy))]
        [InverseProperty(nameof(User.PurchaseindentAddedByNavigations))]
        public virtual User AddedByNavigation { get; set; }
        [ForeignKey(nameof(ApprovedBy))]
        [InverseProperty(nameof(User.PurchaseindentApprovedByNavigations))]
        public virtual User ApprovedByNavigation { get; set; }
        [ForeignKey(nameof(BusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Purchaseindents))]
        public virtual Businessunit BusinessUnit { get; set; }
        [ForeignKey(nameof(StoresId))]
        [InverseProperty(nameof(Store.Purchaseindents))]
        public virtual Store Stores { get; set; }
        [ForeignKey(nameof(SubDepartmentId))]
        [InverseProperty(nameof(Master.Purchaseindents))]
        public virtual Master SubDepartment { get; set; }
        [InverseProperty(nameof(Purchaseindentdetail.PurchaseIndent))]
        public virtual ICollection<Purchaseindentdetail> Purchaseindentdetails { get; set; }
    }
}
