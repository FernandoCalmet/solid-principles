package Java.lsp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Shape_O {
    protected double areas[] = new double[5];

    public boolean insert(Shape shape, int hole) {
        return shape.area() <= this.areas[hole];
    }
}
