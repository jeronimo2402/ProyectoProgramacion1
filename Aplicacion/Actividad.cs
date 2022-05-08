namespace AppEventos.Aplicacion
{
    public class Actividad
    {
        public string Nombre;
        public string Horario;
        private Ubicacion Ubicaciones;
        public string Descripcion;
        public string Telefono;
        public Boolean Abierto;
        private Categoria Categorias;
        public Reserva[] Reservas;

        public Actividad(Categoria categorias,Ubicacion ubicaciones)
        {
            Categorias = categorias;
            Ubicaciones = ubicaciones;
        }
    }


}

