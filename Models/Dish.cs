using Dapper.Contrib.Extensions;

namespace Assessment8.Models
{
    [Table("Dish")]
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public string TMName { get; set; }
        public string PhoneNumber { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public string Category { get; set; }

    }
}
