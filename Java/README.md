# SOLID Principles with Java

En el mundo de la programación orientada a objetos (POO), existen muchas pautas, patrones o principios de diseño. Cinco de estos principios suelen estar agrupados y se conocen con el acrónimo SOLID. Si bien cada uno de estos cinco principios describe algo específico, también se superponen de modo que la adopción de uno de ellos implica o conduce a la adopción de otro. En este artículo, comprenderemos los principios de SOLID en Java.

## Historia de los principios SOLID en Java

Robert C. Martin dio cinco principios de diseño orientado a objetos, y se utiliza el acrónimo “SOLID”. Cuando utiliza todos los principios de SOLID de manera combinada, le resulta más fácil desarrollar software que se pueda administrar fácilmente. Las otras características de usar SOLID son:

- Evita los olores de código.
- Código refractor rápido.
- Puede hacer desarrollo de software adaptativo o ágil.
- Cuando usa el principio SOLID en su codificación, comienza a escribir el código que es eficiente y efectivo.

## Cuál es el Significado de SÓLIDO

Solid representa cinco principios de Java que son:

- **S** : principio de responsabilidad única
- **O** : principio abierto-cerrado
- **L** : principio de sustitución de Liskov
- **I** : principio de segregación de interfaz
- **D** : principio de inversión de dependencia

## 1. Single-responsibility Principle (SRP)

Robert C. Martin lo describe como una clase debería tener una sola responsabilidad.

De acuerdo con el principio de responsabilidad única, solo debe haber una razón por la cual deba cambiarse una clase. Significa que una clase debe tener una tarea que hacer. Este principio a menudo se denomina subjetivo.

El principio puede entenderse bien con un ejemplo. Imagina que hay una clase que realiza las siguientes operaciones.

- Conectado a una base de datos
- Leer algunos datos de las tablas de la base de datos
- Finalmente, escríbalo en un archivo.

¿Has imaginado el escenario? Aquí la clase tiene múltiples razones para cambiar, y algunas de ellas son la modificación de la salida del archivo, la adopción de una nueva base de datos. Cuando hablamos de responsabilidad de principio único, diríamos que hay demasiadas razones para que cambie la clase; por tanto, no encaja adecuadamente en el principio de responsabilidad única.

Por ejemplo, una clase de automóvil puede iniciarse o detenerse por sí misma, pero la tarea de lavarla pertenece a la clase CarWash. En otro ejemplo, una clase Book tiene propiedades para almacenar su propio nombre y texto. Pero la tarea de imprimir el libro debe pertenecer a la clase de Impresora de libros. La clase Book Printer puede imprimir en la consola u otro medio, pero estas dependencias se eliminan de la clase Book.

### Por qué se requiere este principio de SRP

Cuando se sigue el principio de responsabilidad única, las pruebas son más fáciles. Con una sola responsabilidad, la clase tendrá menos casos de prueba. Menos funcionalidad también significa menos dependencias con otras clases. Conduce a una mejor organización del código ya que las clases más pequeñas y bien diseñadas son más fáciles de buscar.

Un ejemplo para aclarar este principio:

Suponga que se le pide que implemente un servicio UserSetting en el que el usuario puede cambiar la configuración, pero antes de eso, el usuario debe estar autenticado. Una forma de implementar esto sería:

```java
public class UserSettingService {
    public void changeEmail(User user) {
        if (checkAccess(user)) {
            // Grant option to change
        }
    }

    public boolean checkAccess(User user) {
        // Verify if the user is valid
    }
}
```

Todo se ve bien hasta que desee reutilizar el código checkAccess en algún otro lugar O desee realizar cambios en la forma en que se realiza checkAccess. En los 2 casos, terminaría cambiando la misma clase y, en el primer caso, también tendría que usar UserSettingService para verificar el acceso.

Una forma de corregir esto es descomponer UserSettingService en UserSettingService y SecurityService. Y mueva el código checkAccess a SecurityService.

```java
public class UserSettingService {
    public void changeEmail(User user) {
        if (SecurityService.checkAccess(user)) {
            // Grant option to change
        }
    }
}

public class SecurityService {
    private SecurityService() {
        throw new IllegalStateException("Utility class");
    }

    public static boolean checkAccess(User user) {
        // Verify if the user is valid
        if(user != null){
            // Verify if user exist
        }
        return true;
    }
}
```

