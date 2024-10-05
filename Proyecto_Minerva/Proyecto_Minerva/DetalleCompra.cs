using CapaEntidad;
using CapaLogica;
namespace Proyecto_Minerva
{
    public partial class DetalleCompra : Form
    {
        public DetalleCompra()
        {
            InitializeComponent();
            ListarPedidos();
        }

        public void ListarPedidos()
        {
            List<entCompra> listaCompra = logCompra.Instancia.ListarCompra();

            if (listaCompra.Count >= 0)
            {
                detallito.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                //BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                //datosEnlazados.DataSource = listaPedido;
                ///tablaPedidos.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                detallito.DataSource = listaCompra; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                                                    //tablaPedidos.Rows[listaPedido.Count - 1].Cells[2].Value = listaPedido[listaPedido.Count - 1].idCliente.idCliente;

                this.detallito.Columns["ID"].Visible = false;
                this.detallito.Columns["Metpagoid"].Visible = false;
                this.detallito.Columns["UsuarioID"].Visible = false;
                this.detallito.Columns["RazonSocial"].Visible = false;
                //configurarColumnasDataGridView();
                //tablaPedidos.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada



            }




        }
    }
}
