namespace Artillery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Manufacturer
    {
        public Manufacturer()
        {
            this.Guns = new HashSet<Gun>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.ManufacturerNameMinLength)]
        public string ManufacturerName { get; set; }

        [Required]
        [MinLength(ValidationConstants.ManufacturerFoundedMinLength)]
        public string Founded { get; set; }

        public virtual ICollection<Gun> Guns { get; set; }
    }
}
