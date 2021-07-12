namespace PizzaDotNet.Web.ViewModels.DTO
{
    using System.Collections.Generic;

    public class SessionCartDto
    {
        public SessionCartDto()
        {
            this.Products = new List<SessionCartProductDto>();
        }

        public List<SessionCartProductDto> Products { get; set; }
    }
}
