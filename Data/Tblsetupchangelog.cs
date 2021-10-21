using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblsetupchangelog")]
    [Index(nameof(LngUpdatedBy), Name = "FK_tblSetupChangeLog_Users")]
    public partial class Tblsetupchangelog
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("datUpdatedDate")]
        [MaxLength(6)]
        public DateTime? DatUpdatedDate { get; set; }
        [Column("lngUpdatedBy")]
        public int? LngUpdatedBy { get; set; }
        [Column("xmlSetting", TypeName = "text")]
        public string XmlSetting { get; set; }

        [ForeignKey(nameof(LngUpdatedBy))]
        [InverseProperty(nameof(User.Tblsetupchangelogs))]
        public virtual User LngUpdatedByNavigation { get; set; }
    }
}
