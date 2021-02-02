package Java.srp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class CoffeeShop {
    private Product lstProducts[];
    private Cart cart;

    public CoffeeShop(Cart cart) {
        this.cart = cart;
    }

    public void addProducts(Product product[]) {
        this.lstProducts = product;
    }

    public Product[] getProducts() {
        return this.lstProducts;
    }

    public void removeProduct(int id) {
        // Lógica para eliminar producto
    }

    public void addCart(int id, int quantity) {
        this.cart.addProduct(id, quantity);
    }

    public double getCartTotal() {
        return this.cart.getTotal();
    }
}
