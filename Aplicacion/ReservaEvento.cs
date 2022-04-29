namespace AppEventos.Aplicacion
{
    public class ReservaEvento:Reserva
    {
        public string Hora;
        public Evento Eventos;

        public ReservaEvento(Usuario usuarios):base(usuarios)
        {

        }
    }
}