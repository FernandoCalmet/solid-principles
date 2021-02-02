package Java.srp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Product {
    protected int id;
    protected String name;
    protected double price;
    private static int idCounter = 1;

    public Product(String name, double price) {
        this.id = idCounter++;
        this.name = name;
        this.price = price;
    }
}
