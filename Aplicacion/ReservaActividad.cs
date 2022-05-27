namespace AppEventos.Aplicacion
{
    public class ReservaActividad:Reserva
    {
        public string Horario;

        public ReservaActividad(Usuario usuarios):base(usuarios)
        {

        }
        public override void CualesCual()
        {
            Eventos = null;
            Console.WriteLine("Ahora es reserva de actividad");
        }
    }
}