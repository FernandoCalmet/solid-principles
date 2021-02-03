package Java.isp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class TestGame {

    public static void main(String[] args) {
        Pond pond = new Pond();
        System.out.println(pond.sendToPlay(new Duck()));
        System.out.println(pond.sendToPlay(new WoodenDuck()));
        System.out.println(pond.sendToPlay(new Frog()));
    }
}
