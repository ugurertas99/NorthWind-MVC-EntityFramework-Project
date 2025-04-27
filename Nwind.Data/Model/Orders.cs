using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwind.Data.Model
{
    public class Orders
    {
        [Key]
        
        public int OrderID { get; set; }

        [Required]
        
        public DateTime OrderDate { get; set; }

        
        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public int ShipVia { get; set; }

        public  Customers Customer  { get; set; }

    }
}
