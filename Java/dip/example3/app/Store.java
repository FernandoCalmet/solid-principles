package Java.dip.example3.app;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Store {
    protected PaymentProcessor paymentProcessor;

    public Store(PaymentProcessor paymentProcessor) {
        this.paymentProcessor = paymentProcessor;
    }

    public void purchase() {
        this.paymentProcessor.pay();
    }
}
