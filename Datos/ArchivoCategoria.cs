using AppEventos.Aplicacion;

namespace ControlArchivos.Datos
{
    public class CategoriaArchivo
    {
        public Categoria[] Categoria;

        void GenerarTXT()
        {
            string rutaCompleta = @"Categoria.csv";
            string texto = string.Join(",", Categoria.Select(n => n.ToString()).ToArray());

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))  
            {    
                mylogs.WriteLine(texto);
                mylogs.Close();
            }
        }
    }
}