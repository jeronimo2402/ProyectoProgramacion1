namespace AppEventos.Aplicacion
{
    public class Ubicacion
    {
        public string Lugar;
        public string Direccion;
        public string Estado;
        
        public override string ToString()
        {
            return String.Concat(Lugar,',',Direccion,',',Estado);
        }
    }
}
