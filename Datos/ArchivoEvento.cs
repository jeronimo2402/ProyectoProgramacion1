using AppEventos.Aplicacion;

namespace ControlArchivos.Datos
{
    public class EventoArchivo
    {

        public Evento [] Eventos;

        public void GenerarTXT()
        {
            string rutaCompleta = @"Evento.csv";
            string texto = string.Join(",", Eventos.Select(n => n.ToString()).ToArray());

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))  
            {    
                mylogs.WriteLine(texto);
                mylogs.Close();
            }
        }
    }
}

