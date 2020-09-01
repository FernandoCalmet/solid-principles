package ocp.example1;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Rectangle implements Shape {
    double length;
    double width;

    public double calculateArea() {
        return length * width;
    }
}