## 2. Open-closed Principle (OCP)

Robert C. Martin lo describe como Los componentes de software deben estar abiertos para su extensión, pero cerrados para modificaciones.

Para ser precisos, de acuerdo con este principio, una clase debe escribirse de tal manera que realice su trabajo sin problemas sin la suposición de que la gente en el futuro simplemente vendrá y la cambiará. Por lo tanto, la clase debe permanecer cerrada para modificaciones, pero debe tener la opción de ampliarse. Las formas de extender la clase incluyen:

- Heredando de la clase
- Sobrescribir los comportamientos requeridos de la clase
- Extendiendo ciertos comportamientos de la clase

Un excelente ejemplo del principio abierto-cerrado puede entenderse con la ayuda de los navegadores. ¿Recuerda haber instalado extensiones en su navegador Chrome?

La función básica del navegador Chrome es navegar por diferentes sitios. ¿Desea verificar la gramática cuando escribe un correo electrónico con el navegador Chrome? Si es así, simplemente puede usar la extensión Grammarly, que le proporciona una revisión gramatical del contenido.

Este mecanismo en el que está agregando cosas para aumentar la funcionalidad del navegador es una extensión. Por lo tanto, el navegador es un ejemplo perfecto de funcionalidad que está abierta a la extensión pero cerrada a la modificación. En palabras simples, puede mejorar la funcionalidad agregando / instalando complementos en su navegador, pero no puede crear nada nuevo.

### Por qué se requiere este principio de OCP

OCP es importante ya que las clases pueden llegar a nosotros a través de bibliotecas de terceros. Deberíamos poder extender esas clases sin preocuparnos si esas clases base pueden soportar nuestras extensiones. Pero la herencia puede conducir a subclases que dependen de la implementación de la clase base. Para evitar esto, se recomienda el uso de interfaces. Esta abstracción adicional conduce a un acoplamiento flojo.

Digamos que necesitamos calcular áreas de varias formas. Comenzamos creando una clase para nuestro primer rectángulo de forma  que tiene 2 atributos de largo y ancho.

```java
public class Rectangle {
    public double length;
    public double width;
}
```

A continuación, creamos una clase para calcular el área de este Rectangle  que tiene un método calculateRectangleArea que toma el Rectangle como parámetro de entrada y calcula su área.

```java
public class AreaCalculator {
    public double calculateRectangleArea(Rectangle rectangle) {
        return rectangle.length * rectangle.width;
    }
}
```

Hasta aquí todo bien. Ahora digamos que obtenemos nuestro segundo círculo de forma. Así que creamos rápidamente una nueva clase Circle con un radio de atributo único.

```java
public class Circle {
    public double radius;
}
```

Luego modificamos la  clase Areacalculator para agregar cálculos de círculos a través de un nuevo método calculateCircleaArea ()

```java
public class AreaCalculator {
    public double calculateRectangleArea(Rectangle rectangle) {
        return rectangle.length * rectangle.width;
    }

    public double calculateCircleArea(Circle circle) {
        return (22 / 7) * circle.radius * circle.radius;
    }
}
```

Sin embargo, tenga en cuenta que hubo fallas en la forma en que diseñamos nuestra solución anterior.

Digamos que tenemos un pentágono de nueva forma. En ese caso, volveremos a terminar modificando la clase AreaCalculator. A medida que los tipos de formas crecen, esto se vuelve más complicado ya que AreaCalculator sigue cambiando y cualquier consumidor de esta clase tendrá que seguir actualizando sus bibliotecas que contienen AreaCalculator. Como resultado, la clase AreaCalculator no se establecerá como base (finalizada) con seguridad, ya que cada vez que aparezca una nueva forma, se modificará. Por lo tanto, este diseño no está cerrado para modificaciones.

AreaCalculator deberá seguir agregando su lógica de cálculo en métodos más nuevos. Realmente no estamos ampliando el alcance de las formas; en lugar de eso, simplemente estamos haciendo una solución por partes (poco a poco) para cada forma que se agrega.

Modificación del diseño anterior para cumplir con el principio de abierto / cerrado:

Veamos ahora un diseño más elegante que resuelve las fallas en el diseño anterior al adherirse al principio abierto / cerrado. En primer lugar, haremos que el diseño sea extensible. Para esto, primero debemos definir una forma de tipo base y tener una interfaz de forma de implementación de círculo y rectángulo.

