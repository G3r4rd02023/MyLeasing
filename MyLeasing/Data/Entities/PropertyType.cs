using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Propiedad")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
