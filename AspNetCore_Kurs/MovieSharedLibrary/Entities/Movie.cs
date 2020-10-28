using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSharedLibrary.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ohne einen Filmtitel, kann man keinen Film zeigen")]
        [MinLength(5, ErrorMessage = "Bitte geben sie 5 Buchstaben ein")]
        [DisplayName("Filmname")]
        public string Title { get; set; }

        [DisplayName("Kinostart")]
        [Required]
        public DateTime Start { get; set; }

        [Range(0, 10)]
        public double IMDB_Bewertung { get; set; }

    }
}
