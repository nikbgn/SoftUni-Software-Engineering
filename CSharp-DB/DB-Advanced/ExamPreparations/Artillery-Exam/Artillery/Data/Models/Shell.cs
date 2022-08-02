namespace Artillery.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Shell
    {
        public Shell()
        {
            this.Guns = new HashSet<Gun>();
        }

        [Key]
        public int Id { get; set; }

        public double ShellWeight { get; set; }

        [Required]
        [MinLength(ValidationConstants.CaliberMinLength)]
        public string Caliber { get; set; }

        public virtual ICollection<Gun> Guns { get; set; }
    }
}
