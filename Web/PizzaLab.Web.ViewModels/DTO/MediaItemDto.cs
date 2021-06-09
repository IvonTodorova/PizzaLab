
using PizzaLab.Data.PizzaLab.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaLab.Web.ViewModels.DTO
{
    public class MediaItemDto
    {
        [Key]
        public int MediaItemId { get; set; }

        public string Name { get; set; }

        public string MediaType { get; set; }

        public byte[] Data { get; set; }

        public int? ProductId { get; set; }

        public Product Product { get; set; }
    }
}
