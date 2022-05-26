
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

Usuario miUsuario =new Usuario();
miUsuario.Email = "jeronimomn32@gmail.com";
miUsuario.NombreUsuario = "Jeronimo";
miUsuario.Apellido = "Mosquera";
miUsuario.Clave = "****";
miUsuario.NumeroCelular = "3108372071";

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

Empresa[] miEmpresa= new Empresa[1];
miEmpresa[0] =  new Empresa();
miEmpresa[0].Nombre = "Jeronimo";
miEmpresa[0].Telefono = "3119548649";


Evento miEvento = new Evento(miEmpresa, miCategoria, miUbicacion);
miEvento.Nombre = "Soltucorazón";
miEvento.Descripcion = "sdadashdasdasdidsdadashdasdasdidsdadashdasdasdidsdadashda";
miEvento.Duracion = "1:00-3:00";
miEvento.Hora = "1:00";
miEvento.Patrocinador = "Cerebreando";


EventoArchivo datosEvento = new EventoArchivo();
datosEvento.Eventos= new Evento[1];
datosEvento.Eventos[0]=miEvento;
datosReserva.GenerarTXT();


ReservaActividad miReservaActividad = new ReservaActividad(miUsuario);
miReservaActividad.Horario = "L 10am-12pm,M 10am-12pm,M 10am-12pm,J 10am-12pm,V 10am-12pm";

ReservaEvento miReservaEvento = new ReservaEvento(miUsuario);
miReservaEvento.Hora = "10am-2pm";


Console.ReadLine();
Console.WriteLine("Helllo");
Console.ReadLine();