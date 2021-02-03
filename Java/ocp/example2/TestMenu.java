package Java.ocp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class TestMenu {
    public static void main(String[] args) {
        Player lstPlayers[] = new Player[3];

        lstPlayers[0] = new Player(1, "Fernando", 31);
        lstPlayers[1] = new Player(2, "Andres", 26);
        lstPlayers[2] = new Player(3, "Calmet", 29);

        Team team = new Team();
        team.addPlayers(lstPlayers);

        Menu menu = new Menu();
        System.out.println(menu.view(team.getPlayers(), new AllMenuOutput()));
        System.out.println(menu.view(team.getPlayers(), new ShortMenuOutput()));
    }
}
