package Java.isp.example1;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class OnlineClientImpl implements RestaurantInterface {
    public void acceptOnlineOrder() {
        // logic for placing online order
    }

    public void takeTelephoneOrder() {
        // Not Applicable for Online Order
        throw new UnsupportedOperationException();
    }

    public void payOnline() {
        // logic for paying online
    }

    public void walkInCustomerOrder() {
        // Not Applicable for Online Order
        throw new UnsupportedOperationException();
    }

    public void payInPerson() {
        // Not Applicable for Online Order
        throw new UnsupportedOperationException();
    }
}