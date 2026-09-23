using System.ComponentModel.DataAnnotations;

namespace SintakseSite.Models;

public class ContactRequest
{
    [Required(ErrorMessage = "Ievadi savu vārdu.")]
    [StringLength(100, ErrorMessage = "Vārds nedrīkst pārsniegt 100 rakstzīmes.")]
    [RegularExpression(@"^[^\r\n]+$", ErrorMessage = "Ievadi vārdu vienā rindā.")]
    [Display(Name = "Vārds / kontaktpersona")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Ievadi e-pasta adresi.")]
    [EmailAddress(ErrorMessage = "Pārbaudi e-pasta adresi.")]
    [StringLength(254)]
    [Display(Name = "Tavs e-pasts")]
    public string Email { get; set; } = "";

    [DataType(DataType.Date)]
    [Display(Name = "Pasākuma datums (ja zināms)")]
    public DateTime? EventDate { get; set; }

    [StringLength(200, ErrorMessage = "Vieta nedrīkst pārsniegt 200 rakstzīmes.")]
    [Display(Name = "Norises vieta (ja zināma)")]
    public string? Location { get; set; }

    [Required(ErrorMessage = "Pastāsti par savu ieceri.")]
    [StringLength(5000, MinimumLength = 10, ErrorMessage = "Ziņai jābūt no 10 līdz 5000 rakstzīmēm.")]
    [Display(Name = "Pasākuma iecere / ziņa")]
    public string Message { get; set; } = "";

    [StringLength(200)]
    public string? Website { get; set; }
}
