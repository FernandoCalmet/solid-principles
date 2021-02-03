package Java.dip.example3.app;

import Java.dip.example3.lib.Paypal.PaypalApi;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class PayPalPaymentProcessor implements PaymentProcessor {

    protected PaypalApi paypalApi;

    public PayPalPaymentProcessor(PaypalApi paypalApi) {
        this.paypalApi = paypalApi;
    }

    public void pay() {
        this.paypalApi.chargeCustomer();
    }
}
