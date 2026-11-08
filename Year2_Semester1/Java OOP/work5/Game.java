public abstract class Game {
    private Player p1, p2;
    private String name;
    protected Action[] actions;

    public Game(Player p1, Player p2, String name) {
        this.p1 = p1;
        this.p2 = p2;
        this.name = name;
    }

    protected abstract void initActions();

    public void play(int turnCount) {
        for (int i = 0; i < turnCount; i++) {
            playSingleTurn();
        }
    }

    private void playSingleTurn() {
        Action a1 = p1.selectAction(actions);
        Action a2 = p2.selectAction(actions);
        rewardPlayers(a1, a2);
    }

    protected abstract void rewardPlayers(Action a1, Action a2);

    public Player getWinner() {
        if (p1.isWinner(p2)) {
            return p1;
        }
        if (p2.isWinner(p1)) {
            return p2;
        }
        return null;
    }

    protected Player getFirstPlayer() {
        return this.p1;
    }

    protected Player getSecondPlayer() {
        return this.p2;
    }
}
