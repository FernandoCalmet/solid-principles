package Java.srp.example1;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class SecurityService {
    private SecurityService() {
        throw new IllegalStateException("Utility class");
    }

    public static boolean checkAccess(User user) {
        // Verify if the user is valid
        if (user != null) {
            // Verify if user exist
        }
        return true;
    }
}