namespace PetShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public List<Pet> Pets { get; set; }
    }

}