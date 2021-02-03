package Java.ocp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class AllMenuOutput implements MenuOutput {

    @Override
    public String output(Player players[]) {
        StringBuffer menu = new StringBuffer();
        menu.append("ID\tNombre\t\tEdad\n");

        for (Player player : players) {
            menu.append(player.id + "\t" + player.name + "\t" + player.age + "\n");
        }

        return menu.toString();
    }
}
