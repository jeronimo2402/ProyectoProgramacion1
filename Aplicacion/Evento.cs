namespace AppEventos.Aplicacion
{
    public class Evento
    {
        public string Nombre;
        public string Hora;
        public string Patrocinador;
        public string Descripcion;
        public string Duracion;
        private Categoria Categorias; 
        private Ubicacion Ubicaciones;
        public Reserva[] Reservas; 
        private Empresa[] Empresas;
              
        public Evento(Empresa[] empresas, Categoria categorias, Ubicacion ubicaciones)
        {
            Empresas = empresas;
            Categorias = categorias;
            Ubicaciones = ubicaciones;
        }
        public override string ToString()
        {
            return String.Concat(Nombre,',',Hora,',',Patrocinador,',',Descripcion,',',Duracion);
        }
    }
}