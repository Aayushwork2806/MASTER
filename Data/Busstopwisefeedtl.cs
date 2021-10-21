using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("busstopwisefeedtl")]
    [Index(nameof(BusStopFeeId), Name = "FK_BusStopWiseFeeDtl_BusStopWiseFee")]
    [Index(nameof(InstId), Name = "FK_BusStopWiseFeeDtl_SessionDtl")]
    public partial class Busstopwisefeedtl
    {
        [Key]
        public int Id { get; set; }
        public int BusStopFeeId { get; set; }
        public int InstId { get; set; }
        public double? Amount { get; set; }

        [ForeignKey(nameof(BusStopFeeId))]
        [InverseProperty(nameof(Busstopwisefee.Busstopwisefeedtls))]
        public virtual Busstopwisefee BusStopFee { get; set; }
        [ForeignKey(nameof(InstId))]
        [InverseProperty(nameof(Sessiondtl.Busstopwisefeedtls))]
        public virtual Sessiondtl Inst { get; set; }
    }
}
