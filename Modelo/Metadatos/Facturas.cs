using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    [MetadataType(typeof(FacturasMetadato))]
    public partial class Facturas
    {
    }

    public class FacturasMetadato
    {
        [Range(0,100.00)]
        public Nullable<decimal> Iva { get; set; }
        public string Observaciones { get; set; }
        [Required]
        [Range(0, 999999999999999999.99)]
        public decimal Total { get; set; }
        [Required]
        public string CedulaCliente { get; set; }
        [Required]
        public string CedulaUsuario { get; set; }
    }

}
