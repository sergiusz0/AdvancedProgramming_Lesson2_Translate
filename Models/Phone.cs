using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Phone
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Pojemność pamięci (GB)")]
        public int MemoryCapacity { get; set; }

        [Display(Name = "Liczba rdzeni procesora")]
        public int ProcessorCores { get; set; }

        [Display(Name = "Rozmiar ekranu (cale)")]
        public int ScreenSize { get; set; }
        [Display(Name = "Waga")]
        public decimal Weight { get; set; }
        [Display(Name = "Pojemność baterii (mAh)")]
        public decimal BatteryCapacity { get; set; }
    }
}
