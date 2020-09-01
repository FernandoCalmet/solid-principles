package ocp.example1;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Circle implements Shape {
    public double radius;

    public double calculateArea() {
        return (22 / 7) * radius * radius;
    }
}