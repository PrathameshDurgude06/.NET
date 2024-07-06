namespace EcommerceProduct.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public decimal? UnitPrice { get; set; }

        public string? ImageUrl { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return "ID: " + this.Id +
                "Title : " + this.Title +
                "Description: " + this.Description +
                "Image Url: " + this.ImageUrl +
                "Quantity : " + this.Quantity;

         }
        


    }
}
