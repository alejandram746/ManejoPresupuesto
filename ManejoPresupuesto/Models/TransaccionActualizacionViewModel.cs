namespace ManejoPresupuesto.Models
{
    public class TransaccionActualizacionViewModel: TransaccionCreacionViewModel
    {
        public int CuentaAnteriorId { get; set; }
        public decimal MontoAnterior { get; set; }

        public String UrlRetorno { get; set; }
    }

}
