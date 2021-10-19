using E_Commercial_Db.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Model.Entities.Concrete
{
  public class Supplier:BaseEntity
    {
        public string SupplierName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
