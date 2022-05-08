using AppEventos.Aplicacion;

namespace ControlArchivos.Datos
{
    public class ActividadArchivo
    {
        public Actividad[] Actividades;

        public void GenerarTXT()
        {
            string rutaCompleta = @"Actividad.csv";
            string texto = string.Join(",", Actividades.Select(n => n.ToString()).ToArray());

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))  
            {    
                mylogs.WriteLine(texto);
                mylogs.Close();
            }
        }
    }
}