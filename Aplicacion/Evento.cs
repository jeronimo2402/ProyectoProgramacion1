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
              
        public Evento(Empresa[] empresas, Categoria categorias, Ubicacion ubicaciones)
        {
            Empresas = empresas;
            Categorias = categorias;
            Ubicaciones = ubicaciones;
        }
    }
}