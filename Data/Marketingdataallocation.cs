using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("marketingdataallocation")]
    [Index(nameof(MarketingDataId), Name = "FK_MarketingDataAllocation_MarketingData")]
    [Index(nameof(UserId), Name = "FK_MarketingDataAllocation_Users")]
    public partial class Marketingdataallocation
    {
        [Key]
        public int Id { get; set; }
        public int MarketingDataId { get; set; }
        [Column(TypeName = "date")]
        public DateTime AllocatedDate { get; set; }
        public int? UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ClosedDate { get; set; }
        public bool? Closed { get; set; }

        [ForeignKey(nameof(MarketingDataId))]
        [InverseProperty(nameof(Marketingdatum.Marketingdataallocations))]
        public virtual Marketingdatum MarketingData { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Marketingdataallocations")]
        public virtual User User { get; set; }
    }
}
