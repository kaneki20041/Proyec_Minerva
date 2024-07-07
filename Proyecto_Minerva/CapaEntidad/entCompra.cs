namespace CapaEntidad
{
    public class entCompra
    {
        public int idDetCompra { get; set; }
        public int idCompra { get; set; }
        public int cantCompra { get; set; }
        public Decimal preciCompra { get; set; }
        public entPrendas PrendaID { get; set; }
    }
}