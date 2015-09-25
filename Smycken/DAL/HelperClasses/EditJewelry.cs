using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HelperClasses
{
    public class EditJewelry
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Du måste ange ett pris.")]
        [Display(Name = "Pris")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Använd bara siffror")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Du måste ange ett produktnamn.")]
        [Display(Name = "Produktnamn")]
        [RegularExpression(@"[a-zA-ZåäöÅÄÖ]*", ErrorMessage = "Använd bara bokstäver")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Du måste ange en produktbeskrivning.")]
        [Display(Name = "Produktbeskrivning")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Du måste ange ett antal.")]
        [Display(Name = "Antal")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Använd bara siffror")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Du måste välja en kategori.")]
        [Display(Name = "Kategori")]
        public JewelryCategory Category { get; set; }

        //public ImageHelper Image { get; set; }
    }
}
