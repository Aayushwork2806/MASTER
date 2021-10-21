using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("busstopwisefee")]
    [Index(nameof(BusStopId), Name = "FK_BusStopWiseFee_BusStop")]
    [Index(nameof(SessionId), Name = "FK_BusStopWiseFee_Session")]
    public partial class Busstopwisefee
    {
        public Busstopwisefee()
        {
            Busstopwisefeedtls = new HashSet<Busstopwisefeedtl>();
        }

        [Key]
        public int Id { get; set; }
        public int BusStopId { get; set; }
        public int SessionId { get; set; }
        public double BusFees { get; set; }

        [ForeignKey(nameof(BusStopId))]
        [InverseProperty(nameof(Busstop.Busstopwisefees))]
        public virtual Busstop BusStop { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Busstopwisefees")]
        public virtual Session Session { get; set; }
        [InverseProperty(nameof(Busstopwisefeedtl.BusStopFee))]
        public virtual ICollection<Busstopwisefeedtl> Busstopwisefeedtls { get; set; }
    }
}
