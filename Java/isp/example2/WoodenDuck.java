package Java.isp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class WoodenDuck implements CanFloat, CanPlay {
    @Override
    public String floating() {
        return "The wooden duck is floating";
    }

    @Override
    public String play() {
        return this.floating();
    }
}
