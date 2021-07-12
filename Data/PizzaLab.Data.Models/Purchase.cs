using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class Purchase
    {
        public Purchase()
        {

        }

        [Key]
        public int Id { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }

        public int Quantity { get; set; }

        public virtual PizzaSize PizzaSize { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
