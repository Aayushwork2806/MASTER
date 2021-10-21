using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("eventcalendar")]
    [Index(nameof(UnitId), Name = "FK_EventCalendar_BusinessUnits")]
    [Index(nameof(SessionId), Name = "FK_EventCalendar_Session")]
    public partial class Eventcalendar
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int UnitId { get; set; }
        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }
        [StringLength(50)]
        public string Event { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Eventcalendars")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Eventcalendars))]
        public virtual Businessunit Unit { get; set; }
    }
}
