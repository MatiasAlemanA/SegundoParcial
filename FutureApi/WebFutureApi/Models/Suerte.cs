using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebFutureApi.Models
{
    public class Suerte
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo es obligatorio")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "La longitud es erronea")]
        public String FutureId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo es obligatorio")]
        [StringLength(100, MinimumLength =1, ErrorMessage = "La longitud es erronea")]
        public string Vision { get; set; }
        [Url]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Campo insuficiente")]
        public string Imagen { get; set; }

    }
}
