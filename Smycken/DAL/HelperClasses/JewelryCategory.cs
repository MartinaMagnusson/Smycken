using System.ComponentModel.DataAnnotations;

namespace DAL.HelperClasses
{
    public enum JewelryCategory
    {
        [Display(Name = "Ankelsmycke")]
        AncleJewelry,
        [Display(Name = "Armband")]
        Bracelet,
        [Display(Name = "Örhängen")]
        Earrings,
        [Display(Name = "Halsband")]
        Necklace,
    }  
}   