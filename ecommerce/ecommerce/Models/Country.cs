namespace ecommerce.Models
{
    public class Country
    {
        public int Id { get; set; } 


        public string? Country_Name { get; set; }

        public virtual List<Address>? Addresses { get; set; }
    }
}
