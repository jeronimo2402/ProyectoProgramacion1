namespace AppEventos.Aplicacion
{
    public class Usuario
    {
        public string NombreUsuario;
        public string Apellido;
        public string NumeroCelular;
        public string Email;
        public string Clave;
        public Reserva[] Reservas;
        
        public override string ToString()
        {
            return String.Concat(NombreUsuario,',',Apellido,',',NumeroCelular,',',Email,',',Clave);
        }

    }
}