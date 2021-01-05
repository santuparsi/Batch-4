using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsonEFUsingCodeFirst.Entities
{
    [Table("Products")]
    public class Product
    {
       [Key]
       [Column("product_id")]
        public int Pid { get; set; }
        [Required(ErrorMessage="Pls Enter Pname")]
        [Column("product_name",TypeName="varchar")]
        [StringLength(20)]
        public string Pname { get; set; }
        public double? Price { get; set; }
        public int? Stock { get; set; }
    }
}
