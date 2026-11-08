import java.util.Random;

public class RandomPlayer extends Player {
    private Random random;

    public RandomPlayer(String name) {
        super(name);
        this.random = new Random();
    }

    public Action selectAction(Action[] actions) {
        return actions[random.nextInt(actions.length)];
    }
}
