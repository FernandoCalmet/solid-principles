package Java.ocp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class ShortMenuOutput implements MenuOutput {

    @Override
    public String output(Player players[]) {
        StringBuffer menu = new StringBuffer();
        menu.append("Nombre\t\tEdad\n");

        for (Player player : players) {
            menu.append(player.name + "\t" + player.age + "\n");
        }

        return menu.toString();
    }

}