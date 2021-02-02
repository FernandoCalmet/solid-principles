package Java.srp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class TestCoffeeShop {
    public static void main(String[] args) {
        Product lstProductos[] = new Product[3];

        lstProductos[0] = new Product("Capuchino", 8.90);
        lstProductos[1] = new Product("Negro", 4.20);
        lstProductos[2] = new Product("Latte", 6.50);

        Cart cart = new Cart();

        CoffeeShop shop = new CoffeeShop(cart);
        shop.addProducts(lstProductos);

        shop.addCart(1, 3);
        shop.getCartTotal();

        Menu menu = new Menu();
        System.out.print(menu.view(shop.getProducts()));
    }
}
