package Java.srp.example1;;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class UserSettingService {
    public void changeEmail(User user) {
        if (SecurityService.checkAccess(user)) {
            // Grant option to change
        }
    }
}