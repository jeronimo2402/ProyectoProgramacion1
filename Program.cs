
using AppEventos.Aplicacion;
using ControlArchivos.Datos;

Console.WriteLine("Hello, World! Programacion 1");

Ubicacion miUbicacion = new Ubicacion();
miUbicacion.Direccion = "Calle 6 #23 - 99";
miUbicacion.Lugar = "Restaurante";
miUbicacion.Estado  = "Abierto";

Categoria miCategoria = new Categoria();
miCategoria.Nombre = "Entretenimiento";
miCategoria.Logo = "Logo1";
miCategoria.Color = "#AAA001";

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

Usuario miUsuario =new Usuario();
miUsuario.Email = "jeronimomn32@gmail.com";
miUsuario.NombreUsuario = "Jeronimo";
miUsuario.Apellido = "Mosquera";

UsuarioArchivo datosUsuario = new UsuarioArchivo();
datosUsuario.Usuarios = new Usuario[1];
datosUsuario.Usuarios[0]= miUsuario;
datosUsuario.GenerarTXT();

Reserva miReserva = new Reserva(miUsuario);
miReserva.Cancelado = true;

ReservaArchivo datosReserva = new ReservaArchivo();
datosReserva.Reservas=new Reserva[1];
datosReserva.Reservas[0]= miReserva;
datosReserva.GenerarTXT();

Empresa[] miEmpresa = new Empresa[1];
miEmpresa[0].Nombre = "Jeronimo";
miEmpresa[0].Telefono = "3119548649";


Evento miEvento = new Evento(miEmpresa, miCategoria, miUbicacion);
miEvento.Nombre = "Soltucorazón";
miEvento.Descripcion = "sdadashdasdasdidsdadashdasdasdidsdadashdasdasdidsdadashda";
miEvento.Duracion = "1:00 a 3:00 pm";

EventoArchivo datosEvento = new EventoArchivo();
datosEvento.Eventos= new Evento[1];
datosEvento.Eventos[0]=miEvento;
datosReserva.GenerarTXT();





Console.ReadLine();