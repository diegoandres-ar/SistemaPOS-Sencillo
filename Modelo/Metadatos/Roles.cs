using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(RolesMetadato))]
    public partial class Roles
    {
    }

    public class RolesMetadato
    {
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }

}
