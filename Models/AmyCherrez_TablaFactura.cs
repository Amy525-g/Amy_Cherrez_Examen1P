namespace Amy_Cherrez_Examen1P.Models
{
    public class AmyCherrez_TablaFactura
    {
        public int AmId { get; set; }
        public string? AmProducto { get; set; }  
        public string? AmDescription_Producto { get; set; }
        public bool AmPagoEfectivo { get; set; }
        public decimal AmPrecio { get; set; }

    }
}
