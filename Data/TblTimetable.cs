using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_timetable")]
    [Index(nameof(UnitId), Name = "FK_tbl_timetable_BusinessUnits")]
    [Index(nameof(DayId), Name = "FK_tbl_timetable_Masters")]
    [Index(nameof(DivisionId), Name = "FK_tbl_timetable_Section")]
    [Index(nameof(SessionId), Name = "FK_tbl_timetable_Session")]
    [Index(nameof(SubjectId), Name = "FK_tbl_timetable_Subject")]
    [Index(nameof(TeacherId), Name = "FK_tbl_timetable_Teacher")]
    [Index(nameof(AllotmentId), Name = "FK_tbl_timetable_tbl_allotment")]
    [Index(nameof(CombinedMasterId), Name = "FK_tbl_timetable_tbl_combined_teacher_class_master")]
    [Index(nameof(BifurcationMasterId), Name = "FK_tbl_timetable_tbl_lab_bifurcation_master")]
    [Index(nameof(TimetablemasterId), Name = "FK_tbl_timetable_tbl_timetable_master")]
    public partial class TblTimetable
    {
        [Key]
        [Column("timetable_id")]
        public long TimetableId { get; set; }
        [Column("allotment_id")]
        public long? AllotmentId { get; set; }
        [Column("teacher_id")]
        public int? TeacherId { get; set; }
        [Column("subject_id")]
        public int? SubjectId { get; set; }
        [Column("division_id")]
        public int? DivisionId { get; set; }
        [Column("day_id")]
        public int? DayId { get; set; }
        [Column("combined_master_id")]
        public long? CombinedMasterId { get; set; }
        [Column("bifurcation_master_id")]
        public long? BifurcationMasterId { get; set; }
        [Column("period_no")]
        public int PeriodNo { get; set; }
        [Column("block")]
        public bool? Block { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("description")]
        public string Description { get; set; }
        public int? SessionId { get; set; }
        public int? UnitId { get; set; }
        [Column("timetablemaster_id")]
        public long? TimetablemasterId { get; set; }

        [ForeignKey(nameof(AllotmentId))]
        [InverseProperty(nameof(TblAllotment.TblTimetables))]
        public virtual TblAllotment Allotment { get; set; }
        [ForeignKey(nameof(BifurcationMasterId))]
        [InverseProperty(nameof(TblLabBifurcationMaster.TblTimetables))]
        public virtual TblLabBifurcationMaster BifurcationMaster { get; set; }
        [ForeignKey(nameof(CombinedMasterId))]
        [InverseProperty(nameof(TblCombinedTeacherClassMaster.TblTimetables))]
        public virtual TblCombinedTeacherClassMaster CombinedMaster { get; set; }
        [ForeignKey(nameof(DayId))]
        [InverseProperty(nameof(Master.TblTimetables))]
        public virtual Master Day { get; set; }
        [ForeignKey(nameof(DivisionId))]
        [InverseProperty(nameof(Section.TblTimetables))]
        public virtual Section Division { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("TblTimetables")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("TblTimetables")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(TimetablemasterId))]
        [InverseProperty(nameof(TblTimetableMaster.TblTimetables))]
        public virtual TblTimetableMaster Timetablemaster { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.TblTimetables))]
        public virtual Businessunit Unit { get; set; }
    }
}
