public class GameDriver {
    public static void main(String[] args) {
        runGame("Rock Paper Scissors", new RockPaperScissors(new RandomPlayer("Andrea Farina"), new ConsecutivePlayer("Consecutive")), 10);
        runGame("Prisoner's Dilemma", new PrisonerDilemmas(new RandomPlayer("Andrea Farina"), new ConsecutivePlayer("Consecutive")), 10);
    }

    private static void runGame(String title, Game game, int turns) {
        System.out.println("=== " + title + " ===");
        game.play(turns);
        Player winner = game.getWinner();
        System.out.println(game.getFirstPlayer().getName() + ": " + game.getFirstPlayer().getScore());
        System.out.println(game.getSecondPlayer().getName() + ": " + game.getSecondPlayer().getScore());
        System.out.println(winner == null ? "Tie" : "Winner: " + winner.getName());
        System.out.println();
    }
}
