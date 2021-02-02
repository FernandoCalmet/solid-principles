package Java.dip.example1;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Student {
    private Address address;

    public Student() {
        this.address = new Address();
    }

    public Address getAddress() {
        return this.address;
    }
}