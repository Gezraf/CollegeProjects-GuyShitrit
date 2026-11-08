public class ConsecutivePlayer extends Player {
    private int lastIdx;

    public ConsecutivePlayer(String name) {
        super(name);
        this.lastIdx = -1;
    }

    public Action selectAction(Action[] actions) {
        this.lastIdx = (this.lastIdx + 1) % actions.length;
        return actions[this.lastIdx];
    }
}
