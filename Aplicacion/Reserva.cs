namespace AppEventos.Aplicacion
{
    public class Reserva
    {
        private Usuario Usuarios;
        public Evento Eventos;
        public Boolean Cancelado;
        public Pago Pagos;

        public Reserva(Usuario usuarios)
        {
            Usuarios = usuarios;
        }
    }
}