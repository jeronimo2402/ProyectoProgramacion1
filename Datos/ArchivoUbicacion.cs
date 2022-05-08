using AppEventos.Aplicacion;

namespace ControlArchivos.Datos
{
    public class UbicacionArchivo
    {
        public Ubicacion[] Ubicacion;

        void GenerarTXT()
        {
            string rutaCompleta = @"Ubicacion.csv";
            string texto = string.Join(",", Ubicacion.Select(n => n.ToString()).ToArray());

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))  
            {    
                mylogs.WriteLine(texto);
                mylogs.Close();
            }
        }
    }
}