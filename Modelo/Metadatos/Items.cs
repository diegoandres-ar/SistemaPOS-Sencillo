using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(ItemsMetadato))]
    public partial class Items
    {
    }

    public class ItemsMetadato
    {
        [Required]
        public int Cantidad { get; set; }
        [Required]
        [Range(0, 999999999999999999.99)]
        public decimal Subtotal { get; set; }
        [Required]
        public long IdProducto { get; set; }
        [Required]
        public long IdFactura { get; set; }
    }

}
