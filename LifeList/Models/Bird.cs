using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LifeList.Models
{
    public class Bird
    {
        [Key]
        public int BirdId { get; set; }
        [Display(Name = "Common Name")]
        public string CommonName { get; set; }
        [Display(Name = "Scientific Name")]
        public string ScientificName { get; set; }
        [Display(Name = "Species Family")]
        public string SpeciesFamily { get; set; }
        [Display(Name = "Date Seen")]
        [DataType(DataType.Date)]
        public DateTime DateSeen { get; set; }
        [Display(Name = "City")]
        public string CitySeen { get; set; }
        [Display(Name = "State (if applicable)")]

        public string? StateSeen { get; set; }
        [Display(Name = "Province (if applicable)")]
        public string? ProvinceSeen { get; set; }
        [Display(Name = "Continent")]
        public string Continent { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }
    }
}
