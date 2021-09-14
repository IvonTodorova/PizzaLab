namespace PizzaDotNet.Web.ViewModels.DTO
{
    using PizzaDotNet.Web.ViewModels.Cart;
    using PizzaLab.Data.Models;
    using PizzaLab.Data.PizzaLab.Data.Models;
    using System.Collections.Generic;

    public class SessionCartProductDto
    {
        private List<AddedProductIngredients> addedOptionalIngredients;

        public SessionCartProductDto()
        {
            this.addedOptionalIngredients = new List<AddedProductIngredients>();
        }

        public virtual List<AddedProductIngredients> AddedOptionalIngredients
        {
            get { return this.addedOptionalIngredients; }
            set { this.addedOptionalIngredients = value; }
        }
        public int QuantityForIngredients { get; set; }
        public int Id { get; set; }

        public string SizeName { get; set; }

        public int Quantity { get; set; }
    }
}
