using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(ProductosMetadato))]
    public partial class Productos
    {
    }

    public class ProductosMetadato
    {
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Range(0, 999999999999999999.99)]
        public decimal PrecioCompra { get; set; }
        [Required]
        [Range(0, 999999999999999999.99)]
        public decimal PrecioVenta { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public long IdCategoria { get; set; }
    }

}
