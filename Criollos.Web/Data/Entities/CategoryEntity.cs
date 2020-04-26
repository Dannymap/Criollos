using System.ComponentModel.DataAnnotations;

namespace Criollos.Web.Data.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Logo")]
        public string LogoPath { get; set; }
    }
}
