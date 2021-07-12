namespace PizzaDotNet.Web.ViewModels.DTO
{
    using PizzaDotNet.Web.ViewModels.Cart;

    public class SessionCartProductDto
    {
        public int Id { get; set; }

        public string SizeName { get; set; }

        public int Quantity { get; set; }
    }
}
