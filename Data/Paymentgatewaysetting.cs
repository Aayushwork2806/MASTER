using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("paymentgatewaysettings")]
    [Index(nameof(UnitId), Name = "FK_PaymentGateWaySettings_BusinessUnits")]
    public partial class Paymentgatewaysetting
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Currency { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Merchantkey { get; set; }
        [StringLength(50)]
        public string Merchantsalt { get; set; }
        [StringLength(150)]
        public string ReturnUrl { get; set; }
        [StringLength(100)]
        public string VanityUrl { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("addressStreet1")]
        [StringLength(150)]
        public string AddressStreet1 { get; set; }
        [Column("addressStreet2")]
        [StringLength(150)]
        public string AddressStreet2 { get; set; }
        [Column("addressCity")]
        [StringLength(80)]
        public string AddressCity { get; set; }
        [Column("addressState")]
        [StringLength(100)]
        public string AddressState { get; set; }
        [Column("addressCountry")]
        [StringLength(100)]
        public string AddressCountry { get; set; }
        [Column("addressZip")]
        [StringLength(20)]
        public string AddressZip { get; set; }
        [Column("notifyUrl")]
        [StringLength(100)]
        public string NotifyUrl { get; set; }
        [Column("mode")]
        [StringLength(100)]
        public string Mode { get; set; }
        [StringLength(10)]
        public string GateWayName { get; set; }
        public int UnitId { get; set; }
        [Column("secret_key")]
        [StringLength(200)]
        public string SecretKey { get; set; }

        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.Paymentgatewaysettings))]
        public virtual Businessunit Unit { get; set; }
    }
}
