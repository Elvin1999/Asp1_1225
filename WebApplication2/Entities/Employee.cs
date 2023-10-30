using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Firstname { get; set; }
        [DisplayName("Surname")]
        [Required(ErrorMessage = "Surname is required")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Point is required")]
        [Range(1,100,ErrorMessage ="Range should be 1-100")]
        public int Point { get; set; }
    }
}
