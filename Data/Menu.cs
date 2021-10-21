using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("menus")]
    public partial class Menu
    {
        public Menu()
        {
            Businessunitrolesmenus = new HashSet<Businessunitrolesmenu>();
            Tblfavoritemenus = new HashSet<Tblfavoritemenu>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }
        public int? MenuGroupId { get; set; }
        public int ParentId { get; set; }
        [Required]
        [Column("href")]
        [StringLength(50)]
        public string Href { get; set; }
        [Column("hasChildren")]
        public bool HasChildren { get; set; }
        public int? MenuOrder { get; set; }
        [Required]
        public bool? IsShow { get; set; }
        [StringLength(3)]
        public string MenuCode { get; set; }
        [Column("imgMenuIcon")]
        public byte[] ImgMenuIcon { get; set; }

        [InverseProperty(nameof(Businessunitrolesmenu.Menu))]
        public virtual ICollection<Businessunitrolesmenu> Businessunitrolesmenus { get; set; }
        [InverseProperty(nameof(Tblfavoritemenu.LngMenu))]
        public virtual ICollection<Tblfavoritemenu> Tblfavoritemenus { get; set; }
    }
}
