using System.ComponentModel.DataAnnotations;

namespace MyMvcProject.ViewModels
{
    public class PersonCreateViewModel
    {
        [Required] // Name is required
        public string Name { get; set; }

        [Required] // City is required
        public string City { get; set; }
    }
}