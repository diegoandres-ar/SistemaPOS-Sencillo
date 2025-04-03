using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(TiposDocumentoMetadato))]
    public partial class TiposDocumento
    {
    }

    public class TiposDocumentoMetadato
    {
        [Required]
        [StringLength(20)]
        public string NombreTipo { get; set; }
        [Required]
        [StringLength(10)]
        public string Abreviacion { get; set; }
    }

}
