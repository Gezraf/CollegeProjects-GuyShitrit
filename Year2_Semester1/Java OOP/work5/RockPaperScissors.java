public class RockPaperScissors extends Game {
    public RockPaperScissors(Player p1, Player p2) {
        super(p1, p2, "Rock Paper Scissors");
        initActions();
    }

    protected void initActions() {
        this.actions = new Action[] {
            new Action("Rock"),
            new Action("Paper"),
            new Action("Scissors")
        };
    }

    private boolean beats(Action a, Action b) {
        return (a.equals(actions[0]) && b.equals(actions[2]))
            || (a.equals(actions[2]) && b.equals(actions[1]))
            || (a.equals(actions[1]) && b.equals(actions[0]));
    }

    protected void rewardPlayers(Action a1, Action a2) {
        Player p1 = getFirstPlayer();
        Player p2 = getSecondPlayer();
        if (beats(a1, a2)) {
            p1.updateScore(1);
        } else if (beats(a2, a1)) {
            p2.updateScore(1);
        }
    }
}
