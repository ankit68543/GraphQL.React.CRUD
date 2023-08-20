using System.ComponentModel.DataAnnotations;

namespace GraphQL.React.CRUD.Models
{
    public class Food
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public List<Allergen> Allergens { get; set; }
    }

    public class Allergen
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
