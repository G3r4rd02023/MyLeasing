using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Data.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Display(Name = "Neighborhood")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Address")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Address { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Square meters")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int SquareMeters { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Rooms { get; set; }

        [Display(Name = "Stratum")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Stratum { get; set; }

        [Display(Name = "Has Parking Lot?")]
        public bool HasParkingLot { get; set; }

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        public string Remarks { get; set; }

        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<PropertyImage> PropertyImages { get; set; }

        public ICollection<Contract> Contracts { get; set; }

    }
}
