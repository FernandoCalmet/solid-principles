package Java.lsp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Circle extends Shape {

    private double radio;

    public Circle(double radio) {
        this.radio = radio;
    }

    @Override
    public double area() {
        return Math.pow(radio, 2) * Math.PI;
    }
}
