using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwind.Data.Model
{
    [Table("Products")]  
    
    public class Products
    {
        [Key]

        public int Id { get; set; }
        
        [Required]
        [MaxLength(40)]

        public string ProductName { get; set; }

        [Required]

        public int SupplierID{ get; set; }

        [Required]
        public int  CategoryID { get; set; }






    }
}
