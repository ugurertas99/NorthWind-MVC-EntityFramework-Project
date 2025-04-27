using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwind.Data.Model
{
    public class Customers
    {
        [Key]
        [MaxLength(5)]
        public string CustomerID { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }
       
        [MaxLength(30)]
        public string ContactName { get; set; }
       
        [MaxLength(30)]

        public string ContactTitle { get; set; }



        
    }
}
