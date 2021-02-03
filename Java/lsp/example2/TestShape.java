package Java.lsp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class TestShape {

    public static void main(String[] args) {
        Shape circle = new Circle(5);
        Shape square = new Square(10);

        Shape_O shape = new Shape_O();
        System.out.println(shape.insert(circle, 2));
        System.out.println(shape.insert(square, 4));
    }
}