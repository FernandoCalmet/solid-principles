package Java.ocp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Player {

    protected int id;
    protected String name;
    protected int age;

    public Player(int id, String name, int age) {
        this.id = id;
        this.name = name;
        this.age = age;
    }
}