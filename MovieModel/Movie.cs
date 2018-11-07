namespace MovieModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        [Display(Name = "Year Released")]
        public int? Year { get; set; }

        [Display(Name = "Rating")]
        public int? RatingId { get; set; }

        [Display(Name = "Rating")]
        public virtual Rating Rating { get; set; }
    }
}
