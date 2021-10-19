using E_Commercial_Db.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Model.Entities.Concrete
{
    [Table("Categories")]
   public class Category:BaseEntity
    {
        [Required]
        [Column(Order =1)]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}
