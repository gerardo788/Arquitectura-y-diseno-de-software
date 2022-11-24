# Arquitectura-y-diseno-de-software
Actividades de patrones para calificacion final

## Los patrones de diseño son herramientas para resolver los mismos problemas, como el lema lo dice "no reinventes la rueda"

### Singleton

Explicacion: Patron de diseño creacional que permite asegurarnos de que una clase tenga unicamente una instancia, a la vez que proporciona un punto de acceso global a dicha instancia. Garantiza que clase tenga una única instancia
Ejemplo: tenemos una aplicacion que realiza consultas a una base de datos, pero al momento de inicialiar la aplicacion queremos que unicamente una vez realice la conexion a la base de datos, por lo tanto utilizamos el patron singleton para que a pesar de que se realicen varias consultas a la base, la conexion y la configuracion con la base solamente se realice una vez.

### Factory Method

Explicacion: Es un patron que proporciona una interfaz para crear objetos en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crean.
Ejemplo: Tenemos una superclase llamada inmueble y las subclases serian departamento y casa, cada una con debe implementar los metodos de inmueble que en este caso uno podria ser areasRecreativas(), para casa podriamos desplegar las áreas recreativas que cuente el conjunto de casas y para departamento las áreas recreaticas con las que cuente el desarrollo.

### Abstract Factory

Explicacion: Patron de diseño creacional que permite producir conjuntos de objetos relacionados sin que se les especifique alguna clase concreta.
Para este patron se deben declarar interfaces para cada producto por ejemplo: inmuebleHabitacional, inmuebleIndustrial; y para cada una de las variantes de los productos deben seguir esas interfaces, despues para la Abstract Factory la cual sera una interfaz con una lista de metodos de creacion para todos los productos que son parte del conjunto de objetos relacionados ejemplo: crearUsoDeSuelo() donde habitacional obtendra un TipoA e industrial tendra un TipoC

### Adapter

Explicacion: Patron de diseño estructural que permite la colaboracion entre objetos con interfaces incompatibles.
Ejemplo: tenemos una base de datos principal que se encuentra en XML y esta ya cuenta con una aplicacion en web que funciona a la perfeccion ya que se desarrollo especificamente para su funcionamiento, pero ahora queremos que tambien exista aplicacion movil y para esto se utilizara JSON, por lo tanto debemos crear un adaptador que "convierta" los datos de XML a JSON
