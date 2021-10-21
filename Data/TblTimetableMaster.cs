using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_timetable_master")]
    [Index(nameof(UnitId), Name = "FK_tbl_timetable_master_BusinessUnits")]
    [Index(nameof(SessionId), Name = "FK_tbl_timetable_master_Session")]
    public partial class TblTimetableMaster
    {
        public TblTimetableMaster()
        {
            TblTimetables = new HashSet<TblTimetable>();
        }

        [Key]
        [Column("timetablemaster_id")]
        public long TimetablemasterId { get; set; }
        [MaxLength(6)]
        public DateTime EntryDateTime { get; set; }
        public int? SessionId { get; set; }
        public int? UnitId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty("TblTimetableMasters")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.TblTimetableMasters))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(TblTimetable.Timetablemaster))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
    }
}
