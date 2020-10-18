using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNX.TEST
{

    [Table(name:"Product")]
    public class Product
    {
        [Required]
        public Int32 ProductID { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [Required]
        [MaxLength(25)]
        public String ProductNumber { get; set; }

        [MaxLength(15)]
        public String Color { get; set; }

        [Required]
        public Decimal StandardCost { get; set; }

        [Required]
        public Decimal ListPrice { get; set; }

        [MaxLength(5)]
        public String Size { get; set; }

        public Decimal? Weight { get; set; }
        public Int32? ProductCategoryID { get; set; }
        public Int32? ProductModelID { get; set; }

        [Required]
        public DateTime? SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public byte[] ThumbNailPhoto { get; set; }

        [MaxLength(50)]
        public String ThumbnailPhotoFileName { get; set; }

        [Required]
        public Guid rowguid { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}