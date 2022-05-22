namespace AppEventos.Aplicacion
{
    public class Categoria
    {
        public string Nombre;
        public string Logo;
        public string Color;

        public override string ToString()
        {
            return String.Concat(Nombre,',',Logo,',',Color);
        }
        
    }
}