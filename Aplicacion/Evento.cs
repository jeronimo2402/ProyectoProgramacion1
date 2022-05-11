namespace AppEventos.Aplicacion
{
    public class Evento
    {
        public string Nombre;
        public string Hora;
        public string Patrocinador;
        private Empresa[] Empresas;
        public string Duracion;
        private Ubicacion Ubicaciones;
        public string Descripcion;
        public Reserva[] Reservas; 
        private Categoria Categorias; 
              
        public Evento(Empresa[] empresas, Reserva[] reservas, Ubicacion ubicaciones)
        {
            Empresas = empresas;
            Reservas = reservas;
            Ubicaciones = ubicaciones;
        }
    }
}