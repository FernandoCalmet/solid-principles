package Java.dip.example3.app;

import Java.dip.example3.lib.MyBank.MyBankApi;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class MyBankPaymentProcessor implements PaymentProcessor {

    protected MyBankApi myBankApi;

    public MyBankPaymentProcessor(MyBankApi myBankApi) {
        this.myBankApi = myBankApi;
    }

    public void pay() {
        this.myBankApi.charge();
    }
}