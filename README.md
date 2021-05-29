# Cotizador

Renzo Banegas

¿C# permite herencia múltiple?

C# no permite la herencia múltiple de clases pero sí permite la herencia de múltiples interfaces.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.

Por ejemplo si tengo varias clases que heredan de una misma y comparten un mismo método, haria la funcionalidad de ese metodo en la clase abstracta Padre. En cambio si usara una interface aunque van a tener el metodo por contrato cada una tiene que implementarlo.

¿Qué implica una relación de Generalización entre dos clases?

Implica que una clase padre o superclase X es una generalizacion de las clases hijas que la heredan.

¿Qué implica una relación de Implementación entre una clase y una interfaz?

Al implementar una interfaz la clase esta obligada a implementar los metodos y atributos de esta a modo de contrato.

¿Qué diferencia hay entre la relación de Composición y la Agregación?

En la composición las clases particulas dependen completamente de la clase compuesta, en la agregación la clase particula de adhiere a la clase compuesta mediante algún método y no forma parte de esta.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual. V
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. F
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. F