```java
public interface Shape {
    public double calculateArea();
}

public class Rectangle implements Shape {
    double length;
    double width;

    public double calculateArea() {
        return length * width;
    }
}

public class Circle implements Shape {
    public double radius;

    public double calculateArea() {
        return (22 / 7) * radius * radius;
    }
}
```

Hay una forma de interfaz base. Todas las formas implementan ahora la interfaz base Shape. La interfaz Shape tiene un método abstracto calculateArea (). Tanto el círculo como el rectángulo proporcionan su propia implementación anulada del método calculateArea () utilizando sus propios atributos.
Hemos aportado un grado de extensibilidad ya que las formas son ahora una instancia de interfaces de formas. Esto nos permite utilizar Shape en lugar de clases individuales.
El último punto mencionado anteriormente es el consumidor de estas formas. En nuestro caso, el consumidor será la clase AreaCalculator que ahora se vería así.

```java
public class AreaCalculator {
    public double calculateShapeArea(Shape shape) {
        return shape.calculateArea();
    }
}
```

Esta clase AreaCalculator ahora elimina por completo nuestros defectos de diseño mencionados anteriormente y brinda una solución limpia que se adhiere al Principio Abierto-Cerrado. Sigamos con otros principios SOLID en Java

## 3. Liskov substitution principle (LSP)

Robert C. Martin lo describe como Los tipos derivados deben ser completamente sustituibles por sus tipos base.

El principio de sustitución de Liskov supone que q (x) es una propiedad, demostrable sobre entidades de x que pertenecen al tipo T.Ahora, de acuerdo con este principio, q (y) ahora debería ser demostrable para objetos y que pertenecen al tipo S, y la S es en realidad un subtipo de T. ¿Está ahora confundido y no sabe qué significa realmente el principio de sustitución de Liskov? La definición puede resultar un poco compleja, pero de hecho es bastante fácil. Lo único es que cada subclase o clase derivada debe ser sustituible por su clase principal o base.

Puede decirse que es un principio único orientado a objetos. El principio se puede simplificar aún más mediante: un tipo de hijo de un tipo de padre en particular sin hacer ninguna complicación o hacer explotar las cosas debe tener la capacidad de reemplazar a ese padre. Este principio está estrechamente relacionado con el principio de sustitución de Liskov.

### Por qué se requiere este principio de LSP

Esto evita el mal uso de la herencia. Nos ayuda a conformarnos con la relación "es-un".También podemos decir que las subclases deben cumplir con un contrato definido por la clase base. En este sentido, se relaciona con  Design by Contract  que fue descrito por primera vez por Bertrand Meyer. Por ejemplo, es tentador decir que un círculo es un tipo de elipse, pero los círculos no tienen dos focos o ejes mayores / menores.

El LSP se explica popularmente usando el ejemplo del cuadrado y el rectángulo. si asumimos una relación ISA entre Cuadrado y Rectángulo. Por lo tanto, lo llamamos "El cuadrado es un rectángulo". El siguiente código representa la relación.

```java
public class Rectangle {
    private int length;
    private int breadth;

    public int getLength() {
        return length;
    }

    public void setLength(int length) {
        this.length = length;
    }

    public int getBreadth() {
        return breadth;
    }

    public void setBreadth(int breadth) {
        this.breadth = breadth;
    }

    public int getArea() {
        return this.length * this.breadth;
    }
}
```

A continuación se muestra el código de Square. Tenga en cuenta que Square extiende Rectangle.

```java
public class Square extends Rectangle {
    public void setBreadth(int breadth) {
        super.setBreadth(breadth);
        super.setLength(breadth);
    }

    public void setLength(int length) {
        super.setLength(length);
        super.setBreadth(length);
    }
}
```

En este caso, tratamos de establecer una relación ISA entre Square y Rectangle de manera que llamar a "Square is a Rectangle" en el código siguiente comenzaría a comportarse de forma inesperada si se pasa una instancia de Square. Se arrojará un error de afirmación en el caso de verificar "Área" y verificar "Amplitud", aunque el programa terminará cuando se arroje el error de afirmación debido a la falla de la verificación de Área.

