using System.ComponentModel.DataAnnotations;

namespace Human_Body.Model
{
    public class HumanBody
    {
        [Key]
        [Required]

        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
