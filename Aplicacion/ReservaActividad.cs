namespace AppEventos.Aplicacion
{
    public class ReservaActividad:Reserva
    {
        public string Horario;

        public ReservaActividad(Usuario usuarios):base(usuarios)
        {

        }
    }
}