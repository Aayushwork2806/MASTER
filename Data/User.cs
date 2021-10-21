using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("users")]
    [Index(nameof(DefaultBusinessUnitId), Name = "FK_Users_BusinessUnits")]
    [Index(nameof(DefaultFinYearId), Name = "FK_Users_FinancialYear")]
    [Index(nameof(QuestionId), Name = "FK_Users_Masters")]
    [Index(nameof(DefaultRoleId), Name = "FK_Users_Role")]
    [Index(nameof(DefaultSessionId), Name = "FK_Users_Session")]
    public partial class User
    {
        public User()
        {
            BonussetupCreateByUsers = new HashSet<Bonussetup>();
            BonussetupLastUpdatedByUsers = new HashSet<Bonussetup>();
            Classworks = new HashSet<Classwork>();
            Culturalactivities = new HashSet<Culturalactivity>();
            Departmentconsumptions = new HashSet<Departmentconsumption>();
            Feereceipts = new HashSet<Feereceipt>();
            Homeworks = new HashSet<Homework>();
            Institutes = new HashSet<Institute>();
            Marketingdataallocations = new HashSet<Marketingdataallocation>();
            Materialreceipts = new HashSet<Materialreceipt>();
            Materialrequisitions = new HashSet<Materialrequisition>();
            Materialreturns = new HashSet<Materialreturn>();
            Notices = new HashSet<Notice>();
            Openingstocks = new HashSet<Openingstock>();
            Parentcommunications = new HashSet<Parentcommunication>();
            Physicalstocks = new HashSet<Physicalstock>();
            PurchaseindentAddedByNavigations = new HashSet<Purchaseindent>();
            PurchaseindentApprovedByNavigations = new HashSet<Purchaseindent>();
            Purchaseinquiries = new HashSet<Purchaseinquiry>();
            Purchaseinvoices = new HashSet<Purchaseinvoice>();
            Purchaseorders = new HashSet<Purchaseorder>();
            Purchasequotations = new HashSet<Purchasequotation>();
            Purchasereturns = new HashSet<Purchasereturn>();
            Stockdetails = new HashSet<Stockdetail>();
            Stockreceives = new HashSet<Stockreceive>();
            Stocktransferrequests = new HashSet<Stocktransferrequest>();
            Stocktransfers = new HashSet<Stocktransfer>();
            Stores = new HashSet<Store>();
            Taskquerydtls = new HashSet<Taskquerydtl>();
            TaskschedulerAssignedBies = new HashSet<Taskscheduler>();
            TaskschedulerAssignedTos = new HashSet<Taskscheduler>();
            Tblfavoritemenus = new HashSet<Tblfavoritemenu>();
            TblmasteritemAddedByNavigations = new HashSet<Tblmasteritem>();
            TblmasteritemLastUpByNavigations = new HashSet<Tblmasteritem>();
            Tblmasteritembatchwises = new HashSet<Tblmasteritembatchwise>();
            TblmaterialreceiptLastUpdatedByNavigations = new HashSet<Tblmaterialreceipt>();
            TblmaterialreceiptLngCreatedByNavigations = new HashSet<Tblmaterialreceipt>();
            Tblmaterialreceiptdetails = new HashSet<Tblmaterialreceiptdetail>();
            TblmaterialrequisitionLngApprovedByNavigations = new HashSet<Tblmaterialrequisition>();
            TblmaterialrequisitionLngCreatedByNavigations = new HashSet<Tblmaterialrequisition>();
            Tblmaterialrequisitiondetails = new HashSet<Tblmaterialrequisitiondetail>();
            Tblsetupchangelogs = new HashSet<Tblsetupchangelog>();
            Tbltransactions = new HashSet<Tbltransaction>();
            Tmpfeereceipts = new HashSet<Tmpfeereceipt>();
            Userbusinessunitroles = new HashSet<Userbusinessunitrole>();
            Userdashboards = new HashSet<Userdashboard>();
            Userstoremappings = new HashSet<Userstoremapping>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        [Column("password")]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsLocked { get; set; }
        [MaxLength(6)]
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public int QuestionId { get; set; }
        [Required]
        [StringLength(25)]
        public string Answer { get; set; }
        public int? DefaultBusinessUnitId { get; set; }
        public int? DefaultSessionId { get; set; }
        public int? DefaultRoleId { get; set; }
        [Required]
        [StringLength(1)]
        public string UserType { get; set; }
        [StringLength(5)]
        public string FromTime { get; set; }
        [StringLength(5)]
        public string ToTime { get; set; }
        public int? DefaultFinYearId { get; set; }
        [Column("blnBlockLogin")]
        public bool BlnBlockLogin { get; set; }
        [Column("CheckIP")]
        public bool CheckIp { get; set; }
        [StringLength(25)]
        public string MobileNo { get; set; }
        public byte[] PhotoPath { get; set; }

        [ForeignKey(nameof(DefaultBusinessUnitId))]
        [InverseProperty(nameof(Businessunit.Users))]
        public virtual Businessunit DefaultBusinessUnit { get; set; }
        [ForeignKey(nameof(DefaultFinYearId))]
        [InverseProperty(nameof(Financialyear.Users))]
        public virtual Financialyear DefaultFinYear { get; set; }
        [ForeignKey(nameof(DefaultRoleId))]
        [InverseProperty(nameof(Role.Users))]
        public virtual Role DefaultRole { get; set; }
        [ForeignKey(nameof(DefaultSessionId))]
        [InverseProperty(nameof(Session.Users))]
        public virtual Session DefaultSession { get; set; }
        [ForeignKey(nameof(QuestionId))]
        [InverseProperty(nameof(Master.Users))]
        public virtual Master Question { get; set; }
        [InverseProperty(nameof(Bonussetup.CreateByUser))]
        public virtual ICollection<Bonussetup> BonussetupCreateByUsers { get; set; }
        [InverseProperty(nameof(Bonussetup.LastUpdatedByUser))]
        public virtual ICollection<Bonussetup> BonussetupLastUpdatedByUsers { get; set; }
        [InverseProperty(nameof(Classwork.User))]
        public virtual ICollection<Classwork> Classworks { get; set; }
        [InverseProperty(nameof(Culturalactivity.User))]
        public virtual ICollection<Culturalactivity> Culturalactivities { get; set; }
        [InverseProperty(nameof(Departmentconsumption.AddedByNavigation))]
        public virtual ICollection<Departmentconsumption> Departmentconsumptions { get; set; }
        [InverseProperty(nameof(Feereceipt.User))]
        public virtual ICollection<Feereceipt> Feereceipts { get; set; }
        [InverseProperty(nameof(Homework.User))]
        public virtual ICollection<Homework> Homeworks { get; set; }
        [InverseProperty(nameof(Institute.LngUpdatedByNavigation))]
        public virtual ICollection<Institute> Institutes { get; set; }
        [InverseProperty(nameof(Marketingdataallocation.User))]
        public virtual ICollection<Marketingdataallocation> Marketingdataallocations { get; set; }
        [InverseProperty(nameof(Materialreceipt.AddedByNavigation))]
        public virtual ICollection<Materialreceipt> Materialreceipts { get; set; }
        [InverseProperty(nameof(Materialrequisition.AddedByNavigation))]
        public virtual ICollection<Materialrequisition> Materialrequisitions { get; set; }
        [InverseProperty(nameof(Materialreturn.AddedByNavigation))]
        public virtual ICollection<Materialreturn> Materialreturns { get; set; }
        [InverseProperty(nameof(Notice.User))]
        public virtual ICollection<Notice> Notices { get; set; }
        [InverseProperty(nameof(Openingstock.AddedByNavigation))]
        public virtual ICollection<Openingstock> Openingstocks { get; set; }
        [InverseProperty(nameof(Parentcommunication.User))]
        public virtual ICollection<Parentcommunication> Parentcommunications { get; set; }
        [InverseProperty(nameof(Physicalstock.AddedByNavigation))]
        public virtual ICollection<Physicalstock> Physicalstocks { get; set; }
        [InverseProperty(nameof(Purchaseindent.AddedByNavigation))]
        public virtual ICollection<Purchaseindent> PurchaseindentAddedByNavigations { get; set; }
        [InverseProperty(nameof(Purchaseindent.ApprovedByNavigation))]
        public virtual ICollection<Purchaseindent> PurchaseindentApprovedByNavigations { get; set; }
        [InverseProperty(nameof(Purchaseinquiry.AddedByNavigation))]
        public virtual ICollection<Purchaseinquiry> Purchaseinquiries { get; set; }
        [InverseProperty(nameof(Purchaseinvoice.AddedByNavigation))]
        public virtual ICollection<Purchaseinvoice> Purchaseinvoices { get; set; }
        [InverseProperty(nameof(Purchaseorder.AddedByNavigation))]
        public virtual ICollection<Purchaseorder> Purchaseorders { get; set; }
        [InverseProperty(nameof(Purchasequotation.AddedByNavigation))]
        public virtual ICollection<Purchasequotation> Purchasequotations { get; set; }
        [InverseProperty(nameof(Purchasereturn.AddedByNavigation))]
        public virtual ICollection<Purchasereturn> Purchasereturns { get; set; }
        [InverseProperty(nameof(Stockdetail.AddedByNavigation))]
        public virtual ICollection<Stockdetail> Stockdetails { get; set; }
        [InverseProperty(nameof(Stockreceive.AddedByNavigation))]
        public virtual ICollection<Stockreceive> Stockreceives { get; set; }
        [InverseProperty(nameof(Stocktransferrequest.AddedByNavigation))]
        public virtual ICollection<Stocktransferrequest> Stocktransferrequests { get; set; }
        [InverseProperty(nameof(Stocktransfer.AddedByNavigation))]
        public virtual ICollection<Stocktransfer> Stocktransfers { get; set; }
        [InverseProperty(nameof(Store.YearEndByNavigation))]
        public virtual ICollection<Store> Stores { get; set; }
        [InverseProperty(nameof(Taskquerydtl.User))]
        public virtual ICollection<Taskquerydtl> Taskquerydtls { get; set; }
        [InverseProperty(nameof(Taskscheduler.AssignedBy))]
        public virtual ICollection<Taskscheduler> TaskschedulerAssignedBies { get; set; }
        [InverseProperty(nameof(Taskscheduler.AssignedTo))]
        public virtual ICollection<Taskscheduler> TaskschedulerAssignedTos { get; set; }
        [InverseProperty(nameof(Tblfavoritemenu.LngUser))]
        public virtual ICollection<Tblfavoritemenu> Tblfavoritemenus { get; set; }
        [InverseProperty(nameof(Tblmasteritem.AddedByNavigation))]
        public virtual ICollection<Tblmasteritem> TblmasteritemAddedByNavigations { get; set; }
        [InverseProperty(nameof(Tblmasteritem.LastUpByNavigation))]
        public virtual ICollection<Tblmasteritem> TblmasteritemLastUpByNavigations { get; set; }
        [InverseProperty(nameof(Tblmasteritembatchwise.LngDeletedByNavigation))]
        public virtual ICollection<Tblmasteritembatchwise> Tblmasteritembatchwises { get; set; }
        [InverseProperty(nameof(Tblmaterialreceipt.LastUpdatedByNavigation))]
        public virtual ICollection<Tblmaterialreceipt> TblmaterialreceiptLastUpdatedByNavigations { get; set; }
        [InverseProperty(nameof(Tblmaterialreceipt.LngCreatedByNavigation))]
        public virtual ICollection<Tblmaterialreceipt> TblmaterialreceiptLngCreatedByNavigations { get; set; }
        [InverseProperty(nameof(Tblmaterialreceiptdetail.DeletedbyNavigation))]
        public virtual ICollection<Tblmaterialreceiptdetail> Tblmaterialreceiptdetails { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisition.LngApprovedByNavigation))]
        public virtual ICollection<Tblmaterialrequisition> TblmaterialrequisitionLngApprovedByNavigations { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisition.LngCreatedByNavigation))]
        public virtual ICollection<Tblmaterialrequisition> TblmaterialrequisitionLngCreatedByNavigations { get; set; }
        [InverseProperty(nameof(Tblmaterialrequisitiondetail.DeletedbyNavigation))]
        public virtual ICollection<Tblmaterialrequisitiondetail> Tblmaterialrequisitiondetails { get; set; }
        [InverseProperty(nameof(Tblsetupchangelog.LngUpdatedByNavigation))]
        public virtual ICollection<Tblsetupchangelog> Tblsetupchangelogs { get; set; }
        [InverseProperty(nameof(Tbltransaction.DeletedByNavigation))]
        public virtual ICollection<Tbltransaction> Tbltransactions { get; set; }
        [InverseProperty(nameof(Tmpfeereceipt.User))]
        public virtual ICollection<Tmpfeereceipt> Tmpfeereceipts { get; set; }
        [InverseProperty(nameof(Userbusinessunitrole.User))]
        public virtual ICollection<Userbusinessunitrole> Userbusinessunitroles { get; set; }
        [InverseProperty(nameof(Userdashboard.User))]
        public virtual ICollection<Userdashboard> Userdashboards { get; set; }
        [InverseProperty(nameof(Userstoremapping.User))]
        public virtual ICollection<Userstoremapping> Userstoremappings { get; set; }
    }
}
