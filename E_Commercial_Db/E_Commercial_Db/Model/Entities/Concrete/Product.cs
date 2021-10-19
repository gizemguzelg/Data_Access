using E_Commercial_Db.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Model.Entities.Concrete
{
   public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }

        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier supplier { get; set; }

    }
}
