using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(CategoriasMetadato))]
    public partial class Categorias
    {
    }

    public class CategoriasMetadato
    {
        [Required]
        [StringLength(50)]
        public string NombreCategoria { get; set; }
    }

}
