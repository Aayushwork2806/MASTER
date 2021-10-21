using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_combined_teacher_class_master")]
    [Index(nameof(UnitId), Name = "FK_tbl_combined_teacher_class_master_BusinessUnits")]
    [Index(nameof(SessionId), Name = "FK_tbl_combined_teacher_class_master_Session")]
    public partial class TblCombinedTeacherClassMaster
    {
        public TblCombinedTeacherClassMaster()
        {
            TblCombinedTeacherClassDetails = new HashSet<TblCombinedTeacherClassDetail>();
            TblTimetables = new HashSet<TblTimetable>();
        }

        [Key]
        [Column("combined_master_id")]
        public long CombinedMasterId { get; set; }
        [Column("no_of_periods")]
        public int? NoOfPeriods { get; set; }
        public int? SessionId { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty("TblCombinedTeacherClassMasters")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.TblCombinedTeacherClassMasters))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(TblCombinedTeacherClassDetail.CombinedMaster))]
        public virtual ICollection<TblCombinedTeacherClassDetail> TblCombinedTeacherClassDetails { get; set; }
        [InverseProperty(nameof(TblTimetable.CombinedMaster))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
    }
}
