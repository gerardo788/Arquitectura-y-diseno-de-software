# Arquitectura-y-diseno-de-software
Actividades de patrones para calificacion final

## Los patrones de diseño son herramientas para resolver los mismos problemas, como el lema lo dice "no reinventes la rueda"

### Singleton

Explicacion: Patron de diseño creacional que permite asegurarnos de que una clase tenga unicamente una instancia, a la vez que proporciona un punto de acceso global a dicha instancia. Garantiza que clase tenga una única instancia
Ejemplo: tenemos una aplicacion que realiza consultas a una base de datos, pero al momento de inicialiar la aplicacion queremos que unicamente una vez realice la conexion a la base de datos, por lo tanto utilizamos el patron singleton para que a pesar de que se realicen varias consultas a la base, la conexion y la configuracion con la base solamente se realice una vez.

### Abstract Factory

Explicacion: Patron de diseño creacional que permite producir conjuntos de objetos relacionados sin que se les especifique alguna clase concreta.
Para este patron se deben declarar interfaces para cada producto por ejemplo: inmuebleHabitacional, inmuebleIndustrial; y para cada una de las variantes de los productos deben seguir esas interfaces, despues para la Abstract Factory la cual sera una interfaz con una lista de metodos de creacion para todos los productos que son parte del conjunto de objetos relacionados ejemplo: crearUsoDeSuelo() donde habitacional obtendra un TipoA e industrial tendra un TipoC

### Builder

Explicacion: Patron de diseño creacional para crear objetos complejos(con muchos parametros) y de esta forma evitar las subclases. Este patron sugiere que se coloquen el codigo de construccion en objetos independientes llamados constructores
Ejemplo: Tenemos un objeto tipo clase, donde tiene muchas propiedades como paredes, puertas, ventamas, jardin, alberca, etc; y para evitar hacer llamadas al constructor tan largas en las que se tienen que poner todos los parametros y muchas veces son nulos como el caso de alberca, evitar esto y poder unicamente hacer las llamadas a las caracteristicas necesarias y asi poder construir objetos (casas) distintas.

### Prototype

Explicacion: Patron de diseño creacional que permite copiar obetos existentes sin las dependencias de clases. Cuando tienes un objeto y quieres una replica igual, entonces para evitar el problema de copiar cuando tienes objetos privados que son invisibles desde afuera, podemos usar este patron de diseño. Y a parte debes conocer la clase del objeto para poder crear un duplicado y por ende el codigo se vuelve dependeinte de esa clase. Este patron declara una interfaz para todos aquellos obejetos que soportan la clonación, casi siempre lo unico que la interfaz contiene es un metodo clonar.
Ejemplo: Tienes un videojuego y tienes un objeto aldeano, con muchas caracteristicas, mientras avanzas en el juego resulta que se expande el mapa y es necesario hacer la clonacion de muchos aldeanos, para esto podemos utilizar el patron de diseño conar y facilitarnos la clonacion masiva que se va a realizar.


### Adapter

Explicacion: Patron de diseño estructural que permite la colaboracion entre objetos con interfaces incompatibles.
Ejemplo: tenemos una base de datos principal que se encuentra en XML y esta ya cuenta con una aplicacion en web que funciona a la perfeccion ya que se desarrollo especificamente para su funcionamiento, pero ahora queremos que tambien exista aplicacion movil y para esto se utilizara JSON, por lo tanto debemos crear un adaptador que "convierta" los datos de XML a JSON
