using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(1,20)]
        public byte Stock { get; set; }









    }
}