using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace Amy_Cherrez_Examen1P.Models
{
    public class AmyCherrez_TablaFactura
    {
        public int ID { get; set; }
        [Required]
        public string? AmProducto { get; set; }
        [Required]
        public string? AmDescription_Producto { get; set; }
        public bool AmPagoEfectivo { get; set; }
        [Range(0.50, 99.99)]
        public decimal AmPrecio { get; set; }
    }

}
