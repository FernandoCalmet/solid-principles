# SOLID Principles with CSharp

## La razón detrás de la mayoría de las aplicaciones fallidas

Los desarrolladores comienzan a crear aplicaciones con diseños buenos y prolijos utilizando su conocimiento y experiencia. Pero con el tiempo, las aplicaciones pueden desarrollar errores. El diseño de la aplicación debe modificarse para cada solicitud de cambio o solicitud de nueva función. Después de un tiempo, es posible que necesitemos hacer un gran esfuerzo, incluso para tareas simples, y es posible que requiera un conocimiento completo de todo el sistema. Pero no podemos culpar a los cambios ni a las solicitudes de nuevas funciones. Son parte del desarrollo de software. No podemos detenerlos ni rechazarlos tampoco. Entonces, ¿quién es el culpable aquí? Evidentemente es el diseño de la aplicación.

Los siguientes son los defectos de diseño que causan daños en el software, principalmente.

1. Poner más énfasis en las clases asignándoles más responsabilidades. (Mucha funcionalidad no relacionada con una clase).

2. Obligar a las clases a depender unas de otras. Si las clases dependen unas de otras (en otras palabras, están estrechamente acopladas), entonces un cambio en una afectará a la otra.

3. Difundir código duplicado en el sistema / aplicación.

Solución

1. Elegir la arquitectura correcta (en otras palabras, MVC, 3 niveles, Layered, MVP, MVVP y así sucesivamente).

2. Seguir los principios de diseño.

3. Elegir patrones de diseño correctos para construir el software en base a sus especificaciones.

Ahora repasaremos primero los Principios de diseño y pronto cubriremos el resto.

## Introducción a los principios SOLID

Los principios SOLID son los principios de diseño que nos permiten gestionar la mayoría de los problemas de diseño de software. Robert C. Martin compiló estos principios en la década de 1990. Estos principios nos brindan formas de pasar de un código estrechamente acoplado y poca encapsulación a los resultados deseados de las necesidades reales de una empresa encapsuladas y poco acopladas. SOLID es un acrónimo de lo siguiente.

- **S**: Principio de responsabilidad única (SRP)
- **O**: Principio abierto cerrado (OSP)
- **L**: Principio de sustitución de Liskov (LSP)
- **I**: Principio de segregación de interfaces (ISP)
- **D**: Principio de inversión de dependencia (DIP)

## 1. Single-responsibility Principle (SRP)

SRP dice "Cada módulo de software debe tener una sola razón para cambiar".

Esto significa que cada clase, o estructura similar, en su código debe tener solo un trabajo por hacer. Todo en esa clase debe estar relacionado con un solo propósito. Nuestra clase no debería ser como una navaja suiza en la que, si es necesario cambiar uno de ellos, es necesario modificar toda la herramienta. No significa que sus clases solo deben contener un método o propiedad. Puede haber muchos miembros siempre que se relacionen con una sola responsabilidad.

El principio de responsabilidad única nos brinda una buena manera de identificar clases en la fase de diseño de una aplicación y te hace pensar en todas las formas en que una clase puede cambiar. Una buena separación de responsabilidades se realiza solo cuando tenemos una idea completa de cómo debería funcionar la aplicación.

## 2. Open-closed Principle (OCP)

El principio abierto / cerrado dice "Un módulo / clase de software está abierto para extensión y cerrado para modificación".

Aquí, "Abierto para extensión" significa que debemos diseñar nuestro módulo / clase de tal manera que la nueva funcionalidad se pueda agregar solo cuando se generen nuevos requisitos. "Cerrado por modificación" significa que ya hemos desarrollado una clase y ha pasado por pruebas unitarias. Entonces no deberíamos alterarlo hasta que encontremos errores. Como dice, una clase debe estar abierta para extensiones, podemos usar la herencia para hacer esto.

## 3. Liskov substitution principle (LSP)

El principio de sustitución de Liskov (LSP) establece que "debería poder utilizar cualquier clase derivada en lugar de una clase principal y hacer que se comporte de la misma manera sin modificaciones". Asegura que una clase derivada no afecte el comportamiento de la clase padre, en otras palabras, que una clase derivada debe ser sustituible por su clase base.

Este principio es solo una extensión del Principio Abierto Cerrado y significa que debemos asegurarnos de que las nuevas clases derivadas extiendan las clases base sin cambiar su comportamiento. Explicaré esto con un ejemplo del mundo real que viola LSP.

Un padre es médico, mientras que su hijo quiere convertirse en jugador de críquet. Entonces, aquí el hijo no puede reemplazar a su padre aunque ambos pertenecen a la misma jerarquía familiar.
  
## 4. Interface segregation principle (ISP)

El Principio de Segregación de Interfaces establece que "los clientes no deben ser obligados a implementar interfaces que no utilizan. En lugar de una interfaz gruesa, se prefieren muchas interfaces pequeñas basadas en grupos de métodos, cada uno de los cuales sirve a un submódulo".

Podemos definirlo de otra manera. Una interfaz debe estar más relacionada con el código que la usa que con el código que la implementa. Entonces, los métodos en la interfaz se definen mediante qué métodos necesita el código del cliente en lugar de qué métodos implementa la clase. Por tanto, los clientes no deberían verse obligados a depender de interfaces que no utilicen.

Al igual que las clases, cada interfaz debe tener un propósito / responsabilidad específicos (consulte SRP). No debería verse obligado a implementar una interfaz cuando su objeto no comparte ese propósito. Cuanto más grande sea la interfaz, es más probable que incluya métodos que no todos los implementadores pueden hacer. Esa es la esencia del principio de segregación de interfaces.
  
## 5. Dependency Inversion principle (DIP)

El principio de inversión de dependencia (DIP) establece que los módulos / clases de alto nivel no deben depender de módulos / clases de bajo nivel. Ambos deberían depender de abstracciones. En segundo lugar, las abstracciones no deberían depender de los detalles. Los detalles deben depender de abstracciones.

Los módulos / clases de alto nivel implementan reglas de negocio o lógica en un sistema (aplicación). Los módulos / clases de bajo nivel se ocupan de operaciones más detalladas; en otras palabras, pueden ocuparse de escribir información en bases de datos o pasar mensajes al sistema operativo o servicios.

Un módulo / clase de alto nivel que depende de módulos / clases de bajo nivel o alguna otra clase y sabe mucho sobre las otras clases con las que interactúa se dice que está estrechamente acoplado. Cuando una clase sabe explícitamente sobre el diseño y la implementación de otra clase, aumenta el riesgo de que los cambios en una clase rompan la otra clase. Por lo tanto, debemos mantener estos módulos / clases de alto y bajo nivel acoplados libremente tanto como podamos. Para hacer eso, debemos hacer que ambos dependan de abstracciones en lugar de conocerse.
  
---
:octocat: [Check more about Java in my repository.](https://github.com/FernandoCalmet/SOLID-principles)

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/T6T41JKMI)
