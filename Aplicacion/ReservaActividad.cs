namespace AppEventos.Aplicacion
{
    public class ReservaActividad:Reserva
    {
        public string Horario;
        public Actividad Actividades;

        public ReservaActividad(Usuario usuarios):base(usuarios)
        {

        }
    }
}