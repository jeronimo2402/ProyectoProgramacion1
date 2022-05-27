namespace AppEventos.Aplicacion
{
    public class ReservaEvento:Reserva
    {
        public string Hora;

        public ReservaEvento(Usuario usuarios):base(usuarios)
        {

        }
        public override void CualesCual()
        {
            Actividades = null;
            Console.WriteLine("Ahora es reserva de evento");
        }
    }
}