using AppEventos.Aplicacion;

namespace ControlArchivos.Datos
{
    public class ReservaArchivo
    {
        
        public Reserva [] Reservas;

        public void GenerarTXT()
        {
            string rutaCompleta = @"Reserva.csv";
            string texto = string.Join(",", Reservas.Select(n => n.ToString()).ToArray());

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))  
            {    
                mylogs.WriteLine(texto);
                mylogs.Close();
            }
        }
    }
}
