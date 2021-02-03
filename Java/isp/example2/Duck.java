package Java.isp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Duck implements CanFloat, CanCuack, CanPlay {

    @Override
    public String floating() {
        return "The duck is floating";
    }

    @Override
    public String quack() {
        return "The duck is quacking";
    }

    @Override
    public String play() {
        return this.floating() + "\n" + this.quack();
    }
}
