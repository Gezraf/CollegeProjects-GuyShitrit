public class PrisonerDilemmas extends Game {
    public PrisonerDilemmas(Player p1, Player p2) {
        super(p1, p2, "Prisoner's Dilemma");
        initActions();
    }

    protected void initActions() {
        this.actions = new Action[] {
            new Action("Testify"),
            new Action("Silent")
        };
    }

    protected void rewardPlayers(Action a1, Action a2) {
        Player p1 = getFirstPlayer();
        Player p2 = getSecondPlayer();
        Action testify = actions[0];
        boolean t1 = a1.equals(testify);
        boolean t2 = a2.equals(testify);
        if (t1 && t2) {
            p1.updateScore(-5);
            p2.updateScore(-5);
        } else if (t1) {
            p2.updateScore(-15);
        } else if (t2) {
            p1.updateScore(-15);
        } else {
            p1.updateScore(-1);
            p2.updateScore(-1);
        }
    }
}
