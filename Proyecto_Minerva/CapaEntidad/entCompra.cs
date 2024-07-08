namespace CapaEntidad
{
    public class entCompra
    {
        public int idCompra { get; set; }
        public DateTime fechCompra { get; set; }

        public entProveedor? ID { get; set; }

        public EntMetPago? Metpagoid { get; set; }   

        public Double Monto { get; set; }

    }
}