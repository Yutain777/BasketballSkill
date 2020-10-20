namespace FIT5032Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skill
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Detail { get; set; }

        public string Link { get; set; }

        [Column(TypeName = "date")]
        public DateTime UpdateTime { get; set; }
    }
}
