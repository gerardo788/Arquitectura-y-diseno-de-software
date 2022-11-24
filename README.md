# Arquitectura-y-diseno-de-software
Actividades de patrones para calificacion final

## Factory Method

Es un patron que proporciona una interfaz para crear objetos en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crean
Ejemplo: Tenemos una superclase llamada inmueble y las subclases serian departamento y casa, cada una con debe implementar los metodos de inmueble que en este caso uno podria ser areasRecreativas(), para casa podriamos desplegar las áreas recreativas que cuente el conjunto de casas y para departamento las áreas recreaticas con las que cuente el desarrollo.

## Abstract Factory

Patron de diseño creacional que permite producir conjuntos de objetos relacionados sin que se les especifique alguna clase concreta.
Para este patron se deben declarar interfaces para cada producto por ejemplo: inmuebleHabitacional, inmuebleIndustrial; y para cada una de las variantes de los productos deben seguir esas interfaces, despues para la Abstract Factory la cual sera una interfaz con una lista de metodos de creacion para todos los productos que son parte del conjunto de objetos relacionados ejemplo: crearUsoDeSuelo() donde habitacional obtendra un TipoA e industrial tendra un TipoC

##
