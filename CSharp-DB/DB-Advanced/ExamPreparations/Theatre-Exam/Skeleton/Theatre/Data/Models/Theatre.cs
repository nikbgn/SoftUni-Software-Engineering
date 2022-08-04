namespace Theatre.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Theatre
    {
        public Theatre()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public sbyte NumberOfHalls { get; set; }

        [Required]
        public string Director { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }

}