```java
public class LSPDemo {
    public void calculateArea(Rectangle r) {
        r.setBreadth(2);
        r.setLength(3);
        assert r.getArea() == 6 : printError("area", r);
        assert r.getLength() == 3 : printError("length", r);
        assert r.getBreadth() == 2 : printError("breadth", r);
    }

    private String printError(String errorIdentifer, Rectangle r) {
        return "Unexpected value of " + errorIdentifer + " for instance of " + r.getClass().getName();
    }

    public static void main(String[] args) {
        LSPDemo lsp = new LSPDemo();
        // An instance of Rectangle is passed
        lsp.calculateArea(new Rectangle());
        // An instance of Square is passed
        lsp.calculateArea(new Square());
    }
}
```

La clase demuestra el principio de sustitución de Liskov (LSP). Según el principio, las funciones que usan referencias a las clases base deben poder usar objetos de clase derivada sin saberlo.

Por lo tanto, en el ejemplo que se muestra a continuación, la función calculateArea que usa la referencia de “Rectangle” debería poder usar los objetos de clase derivada como Square y cumplir con el requisito planteado por la definición de Rectangle. Se debe tener en cuenta que, según la definición de Rectángulo, lo siguiente siempre debe ser cierto dados los datos a continuación:

- La longitud siempre debe ser igual a la longitud pasada como entrada al método, setLength
- La amplitud siempre debe ser igual a la amplitud pasada como entrada al método, setBreadth
- El área siempre debe ser igual al producto de largo y ancho

En caso de que intentemos establecer una relación ISA entre Square y Rectangle de manera que llamemos "Square is a Rectangle", el código anterior comenzaría a comportarse de forma inesperada si se pasa una instancia de Square. Se producirá un error de afirmación en caso de comprobar el área y comprobar para amplitud, aunque el programa terminará cuando se produzca el error de afirmación debido a una falla en la verificación del área.

La clase Square no necesita métodos como setBreadth o setLength. La clase LSPDemo necesitaría conocer los detalles de las clases derivadas de Rectangle (como Square) para codificar adecuadamente para evitar errores de lanzamiento. El cambio en el código existente rompe el principio abierto-cerrado en primer lugar.
  
## 4. Interface segregation principle (ISP)

Robert C. Martin lo describe como que los clientes no deberían verse obligados a implementar métodos innecesarios que no utilizarán.

De acuerdo con el principio de segregación de interfaces,  un cliente, no importa qué, nunca debe estar obligado a implementar una interfaz que no usa o el cliente nunca debe estar obligado a depender de ningún método que no sea utilizado por ellos. principios, ya que prefiere las interfaces, que son pequeñas pero específicas del cliente en lugar de monolíticas y una interfaz más grande. En resumen, sería malo para usted obligar al cliente a depender de una determinada cosa, que no necesita.

Por ejemplo, una única interfaz de registro para escribir y leer registros es útil para una base de datos pero no para una consola. La lectura de registros no tiene sentido para un registrador de consola. Continuando con este artículo Principios SÓLIDOS en Java.

### Por qué se requiere este principio de ISP

Supongamos que existe una interfaz de restaurante que contiene métodos para aceptar pedidos de clientes en línea, clientes de acceso telefónico o telefónico y clientes sin cita previa. También contiene métodos para manejar pagos en línea (para clientes en línea) y pagos en persona (para clientes sin cita previa y clientes telefónicos cuando su pedido se entrega en casa).

Ahora creemos una interfaz Java para restaurante y la nombramos RestaurantInterface.java.

```java
public interface RestaurantInterface {
    public void acceptOnlineOrder();
    public void takeTelephoneOrder();
    public void payOnline();
    public void walkInCustomerOrder();
    public void payInPerson();
}
```

Hay 5 métodos definidos en RestaurantInterface que son para aceptar pedidos en línea, tomar pedidos telefónicos, aceptar pedidos de un cliente sin cita previa, aceptar pagos en línea y aceptar pagos en persona.

Comencemos por implementar RestaurantInterface para clientes en línea como OnlineClientImpl.java

