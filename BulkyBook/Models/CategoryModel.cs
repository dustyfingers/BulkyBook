using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class CategoryModel
    {

        // this data annotation tells identity framwork that this field is the primary key for this table
        [Key]
        public int Id { get; set; }

        // tell identity framework that Name is required
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        // default to current date time
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
