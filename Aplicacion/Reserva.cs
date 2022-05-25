namespace AppEventos.Aplicacion
{
    public class Reserva
    {
        private Usuario Usuarios;
        public Evento Eventos;
        public Boolean Cancelado;
        public Pago Pagos;
        public Actividad Actividades;

        public Reserva(Usuario usuarios)
        {
            Usuarios = usuarios;
        }
        public override string ToString()
        {
            return String.Concat(Cancelado);
        }
    }
}