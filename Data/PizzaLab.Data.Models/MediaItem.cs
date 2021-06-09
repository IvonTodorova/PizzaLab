using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Data.PizzaLab.Data.Models
{
    public class MediaItem
    {
        [Key]
        public int MediaItemId { get; set; }

        public string Name { get; set; }

        public string MediaType { get; set; }

        public string Path { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
