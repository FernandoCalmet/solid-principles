package Java.srp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Menu {
    public String view(Product products[]) {
        StringBuffer menu = new StringBuffer();
        menu.append("ID\tNombre\t\tPrecio\n");

        for (Product product : products) {
            menu.append(product.id + "\t" + product.name + "\t" + product.price + "\n");
        }

        return menu.toString();
    }
}
