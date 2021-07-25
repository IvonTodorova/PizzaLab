namespace PizzaDotNet.Web.ViewModels.DTO
{
    using PizzaDotNet.Web.ViewModels.Cart;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using System.Collections.Generic;

    public class SessionCartProductDto
    {
        private ICollection<Ingrеdient> addedPizzaIngredients;

        public SessionCartProductDto()
        {
            this.addedPizzaIngredients = new HashSet<Ingrеdient>();
        }

        public virtual ICollection<Ingrеdient> AddedPizzaIngredients
        {
            get { return this.addedPizzaIngredients; }
            set { this.addedPizzaIngredients = value; }
        }

        public int Id { get; set; }

        public string SizeName { get; set; }

        public int Quantity { get; set; }
    }
}
