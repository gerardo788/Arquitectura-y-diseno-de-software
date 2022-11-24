// creara un proyecto con el nombre de la carpeta =>
//dotnet new console
// creara un proyecto en una carpeta nueva con ese mismo nombre =>
//dotnet new console -0 singleton

namespace PatronSingleton
{
    internal class Singleton
    {

        private static Singleton instancia;
        private string nombre;
        private int edad;

        private Singleton(){
            nombre = "--";
            edad = 0;
        }

        // no pasa por aqui, mas que una vez que se instancia la clase
        internal static Singleton ObtenerInstancia()
        {
            if (instancia == null){
                instancia = new Singleton();
                Console.WriteLine("conectando a la base de datos");
            }
            else
            {
                Console.WriteLine("Hay un usuario activo, no es necesario volver a conectar");
            }

            return instancia;
        }

        internal void PonerDatos(string _nombre, int _edad)
        {
            nombre = _nombre;
            edad = _edad;
        }

        internal void AlgunProceso()
        {
            Console.WriteLine("Buscando en la base de datos a {0}", nombre);
            Console.WriteLine("{0} esta disponible para asesorias los miercoles", nombre);
        }
    }
}