using AppEventos.Aplicacion;

namespace ControlArchivos.Datos
{
    public class UsuarioArchivo
    {

        public Usuario [] Usuarios;

        public void GenerarTXT()
        {
            string rutaCompleta = @"Usuario.csv";
            string texto = string.Join(",", Usuarios.Select(n => n.ToString()).ToArray());

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))  
            {    
                mylogs.WriteLine(texto);
                mylogs.Close();
            }
        }
    }
}

