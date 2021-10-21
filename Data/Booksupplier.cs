using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("booksupplier")]
    [Index(nameof(AccountId), Name = "FK_BookSupplier_Accounts")]
    [Index(nameof(FaunitId), Name = "FK_BookSupplier_BusinessUnits")]
    public partial class Booksupplier
    {
        public Booksupplier()
        {
            Booktitles = new HashSet<Booktitle>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string SupplierName { get; set; }
        [StringLength(50)]
        public string ContactPerson { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(25)]
        public string PhoneNo { get; set; }
        [StringLength(25)]
        public string FaxNo { get; set; }
        [Column("email")]
        [StringLength(20)]
        public string Email { get; set; }
        public int? AccountId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Column("FAUnitId")]
        public int? FaunitId { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("Booksuppliers")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(FaunitId))]
        [InverseProperty(nameof(Businessunit.Booksuppliers))]
        public virtual Businessunit Faunit { get; set; }
        [InverseProperty(nameof(Booktitle.Supplier))]
        public virtual ICollection<Booktitle> Booktitles { get; set; }
    }
}
