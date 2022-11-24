// creara un proyecto con el nombre de la carpeta =>
    //dotnet new console
// creara un proyecto en una carpeta nueva con ese mismo nombre =>
    //dotnet new console -0 singleton

namespace PatronSingleton
{

    class Program
    {
        static void Main(string[] args){
            Singleton _singleton1 = Singleton.ObtenerInstancia();
            _singleton1.PonerDatos("Gerardo", 01338190);
            _singleton1.AlgunProceso();

            Singleton _singleton2 = Singleton.ObtenerInstancia();
            _singleton2.PonerDatos("Andres", 62345577);
            _singleton2.AlgunProceso();
        }
    }

}