namespace AppEventos.Aplicacion
{
    public class Evento
    {
        public string Nombre;
        public string Hora;
        public string Patrocinador;
        public Empresa[] Empresas;
        public string Duracion;
        public Ubicacion[] Ubicaciones;
        public string Descripcion;
        public ReservaEvento[] Reservas; 
        public Categoria Categorias; 
       
    }
}