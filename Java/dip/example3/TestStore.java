package Java.dip.example3;

import Java.dip.example3.app.MyBankPaymentProcessor;
import Java.dip.example3.app.PayPalPaymentProcessor;
import Java.dip.example3.app.PaymentProcessor;
import Java.dip.example3.app.Store;
import Java.dip.example3.lib.MyBank.MyBankApi;
import Java.dip.example3.lib.Paypal.PaypalApi;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class TestStore {
    public static void main(String[] args) {

        MyBankApi bankApi = new MyBankApi();
        PaymentProcessor paymentByBank = new MyBankPaymentProcessor(bankApi);

        PaypalApi paypalApi = new PaypalApi();
        PaymentProcessor paymentByPaypal = new PayPalPaymentProcessor(paypalApi);

        Store storeA = new Store(paymentByBank);
        storeA.purchase();

        Store storeB = new Store(paymentByPaypal);
        storeB.purchase();
    }
}
