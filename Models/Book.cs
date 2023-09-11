using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Book
    { 
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Liczba stron")]
        public int Pages { get; set; }

        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Rok Wydania")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Ocena czytelników")]
        public int Rating { get; set; }
        [Display(Name = "Nakład")]
        public int Circulation { get; set; }
    }
}
