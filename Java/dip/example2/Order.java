package Java.dip.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Order {
    private String customerName;
    private String invoice;

    public Order(String customerName, String invoice) {
        this.customerName = customerName;
        this.invoice = invoice;
    }

    public String getCustomerName() {
        return this.customerName;
    }

    public String getInvoice() {
        return this.invoice;
    }
}