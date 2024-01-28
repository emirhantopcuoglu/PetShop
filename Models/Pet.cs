namespace PetShop.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public String PetName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}