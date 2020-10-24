namespace FIT5032Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string descriprion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public int Cost { get; set; }

        [Required]
        public string Location { get; set; }

        public int state { get; set; }
    }
}
