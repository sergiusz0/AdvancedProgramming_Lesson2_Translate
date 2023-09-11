using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Shoe
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Rozmiar")]
        public decimal Size { get; set; }

        [Display(Name = "Cena")]
        public decimal Price { get; set; }
        [Display(Name = "Waga")]
        public decimal Weight { get; set; }
        [Display(Name = "Długość wkładki (cm)")]
        public decimal LiftLength { get; set; }
        [Display(Name = "Rodzaj materiału")]
        public string Material { get; set; }
    }
}
