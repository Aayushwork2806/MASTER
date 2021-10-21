using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("scholardtl")]
    [Index(nameof(PickupBusStopId), Name = "FK_ScholarDtl_BusStop")]
    [Index(nameof(DropBusStopId), Name = "FK_ScholarDtl_BusStop1")]
    [Index(nameof(ClassId), Name = "FK_ScholarDtl_Class")]
    [Index(nameof(CampusId), Name = "FK_ScholarDtl_Masters")]
    [Index(nameof(PickupRouteId), Name = "FK_ScholarDtl_Masters1")]
    [Index(nameof(DropRouteId), Name = "FK_ScholarDtl_Masters2")]
    [Index(nameof(PickupShiftId), Name = "FK_ScholarDtl_Masters3")]
    [Index(nameof(DropShiftId), Name = "FK_ScholarDtl_Masters4")]
    [Index(nameof(FeeGroupId), Name = "FK_ScholarDtl_Masters5")]
    [Index(nameof(SubjectGroupId), Name = "FK_ScholarDtl_Masters6")]
    [Index(nameof(HouseId), Name = "FK_ScholarDtl_Masters7")]
    [Index(nameof(ShiftId), Name = "FK_ScholarDtl_Masters8")]
    [Index(nameof(ScholarId), Name = "FK_ScholarDtl_Scholar")]
    [Index(nameof(SectionId), Name = "FK_ScholarDtl_Section")]
    [Index(nameof(SemesterId), Name = "FK_ScholarDtl_Semester")]
    [Index(nameof(SessionId), Name = "FK_ScholarDtl_Session")]
    [Index(nameof(FeePaidMonthId), Name = "FK_ScholarDtl_SessionDtl")]
    public partial class Scholardtl
    {
        [Key]
        public int Id { get; set; }
        public int ScholarId { get; set; }
        public int SessionId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        [Required]
        [StringLength(12)]
        public string Status { get; set; }
        public int FeeGroupId { get; set; }
        public int? FeePaidMonthId { get; set; }
        public bool? FeeApplicable { get; set; }
        [StringLength(50)]
        public string FeeApplicableReason { get; set; }
        public int? ClassRollNo { get; set; }
        public int? ExamRollNo { get; set; }
        public int? ShiftId { get; set; }
        public int? CampusId { get; set; }
        public int? SubjectGroupId { get; set; }
        [StringLength(25)]
        public string BrSisName1 { get; set; }
        [StringLength(25)]
        public string BrSisName2 { get; set; }
        [StringLength(25)]
        public string BrSisName3 { get; set; }
        [StringLength(25)]
        public string BrSisSchool1 { get; set; }
        [StringLength(25)]
        public string BrSisSchool2 { get; set; }
        [StringLength(25)]
        public string BrSisSchool3 { get; set; }
        [StringLength(20)]
        public string BrSisClass1 { get; set; }
        [StringLength(20)]
        public string BrSisClass2 { get; set; }
        [StringLength(20)]
        public string BrSisClass3 { get; set; }
        public short? BrSisAge1 { get; set; }
        public short? BrSisAge2 { get; set; }
        public short? BrSisAge3 { get; set; }
        [Column("ICardNo")]
        public int? IcardNo { get; set; }
        public int? HouseId { get; set; }
        [StringLength(50)]
        public string Vaccine { get; set; }
        [StringLength(50)]
        public string SickNess { get; set; }
        [StringLength(50)]
        public string Hobby { get; set; }
        [StringLength(100)]
        public string OtherInfo { get; set; }
        [StringLength(25)]
        public string Doctor { get; set; }
        [StringLength(25)]
        public string DoctPhone { get; set; }
        [StringLength(25)]
        public string DoctMobile { get; set; }
        [StringLength(50)]
        public string Coaching { get; set; }
        public int? PickupRouteId { get; set; }
        public int? PickupBusStopId { get; set; }
        public int? PickupShiftId { get; set; }
        [StringLength(5)]
        public string PickupTime { get; set; }
        public int? DropRouteId { get; set; }
        public int? DropBusStopId { get; set; }
        public int? DropShiftId { get; set; }
        [StringLength(5)]
        public string DropTime { get; set; }
        public double? DiscountPercent { get; set; }
        [StringLength(50)]
        public string DiscountReason { get; set; }
        public int? SemesterId { get; set; }
        [Column("UId")]
        [StringLength(50)]
        public string Uid { get; set; }

        [ForeignKey(nameof(CampusId))]
        [InverseProperty(nameof(Master.ScholardtlCampuses))]
        public virtual Master Campus { get; set; }
        [ForeignKey(nameof(ClassId))]
        [InverseProperty("Scholardtls")]
        public virtual Class Class { get; set; }
        [ForeignKey(nameof(DropBusStopId))]
        [InverseProperty(nameof(Busstop.ScholardtlDropBusStops))]
        public virtual Busstop DropBusStop { get; set; }
        [ForeignKey(nameof(DropRouteId))]
        [InverseProperty(nameof(Master.ScholardtlDropRoutes))]
        public virtual Master DropRoute { get; set; }
        [ForeignKey(nameof(DropShiftId))]
        [InverseProperty(nameof(Master.ScholardtlDropShifts))]
        public virtual Master DropShift { get; set; }
        [ForeignKey(nameof(FeeGroupId))]
        [InverseProperty(nameof(Master.ScholardtlFeeGroups))]
        public virtual Master FeeGroup { get; set; }
        [ForeignKey(nameof(FeePaidMonthId))]
        [InverseProperty(nameof(Sessiondtl.Scholardtls))]
        public virtual Sessiondtl FeePaidMonth { get; set; }
        [ForeignKey(nameof(HouseId))]
        [InverseProperty(nameof(Master.ScholardtlHouses))]
        public virtual Master House { get; set; }
        [ForeignKey(nameof(PickupBusStopId))]
        [InverseProperty(nameof(Busstop.ScholardtlPickupBusStops))]
        public virtual Busstop PickupBusStop { get; set; }
        [ForeignKey(nameof(PickupRouteId))]
        [InverseProperty(nameof(Master.ScholardtlPickupRoutes))]
        public virtual Master PickupRoute { get; set; }
        [ForeignKey(nameof(PickupShiftId))]
        [InverseProperty(nameof(Master.ScholardtlPickupShifts))]
        public virtual Master PickupShift { get; set; }
        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Scholardtls")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SectionId))]
        [InverseProperty("Scholardtls")]
        public virtual Section Section { get; set; }
        [ForeignKey(nameof(SemesterId))]
        [InverseProperty("Scholardtls")]
        public virtual Semester Semester { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Scholardtls")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(ShiftId))]
        [InverseProperty(nameof(Master.ScholardtlShifts))]
        public virtual Master Shift { get; set; }
        [ForeignKey(nameof(SubjectGroupId))]
        [InverseProperty(nameof(Master.ScholardtlSubjectGroups))]
        public virtual Master SubjectGroup { get; set; }
    }
}
