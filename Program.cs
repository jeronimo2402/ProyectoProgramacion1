
using AppEventos.Aplicacion;
using ControlArchivos.Datos;

Console.WriteLine("Hello, World! Programacion 1");

Ubicacion miUbicacion = new Ubicacion();
miUbicacion.Direccion = "Calle 6 #23 - 99";
miUbicacion.Lugar = "Restaurante";
miUbicacion.Estado  = "Abierto";

UbicacionArchivo datosUbicacion = new UbicacionArchivo();
datosUbicacion.Ubicacion = new Ubicacion[1];
datosUbicacion.Ubicacion[0] = miUbicacion;
datosUbicacion.GenerarTXT();

Categoria miCategoria = new Categoria();
miCategoria.Nombre = "Entretenimiento";
miCategoria.Logo = "Logo1";
miCategoria.Color = "#AAA001";

CategoriaArchivo datosCategoria = new CategoriaArchivo();
datosCategoria.Categoria = new Categoria[1];
datosCategoria.Categoria[0] = miCategoria;
datosCategoria.GenerarTXT();

Actividad miActividad = new Actividad(miCategoria,miUbicacion);
miActividad.Nombre = "Actividad1";
miActividad.Descripcion = "Descripcion1";
miActividad.Horario = "2:00 - 4:00";
miActividad.Telefono = "3203115615";
miActividad.Abierto = true;

ActividadArchivo datosActividad = new ActividadArchivo();
datosActividad.Actividades = new Actividad[1];
datosActividad.Actividades[0] = miActividad;
datosActividad.GenerarTXT();

Console.ReadLine();