```java
public class OnlineClientImpl implements RestaurantInterface {
    public void acceptOnlineOrder() {
        // logic for placing online order
    }

    public void takeTelephoneOrder() {
        // Not Applicable for Online Order
        throw new UnsupportedOperationException();
    }

    public void payOnline() {
        // logic for paying online
    }

    public void walkInCustomerOrder() {
        // Not Applicable for Online Order
        throw new UnsupportedOperationException();
    }

    public void payInPerson() {
        // Not Applicable for Online Order
        throw new UnsupportedOperationException();
    }
}
```

- Dado que el código anterior (OnlineClientImpl.java) es para pedidos en línea, lance UnsupportedOperationException.

- Los clientes en línea, telefónicos y sin cita previa utilizan la implementación de RestaurantInterface específica para cada uno de ellos.

- Las clases de implementación para el cliente telefónico y el cliente Walk-in tendrán métodos no admitidos.

- Dado que los 5 métodos son parte de RestaurantInterface, las clases de implementación deben implementar los 5.

- Los métodos que arroja cada una de las clases de implementación UnsupportedOperationException. Como puede ver claramente, implementar todos los métodos es ineficiente.

- Cualquier cambio en cualquiera de los métodos de RestaurantInterface se propagará a todas las clases de implementación. El mantenimiento del código comienza a volverse realmente engorroso y los efectos de regresión de los cambios seguirán aumentando.

- RestaurantInterface.java rompe el Principio de Responsabilidad Única porque la lógica de los pagos y la de la realización de pedidos se agrupan en una única interfaz.

Para superar los problemas mencionados anteriormente, aplicamos el principio de segregación de interfaces para refactorizar el diseño anterior.

1. Separe las funcionalidades de pago y colocación de pedidos en dos interfaces lean separadas, PaymentInterface.java y OrderInterface.java.

2. Cada uno de los clientes usa una implementación de PaymentInterface y OrderInterface. Por ejemplo, OnlineClient.java usa OnlinePaymentImpl y OnlineOrderImpl y así sucesivamente.

3. El principio de responsabilidad única ahora se adjunta como interfaz de pago (PaymentInterface.java) e interfaz de pedidos (OrderInterface).

4. El cambio en cualquiera de las interfaces de pedido o pago no afecta a la otra. Ahora son independientes. No habrá necesidad de hacer ninguna implementación ficticia o lanzar una UnsupportedOperationException ya que cada interfaz solo tiene métodos que siempre usará.

![antes de ISP](/Java/isp/solid_isp_before.png)

Después de aplicar ISP

![despues de ISP](/Java/isp/solid_isp_after.png)
  
## 5. Dependency Inversion principle (DIP)

Robert C. Martin lo describe como que depende de abstracciones, no de concreciones. Según él, el módulo de alto nivel nunca debe depender de ningún módulo de bajo nivel. por ejemplo

Vas a una tienda local a comprar algo y decides pagarlo con tu tarjeta de débito. Por lo tanto, cuando le da su tarjeta al empleado para que realice el pago, el empleado no se molesta en verificar qué tipo de tarjeta le ha dado.

Incluso si le ha dado una tarjeta Visa, él no apagará una máquina Visa para pasar su tarjeta. Ni siquiera importa el tipo de tarjeta de crédito o débito que tenga para pagar; simplemente lo deslizarán. Entonces, en este ejemplo, puede ver que tanto usted como el empleado dependen de la abstracción de la tarjeta de crédito y no están preocupados por los detalles de la tarjeta. Esto es lo que es un principio de inversión de dependencia.

### Por qué se requiere este principio de DIP

Permite a un programador eliminar dependencias codificadas de forma rígida para que la aplicación se acople de forma flexible y se pueda ampliar.

```java
public class Student {
    private Address address;

    public Student() {
        address = new Address();
    }
}
```

En el ejemplo anterior, la clase Student requiere un objeto Address y es responsable de inicializar y usar el objeto Address. Si la clase de dirección se cambia en el futuro, también tenemos que hacer cambios en la clase de estudiante. Esto crea un acoplamiento estrecho entre los objetos Student y Address. Podemos resolver este problema utilizando el patrón de diseño de inversión de dependencia. es decir, el objeto Dirección se implementará de forma independiente y se le proporcionará al Estudiante cuando se cree una instancia del Estudiante mediante el uso de la inversión de dependencia basada en constructores o establecedores.

---
  
:octocat: [Check more about Java in my repository.](https://github.com/FernandoCalmet/SOLID-principles)

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/T6T41JKMI)
