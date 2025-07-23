using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employ.api.Model
{
    public class Employee
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string firstname { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        public string lastname { get; set; }

        [Required]
        [MaxLength(50)]
        public int age { get; set; }

        [MaxLength(11, ErrorMessage = "Number cannot be more than 11 numbers.")]
        [MinLength(11, ErrorMessage = "Number cannot be less than 11 numbers.")]
        public string number { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
        public string email { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Address cannot be longer than 100 characters.")]
        public string address { get; set; }
    }
}
