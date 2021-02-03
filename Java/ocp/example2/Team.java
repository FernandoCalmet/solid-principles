package Java.ocp.example2;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Team {
    private Player lstPlayers[];

    public void addPlayers(Player players[]) {
        this.lstPlayers = players;
    }

    public Player[] getPlayers() {
        return this.lstPlayers;
    }
}
