namespace AppEventos.Aplicacion
{
    public class Actividad
    {
        public string Nombre;
        public string Horario;
        public string Descripcion;
        public string Telefono;
        public Boolean Abierto;
        public Reserva[] Reservas;
        private Ubicacion Ubicaciones;
        private Categoria Categorias;

        public Actividad(Categoria categorias,Ubicacion ubicaciones)
        {
            Categorias = categorias;
            Ubicaciones = ubicaciones;
        }

        public override string ToString()
        {
            return String.Concat(Nombre,',',Telefono,',',Descripcion,',',Horario,',',Abierto,',',Ubicaciones.Direccion,',',Ubicaciones.Lugar,',',Ubicaciones.Estado,',',Categorias.Logo,',',Categorias.Nombre);
        }
    }
}

